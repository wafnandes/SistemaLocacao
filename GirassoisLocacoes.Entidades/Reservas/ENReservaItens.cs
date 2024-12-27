using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENReservaItens
    {
        #region "Atributos"
        private int _idReserva;
        private int _cdItem;
        private string _nmItem;
        private decimal _vlrUnit;
        private decimal _vlrReposicao;
        private int _qtdeItem;
        private decimal _vlrBruto;
        private decimal _vlrDesconto;
        private decimal _total;
        #endregion

        #region "Propriedades"
        public int idReserva
        {
            get { return _idReserva; }
            set { _idReserva = value; }
        }

        public int cdItem
        {
            get { return _cdItem; } 
            set { _cdItem = value; }
        }

        public string nmItem
        {
            get { return _nmItem; }
            set { _nmItem = value; }
        }

        public decimal vlrUnit
        {
            get { return _vlrUnit; }
            set { _vlrUnit = value; }
        }

        public decimal vlrReposicao
        {
            get { return _vlrReposicao; }
            set { _vlrReposicao = value; }
        }

        public int qtdeItem
        {
            get { return _qtdeItem; }
            set { _qtdeItem = value; }
        }
        
        public decimal vlrBruto
        {
            get { return _vlrBruto; }
            set { _vlrBruto = value; }
        }

        public decimal vlrDesconto
        {
            get { return _vlrDesconto; }
            set { _vlrDesconto = value; }
        }

        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
        #endregion
    }
}
