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
        public Suco() : base() { }
        public Suco(int id, string tipo, string tipoCaixa) : base(id, tipo)
        {
            this.TipoCaixa = tipoCaixa;
        }
        public void ImprimirSuco()
        {
            Console.WriteLine("ID: {0} Tipo: {1} TipoCaixa: {2}", ID, Tipo, TipoCaixa);
        }
    }
}
