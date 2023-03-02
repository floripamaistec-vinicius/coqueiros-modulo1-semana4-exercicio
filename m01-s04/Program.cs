// See https://aka.ms/new-console-template for more information
using m01_s04;

Bebida bebida = new Bebida(0, "Suco", 500, "Suco de Uva", 10);
Repositorio.AlterarBebida(Repositorio.PesquisarBebida(bebida));
