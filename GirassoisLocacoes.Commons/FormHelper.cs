using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirassoisLocacoes.Commons
{
    public class FormHelper
    {
        private static FormHelper instance;

        public static FormHelper Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new FormHelper();   
                }
                return instance;
            } 
        }

        #region Critica
        public void Critica(string strMensagem)
        {
            Application.DoEvents();
            LogSistema("Crítica: " + strMensagem);
            MessageBox.Show(strMensagem, "Crítica", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Form.ActiveForm
            Application.DoEvents();
        }
        #endregion

        #region "Informacao"
        public void Informacao(string strMensagem)
        {
            Application.DoEvents();
            LogSistema("Informação: " + strMensagem);
            MessageBox.Show(strMensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.DoEvents();
        }
        #endregion

        #region "Advertencia"
        public void Advertencia(string strMensagem)
        {
            Application.DoEvents();
            LogSistema("Advertência: " + strMensagem);
            MessageBox.Show(strMensagem, "Advertência", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.DoEvents();
        }
        #endregion 

        #region "Pergunta"
        public DialogResult Pergunta(string strMensagem, bool booMarcaBtNao = false)
        {
            Application.DoEvents();
            DialogResult dlgResult;

            LogSistema("Pergunta: " + strMensagem);

            if (booMarcaBtNao)
            {
                dlgResult = MessageBox.Show(strMensagem, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                dlgResult = MessageBox.Show(strMensagem, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }

            LogSistema("Resposta: " + ((dlgResult == DialogResult.Yes) ? "Sim" : "Nao"));
            Application.DoEvents();

            return dlgResult;
        }
        #endregion

        #region "LogSistema"
        public void LogSistema(string mensagem)
        {
            ENLogSistema log = new ENLogSistema();
            log.comando = mensagem;
            NELogSistema.Instance.Gravar(log);
        }
        #endregion

        #region "setControlInitialState"
        public void setControlInitialState(bool habilitaCampo, bool setaFocusNoPrimeiroCampo, params Control[] controls)
        {
            try
            {
                foreach (Control control in controls)
                {
                    resetaCampos(control);
                    control.Enabled = habilitaCampo;
                }
                if (setaFocusNoPrimeiroCampo)
                    controls[0].Focus();

                controls[0].Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "resetaCampos"
        private void resetaCampos(Control control)
        {
            if(control.GetType() != typeof(Button))
            {
                if (control.GetType() == typeof(DataGridView))
                    ((DataGridView)control).DataSource = null;
                else if (control.GetType() == typeof(CheckBox))
                    ((CheckBox)control).Checked = false;
                else if (control.GetType() == typeof(ComboBox))
                    ((ComboBox)control).Text = "";
                else if (control.GetType() == typeof(RadioButton))
                    ((RadioButton)control).Checked = true;
                else if (control.GetType() == typeof(TextBox))
                    ((TextBox)control).Clear();
                else
                    control.Text = "";
            }
        }
        #endregion

        #region "MascaraData"
        public string MascaraData(string strData)
        {
            strData = LimpaNumeros(strData);

            if (strData.Length == 8)
                return Convert.ToUInt64(strData).ToString(@"00/00/0000");
            else
                return "";
        }
        #endregion

        #region "Mascara CPF/CNPJ"
        public string MascaraCPFCNPJ(string strCpfCnpj)
        {
            strCpfCnpj = LimpaNumeros(strCpfCnpj);

            if (strCpfCnpj.Trim().Length != 11 && strCpfCnpj.Trim().Length != 14)
            {
                return "";
            }
            else
            {
                if (strCpfCnpj.Trim().Length == 11)
                    return Convert.ToUInt64(strCpfCnpj.Trim()).ToString(@"000\.000\.000\-00");
                else
                    return Convert.ToUInt64(strCpfCnpj.Trim()).ToString(@"00\.000\.000/0000-00");
            }
        }
        #endregion

        #region "MascaraCEP"
        public string MascaraCEP(string strCep)
        {
            strCep = LimpaNumeros(strCep);

            if (strCep.Trim().Length != 8)
                return "";
            else
                return Convert.ToUInt64(strCep.Trim()).ToString(@"00\.000\-000");
        }
        #endregion

        #region "MascaraTelefone"
        public string MascaraTelefone(string strTel)
        {
            strTel = LimpaNumeros(strTel);

            if (strTel.Length == 10)
                return Convert.ToUInt64(strTel).ToString(@"(00\)\ \ 0000\-0000");
            else 
                if (strTel.Length == 11)
                    return Convert.ToUInt64(strTel).ToString(@"(00\)\ 00000\-0000");
                else
                    return "";
        }
        #endregion

        #region "LimpaNumeros"
        public string LimpaNumeros(string strText)
        {
            string strResultado = "";
            strResultado = new string(strText.Where(char.IsDigit).ToArray());

            return strResultado;
        }
        #endregion

        #region "ValidaCNPJCPF"
        public bool ValidaCNPJCPF(string CGC_CPF, bool blnMsg = false)
        {
            string strCaracter;
            string strAux;
            bool blnValido;
            bool blnX;

            blnValido = false;

            if (CGC_CPF.Trim() != "")
            {
                strAux = LimpaNumeros(CGC_CPF);

                strCaracter = strAux.Substring(0, 1);

                for (int i = 1; i < strAux.Length; i++)
                {
                    if (strCaracter != strAux.Substring(i, 1))
                    {
                        blnValido = true;
                        break;
                    }

                    strCaracter = strAux.Substring(i, 1);
                }

                if (!blnValido)
                {
                    return false;
                }

                if (strAux.Length > 11)
                {
                    blnX = DigitoVerificadorCGC(CGC_CPF);
                }
                else
                {
                    blnX = DigitoVerificadorCPF(CGC_CPF);
                }
            }
            else
            {
                blnX = false;
            }

            if (blnX)
            {
                return true;
            }
            else if (blnX = false && blnMsg)
            {
                Critica("CGC ou CPF Incorreto, Por favor Verifique!");
            }
            else if (blnMsg)
            {
                Critica("Número incorreto de caracteres!");
            }

            return false;
        }
        #endregion

        #region "DigitoVerificadorCGC"
        private bool DigitoVerificadorCGC(string CGC)
        {
            string strCaracter;
            string strcampo;
            string strConf;
            string strCGC;
            string strAux;
            double dblDivisao;
            long lngInteiro;
            int intNumero;
            int intSoma2;
            int intsoma1;
            int intSoma;
            int intResto;
            int intMais;
            int intDig1;
            int intDig2;

            strAux = LimpaNumeros(CGC);

            intSoma = 0;
            intsoma1 = 0;
            intSoma2 = 0;
            intNumero = 0;
            intMais = 0;

            strCGC = Right(strAux, 6);
            strCGC = Left(strCGC, 4);
            strcampo = Left(strAux, 8);
            strcampo = Right(strcampo, 4) + strCGC;

            for (int i = 2; i <= 9; i++)
            {
                strCaracter = Right(strcampo, i - 1);
                intNumero = Convert.ToInt32(Left(strCaracter, 1));
                intMais = intNumero * i;
                intsoma1 += intMais;
            }

            strcampo = Left(strAux, 4);

            for (int i = 2; i <= 5; i++)
            {
                strCaracter = Right(strcampo, i - 1);
                intNumero = Convert.ToInt32(Left(strCaracter, 1));
                intMais = intNumero * i;
                intSoma2 += intMais;
            }

            intSoma = intsoma1 + intSoma2;
            dblDivisao = (double)intSoma / 11;
            lngInteiro = (int)dblDivisao * 11;
            intResto = (int)(intSoma - lngInteiro);

            if (intResto == 0 || intResto == 1)
            {
                intDig1 = 0;
            }
            else
            {
                intDig1 = 11 - intResto;
            }

            intSoma = 0;
            intsoma1 = 0;
            intSoma2 = 0;
            intNumero = 0;
            intMais = 0;

            strCGC = Right(strAux, 6);
            strCGC = Left(strCGC, 4);
            strcampo = Left(strAux, 8);
            strcampo = Right(strcampo, 3) + "" + strCGC + "" + intDig1;

            for (int i = 2; i <= 9; i++)
            {
                strCaracter = Right(strcampo, i - 1);
                intNumero = Convert.ToInt32(Left(strCaracter, 1));
                intMais = intNumero * i;
                intsoma1 += intMais;
            }

            strcampo = Left(strAux, 5);

            for (int i = 2; i <= 6; i++)
            {
                strCaracter = Right(strcampo, i - 1);
                intNumero = Convert.ToInt32(Left(strCaracter, 1));
                intMais = intNumero * i;
                intSoma2 += intMais;
            }

            intSoma = intsoma1 + intSoma2;
            dblDivisao = (double)intSoma / 11;
            lngInteiro = (int)dblDivisao * 11;
            intResto = (int)(intSoma - lngInteiro);

            if (intResto == 0 || intResto == 1)
            {
                intDig2 = 0;
            }
            else
            {
                intDig2 = 11 - intResto;
            }

            strConf = intDig1.ToString() + "" + intDig2.ToString();

            if (strConf != Right(strAux, 2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region "DigitoVerificadorCPF"
        private bool DigitoVerificadorCPF(string CPF)
        {
            string strCaracter;
            string strcampo;
            string strConf;
            string strAux;
            double dblDivisao;
            long lngInteiro;
            long lngSoma;
            int intNumero;
            int intResto;
            int intMais;
            int intDig1;
            int intDig2;

            strAux = LimpaNumeros(CPF);

            lngSoma = 0;
            intNumero = 0;
            intMais = 0;
            strcampo = Left(strAux, 9);

            for (int i = 2; i <= 10; i++)
            {
                strCaracter = Right(strcampo, i - 1);
                intNumero = Convert.ToInt32(Left(strCaracter, 1));
                intMais = intNumero * i;
                lngSoma += intMais;
            }

            dblDivisao = (double)lngSoma / 11;
            lngInteiro = (int)dblDivisao * 11;
            intResto = (int)(lngSoma - lngInteiro);

            if (intResto == 0 || intResto == 1)
            {
                intDig1 = 0;
            }
            else
            {
                intDig1 = 11 - intResto;
            }

            strcampo = strcampo + "" + intDig1;
            lngSoma = 0;
            intNumero = 0;
            intMais = 0;

            for (int i = 2; i <= 11; i++)
            {
                strCaracter = Right(strcampo, i - 1);
                intNumero = Convert.ToInt32(Left(strCaracter, 1));
                intMais = intNumero * i;
                lngSoma += intMais;
            }

            dblDivisao = (double)lngSoma / 11;
            lngInteiro = (int)dblDivisao * 11;
            intResto = (int)(lngSoma - lngInteiro);

            if (intResto == 0 || intResto == 1)
            {
                intDig2 = 0;
            }
            else
            {
                intDig2 = 11 - intResto;
            }

            strConf = intDig1.ToString() + "" + intDig2.ToString();

            if (strConf != Right(strAux, 2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region "Right"
        public string Right(string strTexto, int intLen)
        {
            if (strTexto == null)
                return "";

            if (intLen > strTexto.Length)
            {
                return strTexto;
            }
            else
            {
                return strTexto.Substring(strTexto.Length - intLen, intLen);
            }
        }
        #endregion

        #region "Left"
        public string Left(string strTexto, int intLen)
        {
            if (strTexto == null)
                return "";

            if (intLen > strTexto.Length)
            {
                return strTexto;
            }
            else
            {
                return strTexto.Substring(0, intLen);
            }
        }
        #endregion
    }
}
