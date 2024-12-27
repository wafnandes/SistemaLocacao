using System;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;

namespace GirassoisLocacoes.Forms
{
    public partial class frmTaxaEntrega : Form
    {
        #region "Variáveis"
        ENReservaItens taxaEntrega = new ENReservaItens();
        #endregion

        #region "Construtor"
        public frmTaxaEntrega()
        {
            InitializeComponent();
        }
        #endregion

        #region "Métodos"

        #region "Confirmar"
        private void Confirmar()
        {
            try
            {
                if (Convert.ToDouble(txtValor.Text.Trim()) == 0)
                    return;

                taxaEntrega.cdItem = 999;
                taxaEntrega.nmItem = "Taxa de Entrega";
                taxaEntrega.qtdeItem = 1;
                taxaEntrega.vlrDesconto = 0;
                taxaEntrega.vlrUnit = 0;
                taxaEntrega.vlrReposicao = 0;
                taxaEntrega.total = Convert.ToDecimal(txtValor.Text);

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
            return taxaEntrega;
        }
        #endregion

        #endregion

        #region "Eventos

        #region "frmTaxaEntrega_KeyDown"
        private void frmTaxaEntrega_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else
            {
                if(e.KeyCode == Keys.F2)
                {
                    btnPadraoConfirmar.PerformClick();
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

        #region "txtValor_KeyPress"
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funcoes.SoNumeros(e, enumVirgulaPonto.ConvertePontoVirgula);
        }
        #endregion

        #region "txtValor_KeyDown"
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtValor.Text = Convert.ToDouble(txtValor.Text).Formatar("N2");
        }
        #endregion

        #endregion
    }
}
