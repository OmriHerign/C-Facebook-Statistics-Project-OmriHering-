using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
namespace BasicFacebookFeatures
{
    public class Responder
    {
        public int NumOfComments { get; set; }

        public int NumOfLikes { get; set; }

        public User ResponderUser { get; set; }

        public Responder(User l_FriendUser)
        {
            ResponderUser = l_FriendUser;
        }

        public override string ToString()
        {
            return ResponderUser.Name;
        }

        
    }
}
