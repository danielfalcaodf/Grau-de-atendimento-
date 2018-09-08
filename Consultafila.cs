using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Consultafila
    {
        static void Main(string[] args)
        {
            Pacientes p = new Pacientes();
            Hospital H = new Hospital();
            if (H.Inicia())
            {
                Console.WriteLine("Hospital abriu!!");
            }
            string resposta,busca,resposta2,geral;

            do
            {
                Console.Clear();
                Console.WriteLine("**Hospital**");
                Console.WriteLine("1.Cadastrar pacientes");
                Console.WriteLine("2.Consulta Grau de paciente");
                Console.WriteLine("3.Consulta proximo se chamado ");
                Console.WriteLine("4.Alterar dados do paciente");
                Console.WriteLine("5.Excluir dados do paciente");
                Console.WriteLine("6.Sair");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "1": Console.Clear();
                        Console.WriteLine("Cadastro");
                        
                        Console.WriteLine("nome do paciente: ");
                        p.setnome(Console.ReadLine());
                        Console.WriteLine("Idade do paciente: ");
                        p.setidade(Console.ReadLine());
                        Console.WriteLine("Data de nacimento: ");
                        p.setdatanacimento(Console.ReadLine());
                        Console.WriteLine("Sexo do paciente: ");
                        p.setsexo(Console.ReadLine());
                        Console.WriteLine("Endereço do paciente");
                        p.setendereco(Console.ReadLine());
                        Console.WriteLine("RG do paciente");
                        p.setrg(Console.ReadLine());
                        Console.WriteLine("CPF do paciente");
                        p.setcpf(Console.ReadLine());
                        Console.WriteLine("Telefone do paciente");
                        p.settel(Console.ReadLine());
                        Console.WriteLine("celular do paciente");
                        p.setcel(Console.ReadLine());
                        Console.WriteLine("Grau de atendimento\nVERMELHO- Emegecia\nAMARELO- Urgência\nVERDE- Semi-Urgente\nAZUL- Não Urgência");
                        p.setgrau(Console.ReadLine());
                        Console.WriteLine("Descrição/Estado do paciente");
                        p.setdescricao(Console.ReadLine());
                        H.adicionaContato(p);
                        Console.WriteLine("Salvo!!");
                        Console.ReadKey();
                        break;
                    case "2": Console.Clear();
                        Console.WriteLine("Consulta o Grau de antedimento do Paciente");

                        Console.WriteLine("Nome do Paciente?");
                        busca = Console.ReadLine();
                        p = H.Busca(busca);
                        Console.WriteLine("Nome:" + p.getnome());
                        Console.WriteLine("GRau de antedimento:" + p.getgrau());
                        Console.WriteLine("Descrição/Estado do paciente:" + p.getdescricao());
                        Console.ReadKey();


                        break;
                    case "3": Console.Clear();
                        do
                        {

                            Console.WriteLine("Grau de antedimeto");
                            Console.WriteLine("1- VERMELHO");
                            Console.WriteLine("2- AMARELO");
                            Console.WriteLine("3- VERDE");
                            Console.WriteLine("4- AZUL");

                            resposta2 = Console.ReadLine();

                            switch (resposta2)
                            {

                                case "1": Console.Clear();
                                    Pacientes[] Pacientes = new Pacientes[100];
                                    geral = "VERMELHO";
                                    Pacientes[100] = H.Geral(geral);

                                    for (int i = 0; i <=Pacientes.Length; i++)
                                    {
                                        Console.WriteLine("Nome:" + Pacientes[i].getnome());
                                    }
                                        break;

                            } Console.ReadKey();
                        } while (!resposta2.Equals("5"));
                        break;

                    case "4": Console.Clear();
                        Console.WriteLine("Excluir");
                        Console.WriteLine("Oq vc quer aki");
                        String busca2 = Console.ReadLine();
                        string[,] dados1 = new string[10, 3];
                        string del;
                        StreamReader Leitor2 = new StreamReader(@"C:\Users\Etec\Desktop\teste\dados.txt");
                        int x1 = 0;

                        while ((dados1[x1, 0] = Leitor2.ReadLine()) != null)
                        {
                            dados1[x1, 1] = Leitor2.ReadLine();
                            dados1[x1, 2] = Leitor2.ReadLine();
                            x1++;
                        }
                        for (int y = 0; y < 10; y++)
                        {
                            if (busca2.Equals(dados1[y, 0]))
                            {

                                Console.WriteLine("Achei");
                                Console.WriteLine("Tem certeza quer apagar isso? [S/N]");
                                del = Console.ReadLine();
                                if (del.Equals("S"))
                                {
                                    dados1[y, 0] = null;
                                    dados1[y, 1] = null;
                                    dados1[y, 2] = null;
                                    Console.WriteLine("Apagou");
                                }
                                else if (del.Equals("N"))
                                {
                                    break;
                                }
                            }
                        }
                        break;

                    case "6": Console.Clear();
                        Console.WriteLine("Tchau");
                        H.Salvar();
                        break;
                    default: Console.Clear();
                        Console.WriteLine("opção invalida!");
                        break;
                } Console.ReadKey();
            } while (!resposta.Equals("6"));//para de fazer as repitição do case
        }
    }
}
