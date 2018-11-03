using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projAeroporto.Models;
using projAeroporto.Controllers;

namespace projAeroporto
{
    class Program
    {
        static Veiculos veiculos = new Veiculos();
        static Garagens garagens = new Garagens();
        static Viagens viagens = new Viagens();
        static bool emJornada = false;

        static void Main(string[] args)
        {
            string op = "";

            do {
                op = menu();

            } while (op != "0");
        }

        static string menu() {
            Console.WriteLine("0. Sair \n" +
                "1. Cadastrar veículo \n" +
                "2. Cadastrar garagem \n" +
                "3. Iniciar jornada \n" +
                "4. Encerrar jornada \n" +
                "5. Liberar viagem de uma determinada origem para um determinado destino \n" +
                "6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte) \n" +
                "7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino \n" +
                "8. Listar viagens efetuadas de uma determinada origem para um determinado destino \n" +
                "9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino ");
            Console.Write("Digite um opção: ");
            return Console.ReadLine();
        }

        static void cadastrarVeiculo() {
            if (!emJornada)
            {
                Console.Write("Digite o ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.Write("Digite a placa: ");
                string placa = Console.ReadLine();

                Console.Write("Digite a lotação: ");
                int lotacao = Int32.Parse(Console.ReadLine());

                veiculos.incluir(new Veiculo(id, placa, lotacao));
            }
        }

        static void cadastrarGaragem()
        {
            if (!emJornada)
            {
                Console.Write("Digite o ID: ");
                int id = Int32.Parse(Console.ReadLine());

                Console.Write("Digite a local: ");
                string local = Console.ReadLine();

                garagens.incluir(new Garagem(id, local));
            }
        }

        static void iniciarJornada() {
            int i = 0;
            foreach (Veiculo veiculo in veiculos.ListVeiculos) {
                garagens.ListGaragens[i].adicionarVeiculo(veiculo);
                if (i == garagens.ListGaragens.Count) i = 0;
                else i++;
            }
            emJornada = true;
        }

        static void liberarViagem() {
            Console.Write("Digite o ID: ");
            int id = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o ID de origem: ");
            int idOrigem = Int32.Parse(Console.ReadLine());
            Garagem origem = garagens.pesquisar(idOrigem);

            Console.Write("Digite o ID de destino: ");
            int idDestino = Int32.Parse(Console.ReadLine());
            Garagem destino = garagens.pesquisar(idDestino);

            viagens.incluir(new Viagem(id, origem, destino, origem.Veiculos.Pop()));
        }
    }
}
