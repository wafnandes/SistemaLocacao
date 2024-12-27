using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENEspaco
    {
        #region "Atributos"
        private string _nmEspaco;
        private string _nmProprietario;
        private long _telProprietario;
        private long _cep;
        private string _endEspaco;
        private string _compl;
        private string _bairro;
        private string _cidade;
        private string _estado;
        #endregion

        #region "Propriedades"
        public string nmEspaco 
        {  
            get { return _nmEspaco; } 
            set { _nmEspaco = value; } 
        }

        public string nmProprietario
        {
            get { return _nmProprietario; }
            set { _nmProprietario = value; }
        }

        public long telProprietario
        {
            get { return _telProprietario; }
            set { _telProprietario = value; }
        }

        public long cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        public string endEspaco
        {
            get { return _endEspaco; }
            set { _endEspaco = value; }
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
        #endregion
    }
}
