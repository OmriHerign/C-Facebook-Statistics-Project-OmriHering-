using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures.WithSingltonAppSettings
{// $G$ THE-001 (-5) your grade on diagrams document - 69. please see comments inside the document. (40% of your grade).
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("designpatterns");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new checkInByFriends());
        }
    }
}
