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
        public Refrigerante() : base() { }
        public Refrigerante(int ID, string Tipo) : this()
        {
            ID = ID;
            Tipo = Tipo;
        }
        public Refrigerante(int id, string tipo, bool vidro) : base(id, tipo)
        {
            this.Vidro = vidro;
        }
        public void ImprimirRefrigerante()
        {
            Console.WriteLine("ID: {0} Tipo: {1} Vidro: {2}", ID, Tipo, Vidro);
        }
    }
}
