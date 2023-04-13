using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Produto
    {
        public int ID { get; set; }
        public string Descricao { get; set;}
        public string Preco { get; set;}
        public string TipoUn { get; set;}
        public int Quantidade { get; set;}
    }
}
