using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Pacientes
    {
        public string nome, sexo,endereco, grau, descricao;
        public string rg, datanacimento, cpf, tel, cel, idade;
		
        public string getnome()
        {
            return this.nome;
        }
        public void setnome(string N)
        {
            this.nome = N;

        }
        public string getsexo()
        {
            return this.sexo;
        }
        public void setsexo(string S)
        {
            this.sexo = S;
        }
        public string getrg()
        {
            return this.rg;
        }
        public void setrg(string R)
        {
            this.rg = R;
        }
        public string getdatanacimento()
        {
            return this.datanacimento;
        }
        public void setdatanacimento(string D)
        {
            this.datanacimento = D;
        }
        public string gettel()
        {
            return this.tel;
        }
        public void settel(string T)
        {
            this.tel = T;
        }

        public string getgrau()
        {
            return this.grau;
        }

        public void setgrau(string G)
        {
            this.grau = G;
        }
        public string getdescricao()
        {
            return this.descricao;
        }
        public void setdescricao(string DS)
        {
            this.descricao = DS;
        }
        public string getidade()
        {
            return this.idade;
        }
        public void setidade(string I)
        {
            this.idade = I;
        }
        public string getendereco()
        {
            return this.endereco;

        }
        public void setendereco(string E)
        {
            this.endereco = E;
        }
        public string getcpf()
        {
            return this.cpf;
        }
        public void setcpf(string CP)
        {
            this.cpf = CP;
        }
        public string getcel()
        {
            return this.idade;
        }
        public void setcel(string CEL)
        {
            this.cel = CEL;
        }
    }
}
