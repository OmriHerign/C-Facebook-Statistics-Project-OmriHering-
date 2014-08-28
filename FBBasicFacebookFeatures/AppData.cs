using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms;
using BasicFacebookFeatures.WithSingltonAppSettings;

namespace BasicFacebookFeatures
{
   public class AppData
    {
       public User LoggedInUser { get; set; }

       public string AccessToken { get; set; }

       private List<User> m_FriendsList = new List<User>();

       private static AppData s_This;

       public List<User> Friends
       {
           get
           {
               if (m_FriendsList.Count == 0)
               {
                   fetchFriends();
               }

               return m_FriendsList;
           }
       }

       public static AppData Instance
       {
           get
           {
               lock (new object())
               {
                   if (s_This == null)
                   {
                       s_This = new AppData();
                   }
               }
               return s_This;
           }
       }

       

       private AppData()
       {
           LoginResult result = FacebookService.Login("621056897936312", 
                   "user_about_me", "friends_about_me", "publish_stream", "user_events", "read_stream",
                   "user_status");
           FacebookService.s_CollectionLimit = 500;
           if (string.IsNullOrEmpty(result.ErrorMessage))
           {
               LoggedInUser = result.LoggedInUser;
           }
           else
           {
               MessageBox.Show(result.ErrorMessage);
           }
       }

       private void fetchFriends()
       {
           foreach (User friend in LoggedInUser.Friends)
           {
               m_FriendsList.Add(friend);
           }
       }
       
       
    }
}
