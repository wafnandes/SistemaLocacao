using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENAgendamentoPrecos
    {
        #region "Atributos"
        private int _idPreco;
        private int _cdItem;
        private decimal _vlrUnit;
        private DateTime _dtInicio;
        private DateTime _dtFim;
        #endregion

        #region "Propriedades"
        public int idPreco
        {
            get { return _idPreco; }
            set { _idPreco = value; }
        }

        public int cdItem
        {
            get { return _cdItem; }
            set { _cdItem = value; }
        }

        public decimal vlrUnit
        {
            get { return _vlrUnit; }
            set { _vlrUnit = value; }
        }

        public DateTime dtInicio
        {
            get { return _dtInicio; }
            set { _dtInicio = value; }
        }

        public DateTime dtFim
        {
            get { return _dtFim; }
            set { _dtFim = value; }
        }
        #endregion
    }
}
