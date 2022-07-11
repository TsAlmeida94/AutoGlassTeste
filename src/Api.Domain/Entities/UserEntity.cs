using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Codigo { get; set; }

        public string DescricaoDoProduto { get; set; }

        public string situacaoDoProduto { get; set; }

        public string DataDeFabricacao { get; set; }

        public string DataDeValidade { get; set; }

        public string CodigoDoFornecedor { get; set; }

        public string DescricaoDoFornecedor { get; set; }

        public string CNPJDoFornecedor { get; set; }
    }
}
