using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Forms
{
    public class AddressUpdateEventArgs : System.EventArgs
    {
        private string paddress;
        private string pname;
        public AddressUpdateEventArgs(string address, string name)
        {
            this.paddress = address;
            this.pname = name;
        }
        public string Address { get { return paddress; } }
        public string Name { get { return pname; } }
    }
}
