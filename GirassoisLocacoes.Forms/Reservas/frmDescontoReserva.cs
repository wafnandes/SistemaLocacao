using System;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;

namespace GirassoisLocacoes.Forms
{
    public partial class frmDescontoReserva : Form
    {
        #region "Variáveis"
        ENReserva entidadeValores = new ENReserva();
        double vlrAtualReserva;
        #endregion

        #region "Construtor"
        public frmDescontoReserva()
        {
            InitializeComponent();
        }

        public frmDescontoReserva(double vlrReserva)
        {
            vlrAtualReserva = vlrReserva;
            InitializeComponent();
        }

        private void frmDescontoReserva_Load(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "Métodos"

        #region "Limpar"
        private void Limpar()
        {
            txtPercDesconto.Text = "0,00";
            txtVlrDesconto.Text = "0,00";
            lblVlrAtualReserva.Text = vlrAtualReserva.Formatar("N2");
            txtNovoVlrReserva.Text = vlrAtualReserva.Formatar("N2");
        }
        #endregion

        #region "Confirmar"
        private void Confirmar()
        {
            try
            {
                txtPercDesconto_Leave(null, null);
                txtVlrDesconto_Leave(null, null); 
                txtNovoVlrReserva_Leave(null, null);

                entidadeValores.vlrDesconto = Convert.ToDecimal(txtVlrDesconto.Text);
                entidadeValores.vlrTotal = Convert.ToDecimal(txtNovoVlrReserva.Text);
                this.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "CalcularTotal"
        private void CalcularTotal()
        {
            txtNovoVlrReserva.Text = Math.Round(Convert.ToDouble(lblVlrAtualReserva.Text) - Convert.ToDouble(txtVlrDesconto.Text)).Formatar("N2");
        }
        #endregion

        #region "GetEntidade"
        public ENReserva GetEntidade()
        {
            return entidadeValores;
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "frmDescontoReserva_KeyDown"
        private void frmDescontoReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
            {
                btnPadraoConfirmar.PerformClick();
            }
            else
            {
                if(e.KeyCode == Keys.Escape)
                {
                    this.Dispose();
                }
            }
        }
        #endregion

        #region "btnPadraoConfirmar_Click"
        private void btnPadraoConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        #endregion

        #region "txtPercDesconto_KeyPress"
        private void txtPercDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtVlrDesconto_KeyPress"
        private void txtVlrDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtNovoVlrReserva_KeyPress"
        private void txtNovoVlrReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtPercDesconto_Leave"
        private void txtPercDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                double dblVlrDesc = 0;

                if (!txtPercDesconto.Text.IsNumeric())
                {
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                }

                if (Convert.ToDouble(txtPercDesconto.Text) < 0)
                {
                    FormHelper.Instance.Advertencia("Valor inválido!");
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Focus();
                    return;
                }

                txtPercDesconto.Text = Convert.ToDouble(txtPercDesconto.Text).Formatar("N2");

                dblVlrDesc = ((Convert.ToDouble(lblVlrAtualReserva.Text) * Convert.ToDouble(txtPercDesconto.Text)) / 100);

                txtVlrDesconto.Text = dblVlrDesc.Formatar("N2");

                if (dblVlrDesc > Convert.ToDouble(lblVlrAtualReserva.Text))
                {
                    FormHelper.Instance.Advertencia("Valor do desconto não pode ser maior ou igual ao valor da reserva.");
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                    CalcularTotal();
                    txtPercDesconto.Focus();
                    return;
                }


                CalcularTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "txtVlrDesconto_Leave"
        private void txtVlrDesconto_Leave(object sender, EventArgs e)
        {
            try
            {
                double dblPercDesc = 0;

                if (!txtVlrDesconto.Text.IsNumeric())
                {
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                }

                if (Convert.ToDouble(txtVlrDesconto.Text) < 0)
                {
                    FormHelper.Instance.Advertencia("Valor inválido!");
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Focus();
                    return;
                }


                txtVlrDesconto.Text = Convert.ToDouble(txtVlrDesconto.Text).Formatar("N2");
                dblPercDesc = (Convert.ToDouble(txtVlrDesconto.Text) / Convert.ToDouble(lblVlrAtualReserva.Text)) * 100;

                if (Convert.ToDouble(txtVlrDesconto.Text) >= Convert.ToDouble(lblVlrAtualReserva.Text))
                {
                    FormHelper.Instance.Advertencia("Valor do desconto não pode ser maior ou igual ao valor total do item.");
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    CalcularTotal();
                    txtVlrDesconto.Focus();
                    return;
                }

                txtPercDesconto.Text = dblPercDesc.Formatar("N2");
                CalcularTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "txtNovoVlrReserva_Leave"
        private void txtNovoVlrReserva_Leave(object sender, EventArgs e)
        {
            try
            {
                double dblPercDesc = 0;

                if (!txtNovoVlrReserva.Text.IsNumeric())
                {
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                }

                if (Convert.ToDouble(txtNovoVlrReserva.Text) < 0 || Convert.ToDouble(txtNovoVlrReserva.Text) > Convert.ToDouble(lblVlrAtualReserva.Text))
                {
                    FormHelper.Instance.Advertencia("Valor inválido!");
                    txtNovoVlrReserva.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    txtNovoVlrReserva.Focus();
                    return;
                }

                txtVlrDesconto.Text = (Convert.ToDouble(lblVlrAtualReserva.Text) - Convert.ToDouble(txtNovoVlrReserva.Text)).Formatar("N2");
                dblPercDesc = (Convert.ToDouble(txtVlrDesconto.Text) / Convert.ToDouble(lblVlrAtualReserva.Text)) * 100;

                if (Convert.ToDouble(txtVlrDesconto.Text) >= Convert.ToDouble(lblVlrAtualReserva.Text))
                {
                    FormHelper.Instance.Advertencia("Valor do desconto não pode ser maior ou igual ao valor total do item.");
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Focus();
                    return;
                }

                txtPercDesconto.Text = dblPercDesc.Formatar("N2");
                txtNovoVlrReserva.Text = Convert.ToDouble(txtNovoVlrReserva.Text).Formatar("N2");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion
    }
}
