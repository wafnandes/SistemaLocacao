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
    public class NEReservaItens
    {
        public NEReservaItens() { }
        private static NEReservaItens instance;
        public static NEReservaItens Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEReservaItens();
                }
                return instance;
            }
        }

        #region "Gravar"
        public void Gravar(List<ENReservaItens> entidade)
        {
            List<ENReservaItens> pEntidadeDados = (List<ENReservaItens>)entidade;
            ADReservaItens objAD = new ADReservaItens();

            try
            {
                objAD.Gravar(pEntidadeDados);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "GravarItemDanificado"
        public void GravarItem(ENReservaItens entidade)
        {
            ENReservaItens pEntidadeDados = (ENReservaItens)entidade;
            ADReservaItens objAD = new ADReservaItens();

            try
            {
                objAD.GravarItem(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "ObterProxId"
        public DataSet ObterProxId()
        {
            ADReservaItens objAD = new ADReservaItens();
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

        #region "LimparItensReserva"
        public void LimparItensReserva(ENReserva entidade)
        {
            ENReserva pEntidadeDados = (ENReserva)entidade;
            ADReservaItens objAD = new ADReservaItens();

            try
            {
                objAD.LimparItensReserva(pEntidadeDados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
