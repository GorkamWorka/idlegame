using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace WebApplication1
{
    public class Ressource
    {
        private string _name = "";

        public Double growth = 0;
        public Double value = 0;
        public int power { get; } = 1;
        public string name { get {return _name;} }
        public string label { get; set; }

        public Ressource(string name)
        {
            this._name = name;
            label = name;
        }

        public Ressource(string name, double growth) : this(name)
        {
            this.growth = growth;
        }

        public void OnCycleEndHandler(object sender, ElapsedEventArgs e)
        {
            value += growth;
        }
    }
}
