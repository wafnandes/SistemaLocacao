using GirassoisLocacoes.Db;
using GirassoisLocacoes.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Negocio
{
    public class NECliente
    {
        public NECliente() { }
        private static NECliente instance;
        public static NECliente Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NECliente();
                }
                return instance;
            }
        }

        #region "Gravar"
        public void Gravar(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            ADCliente objAD = new ADCliente();
            try
            {
                objAD.Gravar(pEntidadeDados);
            }
            catch (Exception ex)
            {  
                throw ex;
            }
        }
        #endregion

        #region "ObterClienteCPF"
        public DataSet ObterClienteCPF(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            ADCliente objAD = new ADCliente();
            DataSet ds = new DataSet();
            
            try
            {
                ds = objAD.ObterClienteCPF(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
        #endregion

        #region "Obter"
        public DataSet Obter(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            ADCliente objAD = new ADCliente();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.Obter(pEntidadeDados);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return objDS;
        }
        #endregion

        #region "Excluir"
        public void Excluir(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            ADCliente objAD = new ADCliente();
            try
            {
                objAD.Excluir(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
