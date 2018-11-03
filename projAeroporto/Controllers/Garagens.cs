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
        private List<Garagem> listGaragens;

        public Garagens()
        {
            this.listGaragens = new List<Garagem>();
        }

        public List<Garagem> ListGaragens { get { return listGaragens; } }

        public void incluir(Garagem garagem)
        {
            listGaragens.Add(garagem);
        }

        public Garagem pesquisar(int id) {
            return listGaragens.FirstOrDefault(g => g.Id == id);
        }
    }
}
