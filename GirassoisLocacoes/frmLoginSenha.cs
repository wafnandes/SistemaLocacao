using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirassoisLocacoes
{
    public partial class frmLoginSenha : Form
    {
        private int iLargura = 0;
        private int iAltura = 0;

        public frmLoginSenha(int _Largura, int _Altura)
        {
            iLargura = _Largura;
            iAltura = _Altura;
            InitializeComponent();
        }

        private void frmLoginSenha_Load(object sender, EventArgs e)
        {
            try
            {
                this.Location = new Point(iLargura - this.Width - 30, iAltura - this.Height - 30);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #region "frmLoginSenha_FormClosed"
        private void frmLoginSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                Application.Exit();
        }
        #endregion

        #region "button2_Click"
        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; 
            Close();
        }
        #endregion

        #region "btnOk_Click"
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet objDs = new DataSet();

                objDs = NESenha.Instance.Obter(new ENSenha { idUsuario = txtUsuario.Text.Trim() });

                if (objDs.Tables[0].Rows[0]["Mensagem"].ToString() == "OK")
                {
                    if (objDs.Tables[0].Rows[0]["UserPassword"].ToString() != txtSenha.Text.Trim())
                    {
                        FormHelper.Instance.Critica("Senha Inválida");
                        txtSenha.Focus();
                        return;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    FormHelper.Instance.Critica(objDs.Tables[0].Rows[0]["Mensagem"].ToString());
                    txtUsuario.Focus();
                    return;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void frmLoginSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text.Trim() == "")
            {
                txtUsuario.Focus();
                return;
            }
            if(txtUsuario.Text.Trim().Length < 5)
            {
                FormHelper.Instance.Critica("Insira um usuário válido!");
                txtUsuario.Focus();
                return;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            const char LetraG = (char)71;

            if(txtUsuario.Text.Trim().Length == 0)
                e.Handled = e.KeyChar != Delete && e.KeyChar != LetraG;
            else
                e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
    }
}
