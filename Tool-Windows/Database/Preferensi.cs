using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tool_Windows.Database
{
    class Preferensi
    {
        public List<string> SubMenu { get; set; }
        public string userLogin { get; set; }
        public string passwordLogin { get; set; }
        public bool login { get; set; }

        public Dictionary<string, bool> sesiSubMenu { get; set; }

        /*public Preferensi()
        {
            return 
        }*/
    }
}
