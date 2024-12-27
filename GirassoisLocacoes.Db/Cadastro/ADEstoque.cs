using GirassoisLocacoes.Db;
using GirassoisLocacoes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Db
{
    public class ADEstoque
    {
        //Construtor
        public ADEstoque() { }

        #region "ObterProxId"
        public DataSet ObterProxId()
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_PROX_ID_ESTOQUE";

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
        public DataSet Obter(bool OrdenacaoNome)
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_TBESTOQUE", ref objCmd);

                objCmd.Parameters["@Ordenacao"].Value = OrdenacaoNome;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBESTOQUE";

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
        public void Gravar(ENEstoque entidade)
        {
            ENEstoque pEntidadeDados = (ENEstoque)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBESTOQUE", ref objCmd);

                objCmd.Parameters["@CDITEM"].Value = pEntidadeDados.cdItem;
                objCmd.Parameters["@NMITEM"].Value = pEntidadeDados.nomeItem;
                objCmd.Parameters["@QTDESTOQUE"].Value = pEntidadeDados.qtdeEstoque;
                objCmd.Parameters["@VALORUNIT"].Value = pEntidadeDados.valorUnit;
                objCmd.Parameters["@VALORREPOSICAO"].Value = pEntidadeDados.valorReposicao;
                objCmd.Parameters["@DESCITEM"].Value = pEntidadeDados.descItem;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBESTOQUE";

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

        #region "Excluir"
        public void Excluir(ENEstoque entidade)
        {
            ENEstoque pEntidadeDados = (ENEstoque)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_DEL_TBESTOQUE", ref objCmd);

                objCmd.Parameters["@CDITEM"].Value = pEntidadeDados.cdItem;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_DEL_TBESTOQUE";

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

        #region "ObterItem"
        public DataSet ObterItem(ENEstoque entidade)
        {
            ENEstoque pEntidadeDados = (ENEstoque)entidade; 
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_ESTOQUE_ITEM", ref objCmd);

                objCmd.Parameters["@cdItem"].Value = pEntidadeDados.cdItem;
                objCmd.Parameters["@qtdeItem"].Value = pEntidadeDados.qtdeSolicitada;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_ESTOQUE_ITEM";

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
