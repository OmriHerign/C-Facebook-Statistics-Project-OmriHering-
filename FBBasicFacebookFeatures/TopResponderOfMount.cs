using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
   public  class TopResponderOfMount : ITopResponder
    {
        public enum eResponseType
        {
            Comment,
            Like
        }
            private readonly List<Responder> r_Responders = new List<Responder>();



            public List<Responder> RespondersTable
            {
                get { return r_Responders; }
                set{}
            }

            public TopResponderOfMount()
            {
                period = "Mount";
            }

            public void FillAndSortRespondersTable()
            {

                r_Responders.Clear();
                int statusesTime = 0;
                int statusesTimeOftoday = 0;

                FacebookObjectCollection<Post> userStatuses = FacebookService.GetCollection<Post>("Statuses", "me", "", 100);

                foreach (Post status in userStatuses)
                {
                    GetTImeOfStatus(ref statusesTime, ref statusesTimeOftoday, status);

                    if (statusesTime == statusesTimeOftoday)
                    {
                        foreach (Comment postComment in status.Comments)
                        {
                            updateResponderTable(postComment.From, eResponseType.Comment);
                        }

                        FacebookObjectCollection<User> likedBy = FacebookService.GetCollection<User>("likes", status.Id, "", 100);

                        foreach (User userLiked in likedBy)
                        {
                            updateResponderTable(userLiked, eResponseType.Like);
                        }
                    }
                }
                r_Responders.OrderBy(o => o.NumOfLikes);
                r_Responders.Reverse();
            }

            private static void GetTImeOfStatus(ref int statusesTime, ref int statusesTimeOftoday, Post status)
            {
                    statusesTime = status.UpdateTime.Value.Month;
                    statusesTimeOftoday = DateTime.Now.Month;       
            }

            private void updateResponderTable(User i_User, eResponseType i_ResponseType)
            {
                Responder responder = GetResponderFromList(i_User.Id);

                if (responder == null)
                {
                    responder = new Responder(i_User);
                    r_Responders.Add(responder);
                }

                switch (i_ResponseType)
                {
                    case eResponseType.Comment:
                        responder.NumOfComments++;
                        break;
                    case eResponseType.Like:
                        responder.NumOfLikes++;
                        break;
                    default:
                        break;
                }
            }

            public Responder GetResponderFromList(string i_UserId)
            {
                Responder responderFromList = null;

                foreach (Responder responder in r_Responders)
                {
                    if (responder.ResponderUser.Id == i_UserId)
                    {
                        responderFromList = responder;
                        break;
                    }
                }

                return responderFromList;
            }
        

            public string period
            {
                get;
                set;
            }

            
    }
    }
    
