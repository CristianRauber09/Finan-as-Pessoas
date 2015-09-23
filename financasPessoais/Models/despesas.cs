using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace financasPessoais.Models
{
    public class despesas
    {
        public int id { get; set; }
        public string local { get; set; }
        public string data { get; set; }
        public double valor { get; set; }
        public string classificacao { get; set; }
        public despesas()
        {

        }
        public despesas(string pLocal, string pData, double pValor, string pClassificacao)
        {
            local = pLocal;
            valor = pValor;
            data = pData;
            classificacao = pClassificacao;
        }
    }
}