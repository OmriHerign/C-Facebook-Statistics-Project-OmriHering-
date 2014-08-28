using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.WithSingltonAppSettings
{
    /// <summary>
    /// A class that holds a post that will be shown in the news feed.
    /// </summary>
    internal class PostAdapter
    {
        public PostAdapter(Post i_Post)
        {
            Post = i_Post;
        }

        public Post Post { get; set; }

        /// <summary>
        /// Overriding of the ToString method
        /// </summary>
        /// <returns>The new format of the string representation of the object</returns>
        public override string ToString()
        {
            string stringResult;
            if (Post.Message != null)
            {
                stringResult = string.Format("{0}: [{1}] {2}", Post.From.Name, Post.Type, Post.Message);
            }
            else if (Post.Caption != null)
            {
                stringResult = string.Format("{0}: [{1}] {2}", Post.From.Name, Post.Type, Post.Caption);
            }
            else
            {
                stringResult = string.Format("{0}: [{1}]", Post.From.Name, Post.Type);
            }

            return stringResult;
        }
    }
}
