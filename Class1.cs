using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class GravaArquivo
    {

        Pacientes C = new Pacientes();

        public GravaArquivo()
        {
            StreamWriter Grava = new StreamWriter(@"C:/dados.txt", true);
            Grava.Close();
        }

        public Pacientes[] CarregaAgenda()
        {
            StreamReader leitura = new StreamReader(@"C:/dados.txt");
            Pacientes[] C = new Pacientes[100];
            string temp;
            for (int c = 0; c < 100; c++)
            {
                C[c] = new Pacientes();
                if ((temp = leitura.ReadLine()) != null)
                {
                    C[c].setnome(temp);
                    C[c].setidade(leitura.ReadLine());
                    C[c].setdatanacimento(leitura.ReadLine());
                    C[c].setsexo(leitura.ReadLine());
                    C[c].setendereco(leitura.ReadLine());
                    C[c].setrg(leitura.ReadLine());
                    C[c].setcpf(leitura.ReadLine());
                    C[c].settel(leitura.ReadLine());
                    C[c].setcel(leitura.ReadLine());
                    C[c].setgrau(leitura.ReadLine());
                    C[c].setdescricao(leitura.ReadLine());
                    
                }
                else
                {
                    C[c].setnome("");
                    C[c].setidade("");
                    C[c].setdatanacimento("");
                    C[c].setsexo("");
                    C[c].setendereco("");
                    C[c].setrg("");
                    C[c].setcpf("");
                    C[c].settel("");
                    C[c].setcel("");
                    C[c].setgrau("");
                    C[c].setdescricao("");
                }

            }
            leitura.Close();
            return C;
        }
        public void GravaAgenda(Pacientes[] C)
        {

            StreamWriter Grava = new StreamWriter(@"C:/dados.txt");
            for (int z = 0; z < 100; z++)
            {

                if (C[z].getnome() != null)
                {
                    Grava.WriteLine(C[z].getnome());
                    Grava.WriteLine(C[z].getidade());
                    Grava.WriteLine(C[z].getdatanacimento());
                    Grava.WriteLine(C[z].getsexo());
                    Grava.WriteLine(C[z].getendereco());
                    Grava.WriteLine(C[z].getrg());
                    Grava.WriteLine(C[z].gettel());
                    Grava.WriteLine(C[z].getcel());
                    Grava.WriteLine(C[z].getgrau());
                    Grava.WriteLine(C[z].getdescricao());

                }
            }
            Grava.Close();
        }
    }
}


    //    gravador.Close();
    //        return true;

    //    }
        


    //    }
    //}   
    //        gravador = new StreamWriter(caminho);
    //        gravador.WriteLine(C.getnome());
    //        gravador.WriteLine(C.getidade());
    //        gravador.WriteLine(C.getdatanacimento());
    //        gravador.WriteLine(C.getsexo());
    //        gravador.WriteLine(C.getendereco());
    //        gravador.WriteLine(C.getrg());
    //        gravador.WriteLine(C.getcpf());
    //        gravador.WriteLine(C.gettel());
    //        gravador.WriteLine(C.getcel());