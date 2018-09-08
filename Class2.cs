using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Hospital
    {
        Pacientes[] Pacientes = new Pacientes[100];
        GravaArquivo G = new GravaArquivo();
        
        int posicao = 0;

        public bool Inicia()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Pacientes = G.CarregaAgenda();
            }
            return true;
        }

        public Pacientes Busca(string b)
        {
            Pacientes C1 = new Pacientes();
            for (int i = 0; i < 100; i++)
            {
                if (b.Equals(this.Pacientes[i].getnome()))
                {
                    C1 = Pacientes[i];
                }
            }
            return C1;
        }

        public bool Salvar()
        {
            G.GravaAgenda(this.Pacientes);

            return true;
        }

        public int buscaPosicao() // NOVO <<<<<<<<<<<<<<<<<<<
        {
            int cont = 0;
            for (int p = 0; p < 100; p++)
            {
                if (Pacientes[p].getnome().Equals(""))
                {
                    Salvar();
                    return cont;
                }
                else
                {
                    cont++;
                }

            }
            return cont;
        }

        public void adicionaContato(Pacientes C)  // NOVO <<<<<<<<<<<<<<<
        {
            posicao = buscaPosicao();
            Pacientes[posicao].setnome(C.getnome());
            Pacientes[posicao].setidade(C.getidade());
            Pacientes[posicao].setdatanacimento(C.getdatanacimento());
            Pacientes[posicao].setsexo(C.getsexo());
            Pacientes[posicao].setendereco(C.getendereco());
            Pacientes[posicao].setrg(C.getrg());
            Pacientes[posicao].setcpf(C.getcpf());
            Pacientes[posicao].settel(C.gettel());
            Pacientes[posicao].setcel(C.getcel());
            Pacientes[posicao].setgrau(C.getgrau());
            Pacientes[posicao].setdescricao(C.getdescricao());
        }
            public Pacientes Geral(string G)
            {
          
               
            for (int i = 0; i < 100; i++)
            {
                if (G.Equals(this.Pacientes[i].getgrau()))
                {



                    Pacientes = Pacientes;



                }
            }
                return Pacientes[99];
        }
    }
}