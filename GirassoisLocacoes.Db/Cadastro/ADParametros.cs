using GirassoisLocacoes.Db;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GirassoisLocacoes.Entidades;

namespace GirassoisLocacoes.Db
{
    public class ADParametros
    {
        public ADParametros() { }

        #region "Obter"
        public DataSet Obter()
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBPARAMETROS";

                objDs = SqlHelper.Instance.executarConsulta(objCmd);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCmd = null;
            }
            return objDs;
        }
        #endregion

        #region "Obter"
        public DataSet ObterCodParametro(string codParametro)
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();
            string codValorParametro = (string)codParametro;

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_TBPARAMETROS_VALOR", ref objCmd);

                objCmd.Parameters["@codParametro"].Value = codParametro;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBPARAMETROS_VALOR";

                objDs = SqlHelper.Instance.executarConsulta(objCmd);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCmd = null;
            }
            return objDs;
        }
        #endregion

        #region "Gravar"
        public void Gravar(ENParametros entidade)
        {
            ENParametros pEntidadeDados = (ENParametros)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBPARAMETROS", ref objCmd);

                objCmd.Parameters["@codParametro"].Value = pEntidadeDados.codParametro;
                objCmd.Parameters["@codValorParametro"].Value = pEntidadeDados.codValorParametro;
                objCmd.Parameters["@descParametro"].Value = pEntidadeDados.descParametro;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBPARAMETROS";

                SqlHelper.Instance.executarConsulta(objCmd);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCmd = null;
            }
        }
        #endregion
    }
}
