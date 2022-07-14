using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pablo_orientacao_a_objeto
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        

        public Funcionario(string nome, string sobrenome) 
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            
        }

        public override string ToString()
        {
            return Nome
                 + ", "
                 + Sobrenome
                 + ", ";
        }
    }
}