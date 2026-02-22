using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO
{
    public class Pessoa : EntidadeBase<Guid>
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }

        //relacionamento  1 - n
        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();

        public void AlterarNome(string nome) => Nome = nome;
        public void AlterarIdade(int idade) => Idade = idade;

    }
}
