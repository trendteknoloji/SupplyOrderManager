using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Entity.Main
{
    public class SOMAttribute : Attribute
    {
        private string tag;
        private string version;

        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        public string Tag
        {
            get { return tag; }
            set { tag = value; }
        }
        public SOMAttribute()
        {
            Tag = "Tanımsız";
            Version = "Tanımsız";
        }
        public SOMAttribute(string Version)
        {
            this.Version = Version;
        }
        public SOMAttribute(string Tag, string Version)
        {
            this.Tag = Tag;
            this.Version = Version;
        }
    }
}
