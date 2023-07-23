using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    enum Type_Cable
    {
        Ethernet, token_ring
    }
    internal class NIC
    {

        string manufacture;
        int mac_address;
        Type_Cable type;

        private NIC()
        {

        }

        public static NIC Instance { get; } = new NIC() { manufacture = "kia", mac_address = 6562323, type = Type_Cable.Ethernet };

        //public string Manufacture { get => this.manufacture; set => this.manufacture = value; }
        //public int MacAddress { get => this.mac_address; set => this.mac_address = value; }
        //public string Type { get => this.type; set => this.type = value; }


    }
}
