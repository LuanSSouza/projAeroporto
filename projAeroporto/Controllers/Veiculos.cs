using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAeroporto.Models;

namespace projAeroporto.Controllers
{
    public class Veiculos
    {
        private List<Veiculo> veiculos;

        public Veiculos()
        {
            this.veiculos = new List<Veiculo>();
        }

        public List<Veiculo> listVeiculos { get { return veiculos; } }

        public void incluir(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }
    }
}
