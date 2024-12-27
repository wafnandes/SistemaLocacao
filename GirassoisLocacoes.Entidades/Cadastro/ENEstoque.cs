using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Entidades
{
    public class ENEstoque
    {
        #region "Atributos"
        private int _cdItem;
        private string _nomeItem;
        private int _qtdeEstoque;
        private string _descItem;
        private decimal _valorUnit;
        private decimal _valorReposicao;
        private int _qtdeSolicitada;
        #endregion

        #region "Propriedades"
        public int cdItem
        {
            get { return _cdItem; }
            set { _cdItem = value; }
        }

        public string nomeItem
        {
            get { return _nomeItem; }
            set { _nomeItem = value; } 
        }

        public int qtdeEstoque
        {
            get { return _qtdeEstoque; }
            set { _qtdeEstoque = value; }
        }

        public string descItem
        {
            get { return _descItem; }
            set { _descItem = value; }
        }

        public decimal valorUnit
        {
            get { return _valorUnit; }
            set { _valorUnit = value; }
        }

        public decimal valorReposicao
        {
            get { return _valorReposicao; }
            set { _valorReposicao = value; }
        }

        public int qtdeSolicitada
        {
            get { return _qtdeSolicitada; }
            set { _qtdeSolicitada = value; }
        }
        #endregion
    }
}
