using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace m01_s04
{
    public class Repositorio
    {
        public static List<Bebida> ListaBebidas = new List<Bebida>();
        public static List<Refrigerante> ListaRefrigerantes = new List<Refrigerante>();
        public static List<Suco> ListaSucos = new List<Suco>();
        public static void AdicionarBebida(Bebida parametro)
        {
            if (parametro.Tipo == "Refrigerante")
            {
                Refrigerante refrigerante = new Refrigerante();
                refrigerante.Tipo = parametro.Tipo;
                refrigerante.Vidro = bool.Parse(Console.ReadLine());
                AdicionarRefrigerante(refrigerante);
            }
            else if (parametro.Tipo == "Suco")
            {
                Suco suco = new Suco();
                suco.Tipo = parametro.Tipo;
                suco.TipoCaixa = Console.ReadLine();
                AdicionarSuco(suco);
            }
            else
            {
                ListaBebidas.Add(parametro);
            }
        }
        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            ListaRefrigerantes.Add(refrigerante);
            ListaBebidas.Add(refrigerante);
        }
        public static void AdicionarSuco(Suco suco)
        {
            ListaSucos.Add(suco);
            ListaBebidas.Add(suco);
        }
        public static void AlterarBebida(Bebida parametro)
        {
            Bebida bebida = ListaBebidas.Find(idFind => idFind.ID == parametro.ID);
            if (bebida == null) return;
            if (bebida is Refrigerante refrigerante)
            {
                refrigerante.ID = parametro.ID;
                refrigerante.Tipo = parametro.Tipo;
                refrigerante.Vidro = bool.Parse(Console.ReadLine());
            }
            else if (bebida is Suco suco)
            {
                suco.ID = parametro.ID;
                suco.Tipo = parametro.Tipo;
                suco.TipoCaixa = Console.ReadLine();
            }
            else
            {
                bebida.ID = parametro.ID;
                bebida.Tipo = parametro.Tipo;
            }
        }
        public static void ExcluirBebida(int id)
        {
            Bebida bebida = ListaBebidas.Find(idFind => idFind.ID == id);
            if (bebida == null) return;
            if (bebida is Refrigerante refrigerante)
            {
                ListaBebidas.Remove(refrigerante);
                ListaRefrigerantes.Remove(refrigerante);
            }
            else if (bebida is Suco suco)
            {
                ListaBebidas.Remove(suco);
                ListaSucos.Remove(suco);
            }
            else
            {
                ListaBebidas.Remove(bebida);
            }
        }
        public static void ListarBebida()
        {
            foreach(Bebida bebida in ListaBebidas)
            {
                Console.WriteLine(bebida.ToString());
            }
        }
    }
}
