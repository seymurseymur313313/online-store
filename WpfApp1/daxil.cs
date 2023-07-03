using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class daxil
    {
        public daxil(int ad)
        {
            this.ad = ad;
        }

        public daxil(string qayidis) 
        {
            this.qayidis = qayidis;
        }   

        public int ad { get; set; }
        public string qayidis { get; set; }

    }
}
