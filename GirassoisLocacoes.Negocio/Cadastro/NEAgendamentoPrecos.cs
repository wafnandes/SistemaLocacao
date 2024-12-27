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
    public class NEAgendamentoPrecos
    {
        public NEAgendamentoPrecos() { }
        private static NEAgendamentoPrecos instance;
        public static NEAgendamentoPrecos Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NEAgendamentoPrecos();
                }
                return instance;
            }
        }

        #region "Obter"
        public List<ENEstoque> ObterDadosCombo()
        {
            List<ENEstoque> listaEstoque = new List<ENEstoque>();
            ADEstoque objAD = new ADEstoque();
            DataSet objDS = new DataSet();

            try
            {
                objDS = objAD.Obter(true);

                foreach (DataRow dr in objDS.Tables[0].Rows)
                {
                    ENEstoque item = new ENEstoque();

                    item.cdItem = Convert.ToInt32(dr["cdItem"]);
                    item.nomeItem = dr["nmItem"].ToString();
                    item.valorUnit = Convert.ToDecimal(dr["vlrUnit"]);

                    listaEstoque.Add(item);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaEstoque;
        }
        #endregion

        #region "Gravar"
        public void Gravar(ENAgendamentoPrecos entidade)
        {
            ENAgendamentoPrecos pEntidadeDados = (ENAgendamentoPrecos)entidade;
            ADAgendamentoPrecos objAD = new ADAgendamentoPrecos();

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

        #region "Gravar"
        public DataSet Obter()
        {
            ADAgendamentoPrecos objAD = new ADAgendamentoPrecos();
            DataSet objDs = new DataSet();

            try
            {
                objDs = objAD.Obter();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return objDs;
        }
        #endregion

    }
}
