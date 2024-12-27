using System;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmPesquisaEspaco : Form
    {
        #region "Variáveis"
        ENEspaco pEntidade = new ENEspaco();
        #endregion

        #region "Construtor"
        public frmPesquisaEspaco()
        {
            InitializeComponent();
        }

        private void frmPesquisaEspaco_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarGrid();
        }
        #endregion

        #region "Métodos"

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;

                lvwInfo.DataSource = NEEspaco.Instance.Obter().Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        #endregion

        #region "ConfigurarGrid"
        private void ConfigurarGrid()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (lvwInfo.Rows.Count > 0)
                {
                    lvwInfo.Columns["nmEspaco"].HeaderText = "Nome do Espaço";
                    lvwInfo.Columns["nmProprietario"].Visible = false;
                    lvwInfo.Columns["telProprietario"].Visible = false;
                    lvwInfo.Columns["cep"].Visible = false;
                    lvwInfo.Columns["endEspaco"].Visible = false;
                    lvwInfo.Columns["compl"].Visible = false;
                    lvwInfo.Columns["bairro"].Visible = false;
                    lvwInfo.Columns["cidade"].Visible = false;
                    lvwInfo.Columns["estado"].Visible = false;
                    lvwInfo.Columns["nmEspaco"].Width = 540;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion

        #region "GetEntidade"
        public ENEspaco GetEntidade()
        {
            return pEntidade;
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "lvwInfo_CellDoubleClick"
        private void lvwInfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lvwInfo.Rows.Count > 0)
            {
                if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
                {
                    pEntidade.nmEspaco = Convert.ToString(lvwInfo.CurrentRow.Cells["nmEspaco"].Value);

                    if (Convert.ToString(lvwInfo.CurrentRow.Cells["telProprietario"].Value) != "0")
                        pEntidade.telProprietario = Convert.ToInt64(lvwInfo.CurrentRow.Cells["telProprietario"].Value);

                    pEntidade.cep = Convert.ToInt64(lvwInfo.CurrentRow.Cells["cep"].Value);
                    pEntidade.endEspaco = Convert.ToString(lvwInfo.CurrentRow.Cells["endEspaco"].Value);
                    pEntidade.compl = Convert.ToString(lvwInfo.CurrentRow.Cells["compl"].Value);
                    pEntidade.bairro = Convert.ToString(lvwInfo.CurrentRow.Cells["bairro"].Value);
                    pEntidade.cidade = Convert.ToString(lvwInfo.CurrentRow.Cells["cidade"].Value);
                    pEntidade.estado = Convert.ToString(lvwInfo.CurrentRow.Cells["estado"].Value);

                    this.Dispose();
                }
            }
        }
        #endregion

        #endregion

        #region "lvwInfo_KeyDown"
        private void lvwInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (lvwInfo.Rows.Count > 0)
                {
                    if (FormHelper.Instance.Pergunta("Deseja carregar os dados?", false) == DialogResult.Yes)
                    {
                        pEntidade.nmEspaco = Convert.ToString(lvwInfo.CurrentRow.Cells["nmEspaco"].Value);

                        if (Convert.ToString(lvwInfo.CurrentRow.Cells["telProprietario"].Value) != "0")
                            pEntidade.telProprietario = Convert.ToInt64(lvwInfo.CurrentRow.Cells["telProprietario"].Value);

                        pEntidade.cep = Convert.ToInt64(lvwInfo.CurrentRow.Cells["cep"].Value);
                        pEntidade.endEspaco = Convert.ToString(lvwInfo.CurrentRow.Cells["endEspaco"].Value);
                        pEntidade.compl = Convert.ToString(lvwInfo.CurrentRow.Cells["compl"].Value);
                        pEntidade.bairro = Convert.ToString(lvwInfo.CurrentRow.Cells["bairro"].Value);
                        pEntidade.cidade = Convert.ToString(lvwInfo.CurrentRow.Cells["cidade"].Value);
                        pEntidade.estado = Convert.ToString(lvwInfo.CurrentRow.Cells["estado"].Value);

                        this.Dispose();
                    }
                }
            }
            else
            {
                if (e.KeyCode == Keys.Escape)
                    this.Dispose();
            }
        }
        #endregion
    }
}
