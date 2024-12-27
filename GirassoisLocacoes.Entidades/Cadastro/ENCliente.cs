using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENCliente
    {
        #region "Atributos"
        private string _cpfcnpj;
        private string _nome;
        private DateTime _dataNascimento;
        private long _telefone;
        private long _cep;
        private string _endereco;
        private string _complemento;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private bool _ocorrencia;
        private string _observacao;
        private bool _cSit;
        private bool _cpfVerificado;
        #endregion

        #region "Propriedades"

        public string cpfcnpj
        {
            get { return _cpfcnpj; }
            set { _cpfcnpj = value; }
        }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime dataNascimento
        {
            get { return _dataNascimento; }
            set { _dataNascimento = value; }
        }

        public long telefone
        {
            get { return _telefone;  }
            set { _telefone = value; }
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

        public string complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
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
            set {  _observacao = value; }
        }

        public bool ocorrencia
        {
            get { return _ocorrencia; }
            set { _ocorrencia = value; }
        }

        public bool cSit
        {
            get { return _cSit; }
            set { _cSit = value; }
        }

        public bool cpfVerificado
        {
            get { return _cpfVerificado; }
            set { _cpfVerificado = value; }
        }
        #endregion
    }
}
