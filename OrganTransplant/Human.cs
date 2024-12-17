using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Human
    {
        public string _name { get; private set; }
        public int _age {  get; private set; }
        public bool _isHealthy { get; private set; }

        public List<Organ> _myOrgans { get; private set; } = new List<Organ>();
        

        public Human(string name, int age, bool isHealthy, List<Organ> myOrgans) 
        {
            _name = name;
            _age = age;
            _isHealthy = isHealthy;
            _myOrgans = myOrgans;
        }
        

    }
}
