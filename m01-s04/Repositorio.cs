using System;
using System.Collections.Generic;
using System.Linq;
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
                refrigerante.ID = parametro.ID;
                refrigerante.Tipo = parametro.Tipo;
                refrigerante.Vidro = true;
                AdicionarRefrigerante(refrigerante);
            }
            else if (parametro.Tipo == "Suco")
            {
                Suco suco = new Suco();
                suco.ID = parametro.ID;
                suco.Tipo = parametro.Tipo;
                suco.TipoCaixa = "Tetra Park";
                AdicionarSuco(suco);
            }
            else
            {
                ListaBebidas.Add(parametro);
            }
        }
        public static void AdicionarSuco(Suco suco)
        {
            ListaSucos.Add(suco);
            ListaBebidas.Add(suco);
        }
        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            ListaRefrigerantes.Add(refrigerante);
            ListaBebidas.Add(refrigerante);
        }
        public static void AlterarBebida(Bebida bebida) { }
        public static void ExcluirBebida(int id)
        {

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
