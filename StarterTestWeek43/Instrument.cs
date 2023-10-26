using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterTestWeek43
{
    public class Instrument
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public Instrument(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public override string ToString()
        {
            return $" Id {_id} name {_name}";
        }
    }
}
