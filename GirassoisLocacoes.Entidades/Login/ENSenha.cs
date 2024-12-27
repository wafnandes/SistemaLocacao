using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENSenha
    {
        #region "Atributos"
        private string _idUsuario;
        #endregion

        #region "Propriedades"
        public string idUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }
        #endregion
    }
}
