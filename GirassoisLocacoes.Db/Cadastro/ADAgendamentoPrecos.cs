using GirassoisLocacoes.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Db
{
    public class ADAgendamentoPrecos
    {
        public ADAgendamentoPrecos() { }

        #region "Gravar"
        public void Gravar(ENAgendamentoPrecos entidade)
        {
            ENAgendamentoPrecos pEntidadeDados = (ENAgendamentoPrecos)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBESTOQUEPRECOAGENDADO", ref objCmd);

                objCmd.Parameters["@idPreco"].Value = pEntidadeDados.idPreco;
                objCmd.Parameters["@cdItem"].Value = pEntidadeDados.cdItem;
                objCmd.Parameters["@vlrUnit"].Value = pEntidadeDados.vlrUnit;
                objCmd.Parameters["@dtInicio"].Value = pEntidadeDados.dtInicio;
                objCmd.Parameters["@dtFim"].Value = pEntidadeDados.dtFim;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBESTOQUEPRECOAGENDADO";

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

        #region "Obter"
        public DataSet Obter()
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBESTOQUEPRECOAGENDADO";

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
