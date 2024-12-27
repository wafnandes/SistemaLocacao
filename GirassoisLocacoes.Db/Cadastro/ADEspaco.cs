using GirassoisLocacoes.Db;
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
    public class ADEspaco
    {
        public ADEspaco() { }

        #region "Obter"
        public DataSet Obter()
        {
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBESPACO";

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
        public void Gravar(ENEspaco entidade)
        {
            ENEspaco pEntidadeDados = (ENEspaco)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBESPACO", ref objCmd);

                objCmd.Parameters["@nmEspaco"].Value = pEntidadeDados.nmEspaco;
                objCmd.Parameters["@nmProprietario"].Value = pEntidadeDados.nmEspaco;
                objCmd.Parameters["@telProprietario"].Value = pEntidadeDados.telProprietario;
                objCmd.Parameters["@cep"].Value = pEntidadeDados.cep;
                objCmd.Parameters["@endEspaco"].Value = pEntidadeDados.endEspaco;
                objCmd.Parameters["@compl"].Value = pEntidadeDados.compl;
                objCmd.Parameters["@bairro"].Value = pEntidadeDados.bairro;
                objCmd.Parameters["@cidade"].Value = pEntidadeDados.cidade;
                objCmd.Parameters["@estado"].Value = pEntidadeDados.estado;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBESPACO";

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
        public void Excluir(ENEspaco entidade)
        {
            ENEspaco pEntidadeDados = (ENEspaco)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_DEL_TBESPACO", ref objCmd);

                objCmd.Parameters["@nmEspaco"].Value = pEntidadeDados.nmEspaco;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_DEL_TBESPACO";

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
