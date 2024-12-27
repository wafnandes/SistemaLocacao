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
    public class NESenha
    {
        public NESenha() { }
        private static NESenha instance;
        public static NESenha Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NESenha();
                }
                return instance;
            }
        }

        #region "Obter"
        public DataSet Obter(ENSenha entidade)
        {
            ENSenha pEntidadeDados = (ENSenha)entidade;
            ADSenha objAD = new ADSenha();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.Obter(pEntidadeDados);
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
