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
    public class ADCliente
    {
        //Construtor
        public ADCliente() { }

        #region "Gravar"
        public void Gravar(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBCLIENTE", ref objCmd);

                objCmd.Parameters["@CPFCLI"].Value = pEntidadeDados.cpfcnpj;
                objCmd.Parameters["@NMCLI"].Value = pEntidadeDados.nome;
                objCmd.Parameters["@DTNASC"].Value = pEntidadeDados.dataNascimento;
                objCmd.Parameters["@TELCLI"].Value = pEntidadeDados.telefone;
                objCmd.Parameters["@CEPCLI"].Value = pEntidadeDados.cep;
                objCmd.Parameters["@ENDCLI"].Value = pEntidadeDados.endereco;
                objCmd.Parameters["@COMPL"].Value = pEntidadeDados.complemento;
                objCmd.Parameters["@BAIRRO"].Value = pEntidadeDados.bairro;
                objCmd.Parameters["@CIDADE"].Value = pEntidadeDados.cidade;
                objCmd.Parameters["@ESTADO"].Value = pEntidadeDados.estado;
                objCmd.Parameters["@OCORRENCIA"].Value = pEntidadeDados.ocorrencia;
                objCmd.Parameters["@OBSERVACAO"].Value = pEntidadeDados.observacao;
                objCmd.Parameters["@cSIT"].Value = pEntidadeDados.cSit;
                objCmd.Parameters["@CPFVERIFICADO"].Value = pEntidadeDados.cpfVerificado;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBCLIENTE";

                SqlHelper.Instance.executarConsulta(objCmd);
            }
            catch(SqlException ex)
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

        #region "ObterClienteCPF"
        public DataSet ObterClienteCPF(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente ) entidade;  
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_TBCLIENTE_CPF", ref objCmd);

                objCmd.Parameters["@CPFCLI"].Value = pEntidadeDados.cpfcnpj;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBCLIENTE_CPF";

                objDs = SqlHelper.Instance.executarConsulta(objCmd);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
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
        public DataSet Obter(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            SqlCommand objCmd = new SqlCommand(); 
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_TBCLIENTE", ref objCmd);

                objCmd.Parameters["@cSit"].Value = pEntidadeDados.cSit;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_TBCLIENTE";

                objDs = SqlHelper.Instance.executarConsulta(objCmd);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch(Exception ex)
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

        #region "Excluir"
        public void Excluir(ENCliente entidade)
        {
            ENCliente pEntidadeDados = (ENCliente)entidade;
            SqlCommand objCmd = new SqlCommand();

            try
            {
                SqlHelper.Instance.criarParametros("PR_DEL_TBCLIENTE", ref objCmd);

                objCmd.Parameters["@CPFCLI"].Value = pEntidadeDados.cpfcnpj;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_DEL_TBCLIENTE";

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
