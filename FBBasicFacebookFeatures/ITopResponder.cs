using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicFacebookFeatures
{
   public interface ITopResponder
    {

        List<Responder> RespondersTable
       {
           get;
           set;
       }

        string period { get; set; }

        void FillAndSortRespondersTable();
        
    }
}
