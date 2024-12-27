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
    public class ADReserva
    {
        public ADReserva() { }

        #region "Gravar"
        public DataSet Gravar(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_TBRESERVA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;
                objCmd.Parameters["@DtEntrega"].Value = pEntidadeDados.dtEntrega;
                objCmd.Parameters["@DtDevolucao"].Value = pEntidadeDados.dtDevolucao;
                objCmd.Parameters["@CpfCli"].Value = pEntidadeDados.cpfcnpj;
                objCmd.Parameters["@TpEndereco"].Value = pEntidadeDados.tpEndereco;
                objCmd.Parameters["@nmLocalEntrega"].Value = pEntidadeDados.nmLocalEntrega;
                objCmd.Parameters["@Cep"].Value = pEntidadeDados.cep;
                objCmd.Parameters["@Endereco"].Value = pEntidadeDados.endereco;
                objCmd.Parameters["@Complemento"].Value = pEntidadeDados.compl;
                objCmd.Parameters["@Bairro"].Value = pEntidadeDados.bairro;
                objCmd.Parameters["@Cidade"].Value = pEntidadeDados.cidade;
                objCmd.Parameters["@Estado"].Value = pEntidadeDados.estado;
                objCmd.Parameters["@Observacao"].Value = pEntidadeDados.observacao;
                objCmd.Parameters["@Orcamento"].Value = pEntidadeDados.orcamento;
                objCmd.Parameters["@vlrReserva"].Value = pEntidadeDados.vlrReserva;
                objCmd.Parameters["@vlrDescontoItens"].Value = pEntidadeDados.vlrDescontoItens;
                objCmd.Parameters["@vlrDesconto"].Value = pEntidadeDados.vlrDesconto;
                objCmd.Parameters["@vlrTotal"].Value = pEntidadeDados.vlrTotal;
                objCmd.Parameters["@idFinalizado"].Value = pEntidadeDados.idFinalizado;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_TBRESERVA";

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

        #region "ObterEstoqueDisponivel"
        public DataSet ObterEstoqueDisponivel(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_ESTOQUE_DISPONIVEL", ref objCmd);

                objCmd.Parameters["@DtReserva"].Value = pEntidadeDados.dtEntrega;
                objCmd.Parameters["@DtDevolucao"].Value = pEntidadeDados.dtDevolucao;
                objCmd.Parameters["@nmItem"].Value = pEntidadeDados.nmItem;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_ESTOQUE_DISPONIVEL";

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

        #region "ObterReservasAtivas"
        public DataSet ObterReservasAtivas(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_RESERVAS_ATIVAS", ref objCmd);

                objCmd.Parameters["@nmCli"].Value = pEntidadeDados.nmCliente;
                objCmd.Parameters["@idFinalizado"].Value = pEntidadeDados.idFinalizado;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_RESERVAS_ATIVAS";

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

        #region "FinalizarReserva"
        public void FinalizarReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_MLT_FINALIZAR_RESERVA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;
                objCmd.Parameters["@idFinalizado"].Value = pEntidadeDados.idFinalizado;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_MLT_FINALIZAR_RESERVA";

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
        }
        #endregion

        #region "ObterDetalhesReserva"
        public DataSet ObterDetalhesReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_DETALHESRESERVA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_DETALHESRESERVA";

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

        #region "ObterItensReserva"
        public DataSet ObterItensReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_SEL_ITENSRESERVA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;
                objCmd.Parameters["@lista"].Value = pEntidadeDados.idFinalizado;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_SEL_ITENSRESERVA";

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

        #region "FinalizarReserva"
        public void InserirOcorrencia(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_UPD_TBRESERVA_OCORRENCIA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;
                objCmd.Parameters["@descOcorrencia"].Value = pEntidadeDados.descOcorrencia;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_UPD_TBRESERVA_OCORRENCIA";

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
        }
        #endregion

        #region "Excluir"
        public void Excluir(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_DEL_TBRESERVA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_DEL_TBRESERVA";

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
        }
        #endregion

        #region "AtualizarValoresReserva"
        public void AtualizarValoresReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            SqlCommand objCmd = new SqlCommand();
            DataSet objDs = new DataSet();

            try
            {
                SqlHelper.Instance.criarParametros("PR_UPD_ATUALIZAVALORESRESERVA", ref objCmd);

                objCmd.Parameters["@cdReserva"].Value = pEntidadeDados.cdReserva;

                objCmd.CommandType = System.Data.CommandType.StoredProcedure;
                objCmd.CommandText = "PR_UPD_ATUALIZAVALORESRESERVA";

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
        }
        #endregion
    }
}
