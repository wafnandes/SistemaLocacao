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
    public class NEParametros
    {
        public NEParametros() { }

        private static NEParametros instance;
        public static NEParametros Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEParametros();
                }
                return instance;
            }
        }

        #region "Obter"
        public DataSet Obter()
        {
            ADParametros objAD = new ADParametros();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.Obter();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objDS;
        }
        #endregion

        #region "ObterCodParametro"
        public DataSet ObterCodParametro(string codParametro)
        {
            ADParametros objAD = new ADParametros();
            DataSet objDS = new DataSet();
            string codValorParametro = (string)codParametro;

            try
            {
                objDS = objAD.ObterCodParametro(codValorParametro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objDS;
        }
        #endregion

        #region "Gravar"
        public void Gravar(ENParametros entidade)
        {
            ENParametros pEntidadeDados = (ENParametros)entidade;
            ADParametros objAD = new ADParametros();
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
    }
}
