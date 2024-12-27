using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENReserva
    {
        #region "Atributos"
        private int _cdReserva;
        private DateTime _dtReserva;
        private DateTime _dtEntrega;
        private DateTime _DtDevolucao;
        private string _cpfcnpj;
        private int _tpEndereco;
        private string _nmLocalEntrega;
        private long _cep;
        private string _endereco;
        private string _compl;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _observacao;
        private decimal _vlrReserva;
        private decimal _vlrDescontoItens;
        private decimal _vlrDesconto;
        private decimal _vlrTotal;
        private string _formaPagamento;
        private string _nmItem;
        private bool _orcamento;
        private bool _idFinalizado;
        private string _nmCliente;
        private string _telCliente;
        private string _dtNasc;
        private string _strDtHrReserva;
        private string _strDtHrEntrega;
        private string _strDtHrDevolucao;
        private string _strDtReserva;
        private string _strDtEntrega;
        private string _strDtDevolucao;
        private string _strHrReserva;
        private string _strHrEntrega;
        private string _strHrDevolucao;
        private string _strTpEndereco;
        private bool _ocorrencia;
        private string _descOcorrencia;
        #endregion

        #region "Propriedades"
        public int cdReserva
        {
            get { return _cdReserva; }
            set { _cdReserva = value; }
        }

        public DateTime dtReserva 
        { 
            get { return _dtReserva; }
            set { _dtReserva = value; }
        }

        public DateTime dtEntrega
        {
            get { return _dtEntrega; }
            set { _dtEntrega = value; }
        }

        public DateTime dtDevolucao
        {
            get { return _DtDevolucao; }
            set { _DtDevolucao = value; }
        }

        public string cpfcnpj
        {
            get { return _cpfcnpj; }
            set { _cpfcnpj = value; }
        }

        public int tpEndereco
        {
            get { return _tpEndereco; }
            set { _tpEndereco = value; }
        }

        public string nmLocalEntrega
        {
            get { return _nmLocalEntrega; }
            set { _nmLocalEntrega = value; }
        }

        public long cep
        {
            get { return _cep; }
            set { _cep = value; }   
        }

        public string endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public string compl
        {
            get { return _compl; }
            set { _compl = value; }
        }

        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }

        public decimal vlrReserva
        {
            get { return _vlrReserva; }
            set { _vlrReserva = value; }
        }

        public decimal vlrDescontoItens
        {
            get { return _vlrDescontoItens; }
            set { _vlrDescontoItens = value; }
        }

        public decimal vlrDesconto
        {
            get { return _vlrDesconto; }
            set { _vlrDesconto = value; }
        }
        
        public decimal vlrTotal
        {
            get { return _vlrTotal; }
            set { _vlrTotal = value; }
        }

        public string formaPagamento
        {
            get { return _formaPagamento; }
            set { _formaPagamento = value; }
        }

        public string nmItem
        {
            get { return _nmItem; }
            set { _nmItem = value; }
        }

        public bool orcamento
        {
            get { return _orcamento; } 
            set { _orcamento = value; }
        }

        public bool idFinalizado
        {
            get { return _idFinalizado; }
            set { _idFinalizado = value; }
        }

        public string nmCliente
        {
            get { return _nmCliente; }
            set { _nmCliente = value; }
        }

        public string telCliente
        {
            get { return _telCliente; }
            set { _telCliente = value; }
        }

        public string dtNasc
        {
            get { return _dtNasc; }
            set { _dtNasc = value; }
        }

        public string strDtHrReserva
        {
            get { return _strDtHrReserva; }
            set { _strDtHrReserva = value; }
        }

        public string strDtHrEntrega
        {
            get { return _strDtHrEntrega; }
            set { _strDtHrEntrega = value; }
        }

        public string strDtHrDevolucao
        {
            get { return _strDtHrDevolucao; }
            set { _strDtHrDevolucao = value; }
        }

        public string strDtReserva
        {
            get { return _strDtReserva; }
            set { _strDtReserva = value; }
        }

        public string strDtEntrega
        {
            get { return _strDtEntrega; }
            set { _strDtEntrega = value; }
        }

        public string strDtDevolucao
        {
            get { return _strDtDevolucao; }
            set { _strDtDevolucao = value; }
        }

        public string strHrReserva
        {
            get { return _strHrReserva; }
            set { _strHrReserva = value; }
        }

        public string strHrEntrega
        {
            get { return _strHrEntrega; }
            set { _strHrEntrega = value; }
        }

        public string strHrDevolucao
        {
            get { return _strHrDevolucao; }
            set { _strHrDevolucao = value; }
        }

        public string strTpEndereco
        {
            get { return _strTpEndereco; }
            set { _strTpEndereco = value; }
        }

        public bool ocorrencia
        {
            get { return _ocorrencia; }
            set { _ocorrencia = value; }
        }

        public string descOcorrencia
        {
            get { return _descOcorrencia; }
            set { _descOcorrencia = value; }
        }
        #endregion
    }
}
