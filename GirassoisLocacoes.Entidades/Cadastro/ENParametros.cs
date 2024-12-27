using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENParametros
    {
        #region "Atributos"
        private string _codParametro;
        private string _codValorParametro;
        private string _descParametro;
        #endregion

        #region "Propriedades"
        public string codParametro
        {
            get { return _codParametro; }
            set { _codParametro = value; }
        }

        public string codValorParametro
        {
            get { return _codValorParametro; }
            set { _codValorParametro = value; }
        }
        
        public string descParametro
        {
            get { return _descParametro; }
            set { _descParametro = value; }
        }
        #endregion
    }
}
