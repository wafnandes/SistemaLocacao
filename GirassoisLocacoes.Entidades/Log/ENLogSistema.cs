using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENLogSistema
    {
        #region "Atributos"
        private string _comando;
        #endregion

        #region "Propriedades"
        public string comando
        {
            get { return _comando; }
            set { _comando = value; }
        }
        #endregion
    }
}
