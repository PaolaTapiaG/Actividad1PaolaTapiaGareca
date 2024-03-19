using Computadoras.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras.BSS
{
    public class ComputadorasBss
    {
       ComputadoraDAL dal = new ComputadoraDAL();

        public DataTable ListarComputadorasBss()
        {
            return dal.ListarComputadoraDAL();
        }
    }
}
