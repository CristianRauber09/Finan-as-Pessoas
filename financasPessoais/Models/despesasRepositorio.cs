using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace financasPessoais.Models
{
    public class despesasRepositorio
    {
       
        public static List<despesas> lstDespesas = new List<despesas>();
       
        public static void CreateList()
        {
            
        }

        public void Create(despesas pDespesas)
        {
            lstDespesas.Add(pDespesas);
        }
        public void Update(despesas pDespesas)
        {
            int aux = lstDespesas.FindIndex(x => x.id == pDespesas.id);
            lstDespesas[aux] = pDespesas;


        }
        public void Delete(int pId)
        {
            
            lstDespesas.RemoveAt(lstDespesas.FindIndex(x => x.id == pId));
        }
    }
}