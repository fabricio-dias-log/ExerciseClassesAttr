using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClassesAttr
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa getOlder(Pessoa pessoa1, Pessoa pessoa2)
        {
            if (pessoa1.idade > pessoa2.idade)
            {
                return pessoa1;
            } else
            {
                return pessoa2;
            }
        }
    }
}
