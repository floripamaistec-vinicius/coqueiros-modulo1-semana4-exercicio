using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m01_s04
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }
        public Suco(string tipoCaixa, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra) : base(id, tipo, miliLitro, nomeBebida, valorCompra)
        {
            TipoCaixa = tipoCaixa;
            ID = id;
            Tipo = tipo;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorCompra = valorCompra;

        }
        public void ImprimirDados()
        {
            Console.WriteLine("Produto ID: {0}", ID);
            Console.WriteLine("Tipo: {0}", TipoCaixa);
            Console.WriteLine("Volume: {0} ml", MiliLitro);
        }
    }
}
