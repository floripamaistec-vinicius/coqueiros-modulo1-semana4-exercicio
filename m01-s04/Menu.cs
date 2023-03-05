using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace m01_s04
{
    public class Menu
    {
        public static string consoleMenuPrincipal()
        {
            Console.WriteLine("1 - Adicionar ");
            Console.WriteLine("2 - Alterar ");
            Console.WriteLine("3 - Excluir ");
            Console.WriteLine("4 - Listar ");
            Console.WriteLine("5 - Sair ");
            return Console.ReadLine();
        }
        public static void opcaoMenuPrincipal()
        {
            string Opcao;
            do
            {
                Opcao = consoleMenuPrincipal();
                switch(Opcao)
                {
                    case "1":
                        Repositorio.AdicionarBebida(CadastrarBebida()); break;
                    case "2":
                        Repositorio.AlterarBebida(SelecionarBebida()); break;
                        break;
                    case "3":
                        Repositorio.ExcluirBebida(SelecionarBebida().ID); break;
                    case "4":
                        ListarBebidas(); break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("!opcaValida"); break;
                }
            }
            while (Opcao != "5");
        }
        public static Bebida CadastrarBebida()
        {
            Bebida bebida = new Bebida();
            bebida.ID = int.Parse(Console.ReadLine());
            bebida.Tipo = Console.ReadLine();
            return bebida;
        }
        public static void ListarBebidas()
        {
            foreach (Bebida bebida in Repositorio.ListaBebidas)
            {
                if (bebida is Suco suco)
                {
                    Console.WriteLine("Index: {0} - ID: {1} - Tipo: {2} - Tipo Caixa: {3}", Repositorio.ListaBebidas.IndexOf(bebida), bebida.ID, bebida.Tipo, suco.TipoCaixa);
                }
                else if (bebida is Refrigerante refrigerante)
                {
                    Console.WriteLine("Index: {0} - ID: {1} - Tipo: {2} - Vidro: {3}", Repositorio.ListaBebidas.IndexOf(bebida), bebida.ID, bebida.Tipo, refrigerante.Vidro);
                }
                else
                {
                    Console.WriteLine("Index: {0} - ID: {1} - Tipo: {2}", Repositorio.ListaBebidas.IndexOf(bebida), bebida.ID, bebida.Tipo);
                }
            }
        }
        public static Bebida SelecionarBebida()
        {
            ListarBebidas();
            int indexLista = int.Parse(Console.ReadLine());
            Bebida bebida = Repositorio.ListaBebidas[indexLista];
            return bebida;
        }
    }
}

/*
public void MenuPrincipal()
        {
            ExecutarOpcaoEscolhida();
        }
        private static string EscreverTextoDoMenuPrincipal()
        {
            Console.WriteLine("Estacionamento pareAqui.");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Veículo: Cadastrar");
            Console.WriteLine("2 - Veículo: Histórico");
            Console.WriteLine("3 - Ticket: Entrada");
            Console.WriteLine("4 - Ticket: Saída");
            Console.WriteLine("5 - Sair");
            return Console.ReadLine();
        }
        private static void ExecutarOpcaoEscolhida()
        {
            string Opcao;
            do
            {
                Opcao = EscreverTextoDoMenuPrincipal();
                switch (Opcao)
                {
                    case "1":
                        CadastroCarro.CadastrarCarro(CadastroCarro.InformarPlaca()); break;
                    case "2":
                        CarroNaoCadastradoException.TryCatchCarro(Opcao); break;
                    case "3":
                        CarroNaoCadastradoException.TryCatchCarro(Opcao); break;
                    case "4":
                        CarroNaoCadastradoException.TryCatchCarro(Opcao); break;
                    case "5":
                        break;
                    default: Console.WriteLine("Opção inexistente."); break;
                }
            }
            while (Opcao != "5");
        }
*/