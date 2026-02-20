using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DAO
{
    public class EntidadeBase<T>
    {
        //entidade base para RASTREABILIDADE, ID centralizado como GUID para evitar sequencialidade e garantir uma camada de proteção ao identificador unico.
        //usando Tipo T.
        public T Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public T QuemCadastrou { get; set; }
        public T AtualizouPorUltimo { get; set; }


        public void AlterarQuemAtualizou(T atualizou) => AtualizouPorUltimo = atualizou;
        public void AlterarDataAtualizacao(DateTime dataatualizou) => DataAtualizacao = dataatualizou;
    }
}
