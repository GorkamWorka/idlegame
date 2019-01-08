using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class DataModel
    {
        private List<Ressource> _ressources = new List<Ressource>();
        private List<Ressource> _hiddenRessources = new List<Ressource>();
        private CycleManager _cycle;

        public Ressource GetRessourceByName(string name) => _ressources.Single(res => res.name == name);
        public Ressource GetHiddenRessourceByName(string name) => _hiddenRessources.Single(res => res.name == name);
        

        public DataModel()
        {
            this._cycle = new CycleManager();
            this._cycle.cycleLength = 10000;
        }

        public void addRessource(Ressource res)
        {
            this._ressources.Add(res);
            this._cycle.AddToCycle(res.OnCycleEndHandler);
        }
    }
}
