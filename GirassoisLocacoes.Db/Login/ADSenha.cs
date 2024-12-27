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
    public class ADSenha
    {
        #region "Construtor"
        public ADSenha() { }
        #endregion

        #region "ObterInfosDatabase"
        public DataSet Obter(ENSenha entidade)
        {
            ENSenha pEntidadeDados = (ENSenha)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_VALIDAUSUARIO", ref objCmd);

                objCmd.Parameters["@idUsuario"].Value = pEntidadeDados.idUsuario;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_VALIDAUSUARIO";

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
