using System;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;

namespace GirassoisLocacoes.Forms
{
    public partial class frmDescontoItem : Form
    {
        #region "Variáveis"
        ENReservaItens itemDesconto = new ENReservaItens();
        #endregion

        #region "Construtor"
        public frmDescontoItem(ENReservaItens item)
        {
            itemDesconto = item;
            InitializeComponent();
        }

        private void frmDescontoItem_Load(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "Métodos"

        #region "Limpar"
        public void Limpar()
        {
            CarregaDados();
        }
        #endregion

        #region "CarregaDados"
        private void CarregaDados()
        {
            lblCodigo.Text = Convert.ToDouble(itemDesconto.cdItem).Formatar("000");
            lblDescricao.Text = itemDesconto.nmItem;
            lblQuantidade.Text = itemDesconto.qtdeItem.ToString();
            lblVlrUnit.Text = Convert.ToDouble(itemDesconto.vlrUnit).Formatar("N2");
            txtNovoVlrUnit.Text = Convert.ToDouble(itemDesconto.vlrUnit).Formatar("N2");
            txtPercDesconto.Text = "0,00";
            txtVlrDesconto.Text = "0,00";
            txtNovoVlrTotal.Text = Convert.ToDouble(itemDesconto.total).Formatar("N2");
            lblVlrTotal.Text = Convert.ToDouble(itemDesconto.total).Formatar("N2");
        }
        #endregion

        #region "CalcularTotal"
        private void CalcularTotal()
        {
            double dblVlrTotItens;

            dblVlrTotItens = (Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblVlrUnit.Text));
            txtNovoVlrTotal.Text = (dblVlrTotItens - (Convert.ToDouble(txtVlrDesconto.Text) * Convert.ToDouble(lblQuantidade.Text))).Formatar("N2");
        }
        #endregion

        #region "Confirmar"
        private void Confirmar()
        {
            try
            {
                txtNovoVlrTotal_Leave(null, null);
                txtPercDesconto_Leave(null, null);
                txtVlrDesconto_Leave(null, null);

                itemDesconto.vlrDesconto = Convert.ToDecimal((Convert.ToDouble(lblVlrUnit.Text) - Convert.ToDouble(txtNovoVlrUnit.Text)));
                itemDesconto.total = Convert.ToDecimal(txtNovoVlrTotal.Text);

                this.Dispose();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "GetEntidade"
        public ENReservaItens GetEntidade()
        {
            try
            {
                return itemDesconto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Eventos

        #region "txtVlrDesconto_KeyPress"
        private void txtVlrDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtPercDesconto_KeyPress"
        private void txtPercDesconto_KeyPress(object sender, KeyPressEventArgs e)
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
                double dblVlrTot = 0;
                double dblPercDesc = 0;

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

                dblVlrTot = Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblVlrUnit.Text);

                txtPercDesconto.Text = Convert.ToDouble(txtPercDesconto.Text).Formatar("N2");

                txtVlrDesconto.Text = Convert.ToDouble(txtVlrDesconto.Text).Formatar("N2");
                dblPercDesc = (Convert.ToDouble(txtVlrDesconto.Text) * 100) / Convert.ToDouble(lblVlrUnit.Text);

                dblVlrDesc = Convert.ToDouble(lblVlrUnit.Text) - Convert.ToDouble(txtNovoVlrUnit.Text);

                txtNovoVlrUnit.Text = ((Convert.ToDouble(lblVlrUnit.Text) - ((Convert.ToDouble(lblVlrUnit.Text) * dblPercDesc) / 100))).Formatar("N2");

                if (dblVlrDesc > dblVlrTot)
                {
                    FormHelper.Instance.Advertencia("Valor do desconto não pode ser maior ou igual ao valor total do item.");
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                    CalcularTotal();
                    txtPercDesconto.Focus();
                    return;
                }

                txtVlrDesconto.Text = dblVlrDesc.Formatar("N2");

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
                double dblVlrTotItens = 0;

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

                dblVlrTotItens = (Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblVlrUnit.Text));

                txtVlrDesconto.Text = Convert.ToDouble(txtVlrDesconto.Text).Formatar("N2");
                dblPercDesc = (Convert.ToDouble(txtVlrDesconto.Text) * 100) / Convert.ToDouble(lblVlrUnit.Text);

                txtNovoVlrUnit.Text = ((Convert.ToDouble(lblVlrUnit.Text) - ((Convert.ToDouble(lblVlrUnit.Text) * dblPercDesc) / 100))).Formatar("N2");

                if (Convert.ToDouble(txtVlrDesconto.Text) >= dblVlrTotItens)
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

        #region "txtNovoVlrUnit_KeyPress"
        private void txtNovoVlrUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtNovoVlrUnit_Leave"
        private void txtNovoVlrUnit_Leave(object sender, EventArgs e)
        {
            try
            {
                double dblPercDesc = 0;
                double dblVlrTotItens = 0;

                if (Convert.ToDouble(txtNovoVlrUnit.Text) == Convert.ToDouble(lblVlrUnit.Text))
                    return;

                if (!txtNovoVlrUnit.Text.IsNumeric())
                {
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                }

                if (Convert.ToDouble(txtNovoVlrUnit.Text) < 0 || Convert.ToDouble(txtNovoVlrUnit.Text) > Convert.ToDouble(lblVlrUnit.Text))
                {
                    FormHelper.Instance.Advertencia("Valor inválido!");
                    txtNovoVlrUnit.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    txtNovoVlrUnit.Focus();
                    return;
                }

                dblVlrTotItens = (Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblVlrUnit.Text));

                txtVlrDesconto.Text = (Convert.ToDouble(lblVlrUnit.Text) - Convert.ToDouble(txtNovoVlrUnit.Text)).Formatar("N2");
                dblPercDesc = (Convert.ToDouble(txtVlrDesconto.Text) / Convert.ToDouble(lblVlrUnit.Text)) * 100;

                if (Convert.ToDouble(txtVlrDesconto.Text) >= dblVlrTotItens)
                {
                    FormHelper.Instance.Advertencia("Valor do desconto não pode ser maior ou igual ao valor total do item.");
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    CalcularTotal();
                    txtVlrDesconto.Focus();
                    return;
                }

                txtNovoVlrUnit.Text = Convert.ToDouble(txtNovoVlrUnit.Text).Formatar("N2");
                txtPercDesconto.Text = dblPercDesc.Formatar("N2");
                CalcularTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "txtNovoVlrTotal_KeyPress"
        private void txtNovoVlrTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }

        #endregion

        #region "txtNovoVlrTotal_Leave"
        private void txtNovoVlrTotal_Leave(object sender, EventArgs e)
        {
            try
            {
                double dblPercDesc = 0;
                double dblVlrTotItens = 0;

                if (!txtNovoVlrTotal.Text.IsNumeric())
                {
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                }

                if (Convert.ToDouble(txtNovoVlrTotal.Text) < 0 || Convert.ToDouble(txtNovoVlrTotal.Text) > Convert.ToDouble(lblVlrTotal.Text))
                {
                    FormHelper.Instance.Advertencia("Valor inválido!");
                    txtNovoVlrTotal.Text = "0,00";
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    txtNovoVlrUnit.Text = lblVlrUnit.Text;
                    txtNovoVlrTotal.Focus();
                    return;
                }

                dblVlrTotItens = (Convert.ToDouble(lblQuantidade.Text) * Convert.ToDouble(lblVlrUnit.Text));

                txtVlrDesconto.Text = ((Convert.ToDouble(lblVlrUnit.Text) - Convert.ToDouble(txtNovoVlrUnit.Text)) * Convert.ToDouble(lblQuantidade.Text)).Formatar("N2");
                dblPercDesc = (Convert.ToDouble(txtVlrDesconto.Text) / dblVlrTotItens) * 100;

                if (Convert.ToDouble(txtVlrDesconto.Text) >= dblVlrTotItens)
                {
                    FormHelper.Instance.Advertencia("Valor do desconto não pode ser maior ou igual ao valor total do item.");
                    txtVlrDesconto.Text = "0,00";
                    txtPercDesconto.Text = "0,00";
                    txtVlrDesconto.Focus();
                    return;
                }

                txtPercDesconto.Text = dblPercDesc.Formatar("N2");
                txtNovoVlrTotal.Text = Convert.ToDouble(txtNovoVlrTotal.Text).Formatar("N2");
                txtNovoVlrUnit.Text = (Convert.ToDouble(txtNovoVlrTotal.Text) / Convert.ToDouble(lblQuantidade.Text)).Formatar("N2");
                txtNovoVlrUnit_Leave(null, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnPadraoConfirmar_Click"
        private void btnPadraoConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }
        #endregion

        #region "frmDescontoItem_KeyDown"
        private void frmDescontoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnPadraoConfirmar.PerformClick();
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                {
                    this.Dispose();
                }
            }
        }
        #endregion

        #endregion
    }
}
