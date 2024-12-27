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
    public class ADReservaItens
    {
        public ADReservaItens() { }

        #region "Gravar"
        public void Gravar(List<ENReservaItens> entidade)
        {
            List<ENReservaItens> pEntidadeDados = (List<ENReservaItens>)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBRESERVAITENS", ref objCmd);

                foreach (ENReservaItens item in pEntidadeDados)
                {
                    SqlCommand objCmd2 = new SqlCommand();

                    objCmd.Parameters["@cdReserva"].Value = item.idReserva;
                    objCmd.Parameters["@cdItem"].Value = item.cdItem;
                    objCmd.Parameters["@vlrUnit"].Value = item.vlrUnit;
                    objCmd.Parameters["@vlrReposicao"].Value = item.vlrReposicao;
                    objCmd.Parameters["@qtdeItem"].Value = item.qtdeItem;
                    objCmd.Parameters["@vlrDesconto"].Value = item.vlrDesconto;
                    objCmd.Parameters["@vlrTotal"].Value = item.total;

                    objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                    objCmd.CommandText = "PR_MLT_TBRESERVAITENS";

                    SqlHelper.Instance.executarConsulta(objCmd);
                }
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

        #region "GravarItemDanificado"
        public void GravarItem(ENReservaItens entidade)
        {
            ENReservaItens pEntidadeDados = (ENReservaItens)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBRESERVAITENS", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.idReserva;
                objCmd.Parameters["@cdItem"].Value = pEntidadeDados.cdItem;
                objCmd.Parameters["@vlrUnit"].Value = pEntidadeDados.vlrUnit;
                objCmd.Parameters["@vlrReposicao"].Value = pEntidadeDados.vlrReposicao;
                objCmd.Parameters["@qtdeItem"].Value = pEntidadeDados.qtdeItem;
                objCmd.Parameters["@vlrDesconto"].Value = pEntidadeDados.vlrDesconto;
                objCmd.Parameters["@vlrTotal"].Value = pEntidadeDados.total;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBRESERVAITENS";

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

        #region "ObterProxId"
        public DataSet ObterProxId()
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_PROX_ID_RESERVA";

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

        #region "LimparItensReserva"
        public void LimparItensReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_DEL_TBRESERVAITENS", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_DEL_TBRESERVAITENS";

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
