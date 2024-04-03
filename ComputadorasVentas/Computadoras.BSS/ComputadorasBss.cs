using Computadoras.DAL;
using Computadoras.MODELOS;
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
        public DataTable ListarComputadoraBss()
        {
            return dal.ListarComputadoraDal();
        }
        public void InsertarComputadoraBss(Computador computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }
        public Computador ObtenerComputadoraIdBss(int idc)
        {
            return dal.ObtenerComputadoraIdDal(idc);
        }
        public void EditarComputadoraBss(Computador c)
        {
            dal.EditarComputadoraDal(c);
        }
        public void EliminarComputadoraBss(int idc)
        {
            dal.EliminarComputadoraDal(idc);
        }
    }
}
