using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAeroporto.Models;

namespace projAeroporto.Controllers
{
    class Garagens
    {
        private List<Garagem> garagens;

        public Garagens()
        {
            this.garagens = new List<Garagem>();
        }

        public List<Garagem> lisGaragens { get { return garagens; } }

        public void incluir(Garagem garagem)
        {
            garagens.Add(garagem);
        }
    }
}
