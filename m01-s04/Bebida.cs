using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m01_s04
{
    public class Bebida
    {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }
        public Bebida (int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorCompra)
        {
            this.ID = id;
            this.Tipo = tipo;
            this.MiliLitro = miliLitro;
            this.NomeBebida = nomeBebida;
            this.ValorCompra = valorCompra;
        }
        public void Comprar()
        {
            Console.WriteLine("Valor da compra do produto ID {0} alterado para {1}", ID, ValorCompra);
        }
    }
}
