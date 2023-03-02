using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m01_s04
{
    public class Refrigerante : Bebida
    {
        public bool Vidro { get; set; }
        public Refrigerante(bool vidro, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base(id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            Vidro = vidro;
            ID = id;
            Tipo = tipo;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorCompra = valorCompra;
        }
        public void ImprimirDados()
        {
            if (Vidro == true)
            {
                Console.WriteLine("Produto ID: {0}", ID);
                Console.WriteLine("Volume: {0} ml", MiliLitro);
                Console.WriteLine("Garrafa: Vidro");
            }
            else
            {
                Console.WriteLine("Produto ID: {0}", ID);
                Console.WriteLine("Volume: {0} ml", MiliLitro);
                Console.WriteLine("Garrafa: PET");
            }
        }
    }
}
