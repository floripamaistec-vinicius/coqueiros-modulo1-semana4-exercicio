using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m01_s04
{
    public static class Repositorio
    {
        public static List<Bebida> ListaDeBebidas { get; set; }
        public static List<Suco> ListaDeSucos { get; set; }
        public static List<Refrigerante> ListaDeRefrigerantes { get; set; }
        public static void AdicionarSuco(Suco suco)
        {
            ListaDeSucos.Add(suco);
        }
        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            ListaDeRefrigerantes.Add(refrigerante);
        }
        public static void AdicionarBebida(Bebida bebida)
        {
            ListaDeBebidas.Add(bebida);
        }
        public static void AlterarBebida(Bebida bebida)
        {
            AlterarNomeBebida(bebida);
            AlterarMiliLitro(bebida);
            AlterarPreco(bebida);
        }
        public static Bebida PesquisarBebida(Bebida bebida)
        {
            foreach (Bebida item in ListaDeBebidas.Where(listaEmMemoria => listaEmMemoria.ID == bebida.ID))
            {
                return item;
            }
            return null;
        }
        public static void AlterarNomeBebida(Bebida bebida)
        {
            Console.WriteLine("Nome da Bebida:");
            bebida.NomeBebida = Console.ReadLine();
        }
        public static void AlterarMiliLitro(Bebida bebida)
        {
            Console.WriteLine("Nome da Bebida:");
            bebida.MiliLitro = decimal.Parse(Console.ReadLine());
        }
        public static void AlterarPreco(Bebida bebida)
        {
            Console.WriteLine("Nome da Bebida:");
            bebida.MiliLitro = decimal.Parse(Console.ReadLine());
        }
    }
}
