using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmHistorico : Form
    {
        #region "Variáveis"
        DataGridViewRow row = null;
        #endregion

        #region "Construtor"
        public frmHistorico()
        {
            InitializeComponent();
        }

        private void frmHistorico_Load(object sender, EventArgs e)
        {
            Limpar();
        }
        #endregion

        #region "Métodos"

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                ENReserva entidade = new ENReserva();
                entidade.idFinalizado = true;
                entidade.nmCliente = txtNome.Text.Trim();
                    
                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;

                if(NEReserva.Instance.ObterReservasAtivas(entidade).Tables[0].Rows.Count > 0)
                    lvwInfo.DataSource = NEReserva.Instance.ObterReservasAtivas(entidade).Tables[0];
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

                if(lvwInfo.Rows.Count > 0)
                {
                    lvwInfo.Columns["cdReserva"].HeaderText = "Código";
                    lvwInfo.Columns["cdReserva"].Width = 50;
                    lvwInfo.Columns["cdReserva"].ReadOnly = true;
                    lvwInfo.Columns["cdReserva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    lvwInfo.Columns["nmCli"].HeaderText = "Cliente";
                    lvwInfo.Columns["nmCli"].Width = 417;
                    lvwInfo.Columns["nmCli"].ReadOnly = true;

                    lvwInfo.Columns["dtEntrega"].HeaderText = "Data de Entrega";
                    lvwInfo.Columns["dtEntrega"].Width = 110;
                    lvwInfo.Columns["dtEntrega"].ReadOnly = true;

                    lvwInfo.Columns["dtDevolucao"].HeaderText = "Data de Devolução";
                    lvwInfo.Columns["dtDevolucao"].Width = 110;
                    lvwInfo.Columns["dtDevolucao"].ReadOnly = true;

                    lvwInfo.Columns["vlrTotalReserva"].HeaderText = "Valor Total";
                    lvwInfo.Columns["vlrTotalReserva"].Width = 70;
                    lvwInfo.Columns["vlrTotalReserva"].ReadOnly = true;
                    lvwInfo.Columns["vlrTotalReserva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    if (lvwInfo.Rows.Count > 10)
                        lvwInfo.Columns["nmCli"].Width = 402;
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

        #region "Limpar"
        private void Limpar()
        {
            CarregarGrid();
            ConfigurarGrid();
            btnPadraoExcluir.Visible = false;
            btnPadraoNovo.Visible = false;
            btnPadraoConfirmar.Visible = false;
        }
        #endregion

        #region "BuildFormData"

        #endregion

        #endregion

        #region "Eventos" 

        #region"mnuDetalhe_Click"
        private void mnuDetalhe_Click(object sender, EventArgs e)
        {
            try
            {
                if (row != null)
                {
                    ENReserva entidade = new ENReserva();
                    List<ENReservaItens> itens = new List<ENReservaItens>();

                    entidade.cdReserva = Convert.ToInt32(row.Cells["cdReserva"].Value);

                    entidade = NEReserva.Instance.ObterDetalhesReserva(entidade);
                    itens = NEReserva.Instance.ObterItensReserva(entidade);

                    frmConsultaReserva consultaReserva = new frmConsultaReserva(entidade,itens); 
                    this.Enabled = false;
                    consultaReserva.ShowDialog();
                    consultaReserva.BringToFront();
                    this.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "mnuInformarOcorrencia_Click"
        private void mnuInformarOcorrencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (row != null)
                {
                    ENReserva entidade = new ENReserva();

                    entidade.cdReserva = Convert.ToInt32(row.Cells["cdReserva"].Value);

                    entidade = NEReserva.Instance.ObterDetalhesReserva(entidade);

                    frmInserirOcorrencia frmOcorrencia = new frmInserirOcorrencia(entidade);
                    this.Enabled = false;
                    frmOcorrencia.ShowDialog();
                    frmOcorrencia.BringToFront();
                    this.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "chkReservasAtivas_CheckedChanged"
        private void chkReservasAtivas_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarGrid();
        }
        #endregion

        #region "chkFiltrar_CheckedChanged"
        private void chkFiltrar_CheckedChanged(object sender, EventArgs e)
        {
            FormHelper.Instance.setControlInitialState(true, true, txtNome);
        }
        #endregion

        #region "txtNome_KeyUp"
        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            CarregarGrid();
            ConfigurarGrid();
        }
        #endregion

        #region "lvwInfo_MouseDown"
        private void lvwInfo_MouseDown(object sender, MouseEventArgs e)
        {
            Application.DoEvents();

            if (e.Button == MouseButtons.Right)
            {
                var ht = lvwInfo.HitTest(e.X, e.Y);

                if (ht.RowIndex > -1)
                {
                    lvwInfo[ht.ColumnIndex, ht.RowIndex].Selected = true;
                    mnuContexto.Show(lvwInfo.PointToScreen(new Point(e.X, e.Y)));
                    row = lvwInfo.CurrentRow;
                }
            }
        }
        #endregion

        #region "lvwInfo_DataBindingComplete"
        private void lvwInfo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                lvwInfo.Rows[0].Selected = false;

                foreach (DataGridViewRow row in lvwInfo.Rows)
                {
                    ENReserva entidade = new ENReserva();
                    entidade.cdReserva = Convert.ToInt32(row.Cells["cdReserva"].Value);

                    entidade = NEReserva.Instance.ObterDetalhesReserva(entidade);

                    if (entidade.ocorrencia)
                    {
                        lvwInfo.Rows[row.Index].DefaultCellStyle.BackColor = Color.Firebrick;
                        lvwInfo.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "lvwInfo_ColumnHeaderMouseClick"
        private void lvwInfo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    lvwInfo.Rows[0].Selected = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnPadraoRefresh_Click"
        private void btnPadraoRefresh_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            ConfigurarGrid();
        }

        #endregion

        #endregion
    }
}