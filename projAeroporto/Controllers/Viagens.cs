using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAeroporto.Models;

namespace projAeroporto.Controllers
{
    class Viagens
    {
        private Queue<Viagem> viagens;

        public Viagens()
        {
            this.viagens = new Queue<Viagem>();
        }

        public Queue<Viagem> queueViagens { get { return viagens; } }

        public void incluir(Viagem viagem)
        {
            viagens.Enqueue(viagem);
        }
    }
}
