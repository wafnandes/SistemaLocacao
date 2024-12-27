using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirassoisLocacoes.Commons
{
    public static class Funcoes
    {
        #region "SoNumeros"
        public static void SoNumeros(KeyPressEventArgs e, enumVirgulaPonto intVirgulaPonto = enumVirgulaPonto.Nenhum)
        {
            if (e.KeyChar == Asc(","))
            {
                if (intVirgulaPonto == enumVirgulaPonto.Ponto || intVirgulaPonto == enumVirgulaPonto.Nenhum)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar == Asc("."))
            {
                if (intVirgulaPonto == enumVirgulaPonto.Virgula || intVirgulaPonto == enumVirgulaPonto.Nenhum)
                {
                    e.Handled = true;
                    return;
                }
                else if (intVirgulaPonto == enumVirgulaPonto.ConvertePontoVirgula)
                {
                    e.Handled = true;
                    SendKeys.Send(",");
                    return;
                }
            }

            if (!Chr(e.KeyChar).ToString().IsNumeric() && e.KeyChar != Asc(",") && e.KeyChar != Asc(".") && e.KeyChar != Asc(Chr(8).ToString()))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region "Asc"
        public static int Asc(string strLetra)
        {
            char[] chrBuffer = { Convert.ToChar(strLetra) };
            byte[] bytBuffer = Encoding.GetEncoding(1252).GetBytes(chrBuffer);

            return (int)bytBuffer[0];
        }
        #endregion

        #region "Chr"
        public static char Chr(int intCodigo)
        {
            byte[] bytBuffer = new byte[] { (byte)intCodigo };

            return
                Convert.ToChar(Encoding.GetEncoding(1252).GetString(bytBuffer));
        }
        #endregion

        #region "IsNumeric"
        public static bool IsNumeric(this object objeto)
        {
            if (objeto == null)
                objeto = false;

            double dblResult;
            return double.TryParse(objeto.ToString(), out dblResult);
        }
        #endregion

        #region "Formatar"
        public static string Formatar(this double objeto, string sFormato)
        {
            return String.Format("{0:" + sFormato + "}", objeto);
        }
        #endregion

        #region "GetDataTablebyDataSet"
        public static System.Data.DataTable GetDataTablebyDataSet(DataSet ds)
        {
            System.Data.DataTable table = new System.Data.DataTable();

            try
            {
                if(ds != null && ds.Tables.Count > 0)
                    table = ds.Tables[0];

                return table;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
