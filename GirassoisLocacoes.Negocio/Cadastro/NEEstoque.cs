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
    public class NEEstoque
    {
        public NEEstoque() { }
        private static NEEstoque instance;
        public static NEEstoque Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEEstoque();
                }
                return instance;
            }
        }

        #region "ObterProxId"
        public DataSet ObterProxId()
        {
            ADEstoque objAD = new ADEstoque();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.ObterProxId();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objDS;
        }
        #endregion

        #region "Obter"
        public DataSet Obter()
        {
            ADEstoque objAD = new ADEstoque();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.Obter(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objDS;
        }
        #endregion

        #region "Gravar"
        public void Gravar(ENEstoque entidade)
        {
            ENEstoque pEntidadeDados = (ENEstoque)entidade;
            ADEstoque objAD = new ADEstoque();

            try
            {
                objAD.Gravar(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Excluir"
        public void Excluir(ENEstoque entidade)
        {
            ENEstoque pEntidadeDados = (ENEstoque)entidade;
            ADEstoque objAD = new ADEstoque();

            try
            {
                objAD.Excluir(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ObterItem"
        public DataSet ObterItem(ENEstoque entidade)
        {
            ENEstoque pEntidadeDados = (ENEstoque)entidade;
            ADEstoque objAD = new ADEstoque();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.ObterItem(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objDS;
        }
        #endregion
    }
}
