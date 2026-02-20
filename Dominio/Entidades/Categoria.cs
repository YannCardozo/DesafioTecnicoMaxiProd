using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO
{
    public class Categoria : EntidadeBase<Guid>
    {
        public Categoria()
        { 
        }
        public Categoria(string descricao, string finalidade)
        {
            Descricao = descricao;
            Finalidade = finalidade;
        }

        public string Descricao  { get; set; }
        public string Finalidade { get; set; }


        public void AlterarDescricao(string descricao) => Descricao = descricao;
        public void AlterarFinalidade(string finalidade) => Finalidade = finalidade;
    }
}
