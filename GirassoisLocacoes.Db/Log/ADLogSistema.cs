using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GirassoisLocacoes.Db;
using GirassoisLocacoes.Entidades;

namespace GirassoisLocacoes.Db
{
    public  class ADLogSistema
    {
        #region "Construtor"
        public ADLogSistema() { }
        #endregion

        #region "Gravar"
        public void Gravar(ENLogSistema entidade)
        {
            ENLogSistema pEntidadeDados = (ENLogSistema)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_INS_LOG_SISTEMA", ref objCmd);

                objCmd.Parameters["@Comando"].Value = pEntidadeDados.comando;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_INS_LOG_SISTEMA";

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

        #region "ObterInfosDatabase"
        public DataSet ObterInfosDatabase()
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_DADOS_BD";

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
    }
}
