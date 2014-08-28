using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicFacebookFeatures
{
    class TopResponderFactory
    {

        public ITopResponder getTopResponder(int checkBox) 
        {
            if (checkBox == 1)
            {
                return new TopResponderByYear();
            }
            else
            {
                return new TopResponderOfMount();
            }

        }
    }
}
