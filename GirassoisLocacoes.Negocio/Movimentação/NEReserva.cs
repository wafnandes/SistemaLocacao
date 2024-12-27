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
    public class NEReserva
    {
        public NEReserva() { }
        private static NEReserva instance;
        public static NEReserva Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEReserva();
                }
                return instance;
            }
        }

        #region "Gravar"
        public DataSet Gravar(ENReserva entidade)
        {
            ENReserva pEntidade = (ENReserva)entidade;
            ADReserva objAD = new ADReserva();
            DataSet objDs = new DataSet();

            try
            {
                objDs = objAD.Gravar(pEntidade);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return objDs;
        }
        #endregion

        #region "ObterEstoqueDisponivel"
        public DataSet ObterEstoqueDisponivel(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            ADReserva objAD = new ADReserva();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.ObterEstoqueDisponivel(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objDS;
        }
        #endregion

        #region "ObterReservasAtivas"
        public DataSet ObterReservasAtivas(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            ADReserva objAD = new ADReserva();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.ObterReservasAtivas(pEntidadeDados);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return objDS;
        }
        #endregion

        #region "FinalizarReserva"
        public void FinalizarReserva(ENReserva entidade)
        {
            ENReserva pEntidade = (ENReserva)entidade;
            ADReserva objAd = new ADReserva();   

            try
            {
                objAd.FinalizarReserva(pEntidade);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ObterDetalhesReserva"
        public ENReserva ObterDetalhesReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            ADReserva objAD = new ADReserva();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.ObterDetalhesReserva(pEntidadeDados);

                if (objDS.Tables[0].Rows.Count > 0)
                {
                    pEntidadeDados.cdReserva = Convert.ToInt32(objDS.Tables[0].Rows[0]["cdReserva"]);
                    pEntidadeDados.strDtHrReserva = objDS.Tables[0].Rows[0]["dtHrReserva"].ToString();
                    pEntidadeDados.strDtHrEntrega = objDS.Tables[0].Rows[0]["dtHrEntrega"].ToString();
                    pEntidadeDados.strDtHrDevolucao = objDS.Tables[0].Rows[0]["dtHrDevolucao"].ToString();
                    pEntidadeDados.strDtReserva = objDS.Tables[0].Rows[0]["dtReserva"].ToString();
                    pEntidadeDados.strDtEntrega = objDS.Tables[0].Rows[0]["dtEntrega"].ToString();
                    pEntidadeDados.strDtDevolucao = objDS.Tables[0].Rows[0]["dtDevolucao"].ToString();
                    pEntidadeDados.strHrReserva = objDS.Tables[0].Rows[0]["hrReserva"].ToString();
                    pEntidadeDados.strHrEntrega = objDS.Tables[0].Rows[0]["hrEntrega"].ToString();
                    pEntidadeDados.strHrDevolucao = objDS.Tables[0].Rows[0]["hrDevolucao"].ToString();
                    pEntidadeDados.cpfcnpj = objDS.Tables[0].Rows[0]["cpfCli"].ToString();
                    pEntidadeDados.nmCliente = objDS.Tables[0].Rows[0]["nmCli"].ToString();
                    pEntidadeDados.telCliente = objDS.Tables[0].Rows[0]["telCli"].ToString();
                    pEntidadeDados.dtNasc = objDS.Tables[0].Rows[0]["dtNasc"].ToString();
                    pEntidadeDados.tpEndereco = Convert.ToInt32(objDS.Tables[0].Rows[0]["tpEndereco"]);
                    pEntidadeDados.strTpEndereco = objDS.Tables[0].Rows[0]["tpEndereco"].ToString();
                    pEntidadeDados.nmLocalEntrega = objDS.Tables[0].Rows[0]["nmLocalEntrega"].ToString();
                    pEntidadeDados.cep = Convert.ToInt64(objDS.Tables[0].Rows[0]["cep"]);
                    pEntidadeDados.endereco = objDS.Tables[0].Rows[0]["endereco"].ToString();
                    pEntidadeDados.compl = objDS.Tables[0].Rows[0]["compl"].ToString();
                    pEntidadeDados.bairro = objDS.Tables[0].Rows[0]["bairro"].ToString();
                    pEntidadeDados.cidade = objDS.Tables[0].Rows[0]["cidade"].ToString();
                    pEntidadeDados.estado = objDS.Tables[0].Rows[0]["estado"].ToString();
                    pEntidadeDados.observacao = objDS.Tables[0].Rows[0]["observacao"].ToString();
                    pEntidadeDados.vlrReserva = Convert.ToDecimal(objDS.Tables[0].Rows[0]["vlrReserva"].ToString());
                    pEntidadeDados.vlrDesconto = Convert.ToDecimal(objDS.Tables[0].Rows[0]["vlrDesconto"].ToString());
                    pEntidadeDados.vlrDescontoItens = Convert.ToDecimal(objDS.Tables[0].Rows[0]["vlrDescontoItens"].ToString());
                    pEntidadeDados.vlrTotal = Convert.ToDecimal(objDS.Tables[0].Rows[0]["vlrTotal"].ToString());
                    pEntidadeDados.ocorrencia = Convert.ToBoolean(objDS.Tables[0].Rows[0]["ocorrencia"].ToString());
                    pEntidadeDados.descOcorrencia = objDS.Tables[0].Rows[0]["descOcorrencia"].ToString();
                }       
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pEntidadeDados;
        }
        #endregion

        #region "ObterDetalhesReserva"
        public List<ENReservaItens> ObterItensReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            List<ENReservaItens> pEntidadeItens = new List<ENReservaItens>();
            ADReserva objAD = new ADReserva();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.ObterItensReserva(pEntidadeDados);

                foreach (DataRow dr in objDS.Tables[0].Rows)
                {
                    ENReservaItens item = new ENReservaItens();

                    item.cdItem = Convert.ToInt32(dr["cdItem"]);
                    item.nmItem = dr["nmItem"].ToString();
                    item.vlrUnit = Convert.ToDecimal(dr["vlrUnit"]);
                    item.vlrReposicao = Convert.ToDecimal(dr["vlrReposicao"]);
                    item.qtdeItem = Convert.ToInt32(dr["qtdeItem"]);
                    item.vlrDesconto = Convert.ToDecimal(dr["vlrDesconto"]);
                    item.total = Convert.ToDecimal(dr["vlrTotal"]);

                    pEntidadeItens.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return pEntidadeItens;
        }
        #endregion

        #region "InserirOcorrencia"
        public void InserirOcorrencia(ENReserva entidade)
        {
            ENReserva pEntidade = (ENReserva)entidade;
            ADReserva objAd = new ADReserva();

            try
            {
                objAd.InserirOcorrencia(pEntidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Excluir"
        public void Excluir(ENReserva entidade)
        {
            ENReserva pEntidade = (ENReserva)entidade;
            ADReserva objAd = new ADReserva();

            try
            {
                objAd.Excluir(pEntidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "AtualizarValoresReserva"
        public void AtualizarValoresReserva(ENReserva entidade)
        {
            ENReserva pEntidade = (ENReserva)entidade;
            ADReserva objAd = new ADReserva();

            try
            {
                objAd.AtualizarValoresReserva(pEntidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
