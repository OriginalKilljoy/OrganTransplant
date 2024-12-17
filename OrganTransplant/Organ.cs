using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Organ
    {
        public string _type {  get; private set; }
        public bool _isHealthy {  get; private set; }

        public Organ(string type, bool isHealthy) 
        {
            _type = type;
            _isHealthy = isHealthy;
        }
    }
}
