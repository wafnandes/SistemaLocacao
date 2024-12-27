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
    public class NEEspaco
    {
        #region "Construtor"
        public NEEspaco() { }

        private static NEEspaco instance;

        public static NEEspaco Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEEspaco();
                }
                return instance;
            }
        }
        #endregion

        #region "Obter"
        public DataSet Obter()
        {
            ADEspaco objAD = new ADEspaco();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.Obter();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objDS;
        }
        #endregion

        #region "Gravar"
        public void Gravar(ENEspaco entidade)
        {
            ENEspaco pEntidadeDados = (ENEspaco)entidade;
            ADEspaco objAD = new ADEspaco();

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
        public void Excluir(ENEspaco entidade)
        {
            ENEspaco pEntidadeDados = (ENEspaco)entidade;
            ADEspaco objAD = new ADEspaco();

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
    }
}
