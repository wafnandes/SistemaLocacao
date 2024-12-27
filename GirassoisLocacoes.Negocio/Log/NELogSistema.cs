using GirassoisLocacoes.Db;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirassoisLocacoes.Negocio
{
    public class NELogSistema
    {
        public NELogSistema() { }
        private static NELogSistema instance;
        public static NELogSistema Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NELogSistema();
                }
                return instance;
            }
        }

        public void Gravar(ENLogSistema entidade)
        {
            ENLogSistema pEntidadeDados = (ENLogSistema)entidade;
            ADLogSistema objAD = new ADLogSistema();
            try
            {
                objAD.Gravar(entidade);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ObterInfoDatabase()
        {
            ADLogSistema objAD = new ADLogSistema();
            DataSet objDs = new DataSet();
            try
            {
                objDs = objAD.ObterInfosDatabase();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objDs;
        }
    }
}
