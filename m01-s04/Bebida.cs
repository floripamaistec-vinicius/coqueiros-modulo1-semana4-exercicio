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
        public Bebida() { }
        public Bebida(int id, string tipo) : this()
        {
            ID = id;
            Tipo = tipo;
        }
        public void Comprar()
        {
            Console.WriteLine("ID {0} Tipo {1}", ID, Tipo);
        }
    }
}
