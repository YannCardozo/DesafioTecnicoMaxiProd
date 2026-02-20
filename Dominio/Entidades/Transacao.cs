using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO
{
    public class Transacao : EntidadeBase<Guid>
    {
        public Transacao() 
        {
        
        }
        public Transacao(string descricao, decimal valor, string tipo)
        {
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
        }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }

        public void AlterarDescricao(string descricao) => Descricao = descricao;
        public void AlterarValor(decimal valor) => Valor = valor;
        public void AlterarTipo(string tipo) => Tipo = tipo;
    }
}
