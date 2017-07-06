using System;
using System.Collections.Generic;
using System.Text;

namespace PorpoiseMobileApp.iOS
{
    public interface IHasDisplayHint
    {
        DisplayHint Hint
        {
            get;
        }
    }

    public class DisplayHint
    {
        public bool Modal
        {
            get;
            set;
        }

        public bool MakeRoot
        {
            get;
            set;
        }

        public bool ClearToRoot
        {
            get;
            set;
        }

        public bool Animate
        {
            get;
            set;
        }

        public bool FullScreen { get; set; }

        public string BackTitle
        {
            get;
            set;
        }
    }
}
