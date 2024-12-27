using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GirassoisLocacoes.Commons;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Negocio;

namespace GirassoisLocacoes.Forms
{
    public partial class frmFinalizarReserva : Form
    {
        #region "Variáveis"
        DataGridViewRow row = null;
        #endregion

        #region "Construtor"
        public frmFinalizarReserva()
        {
            InitializeComponent();
        }

        private void frmFinalizarReserva_Load(object sender, EventArgs e)
        {
            Limpar();
            btnPadraoExcluir.Visible = false;
            btnPadraoNovo.Visible = false;
        }
        #endregion

        #region "Métodos"

        #region "CarregarGrid"
        private void CarregarGrid()
        {
            try
            {
                ENReserva entidade = new ENReserva();
                entidade.idFinalizado = false;

                lvwInfo.Columns.Clear();
                Cursor = Cursors.WaitCursor;

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

                lvwInfo.Columns["cdReserva"].HeaderText = "Código";
                lvwInfo.Columns["cdReserva"].Width = 50;
                lvwInfo.Columns["cdReserva"].ReadOnly = true;
                lvwInfo.Columns["cdReserva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                lvwInfo.Columns["nmCli"].HeaderText = "Cliente";
                lvwInfo.Columns["nmCli"].Width = 385;
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

                var col = new DataGridViewCheckBoxColumn();
                col.Name = "idFinalizado";
                col.HeaderText = "Finalizar";
                col.FalseValue = 0;
                col.TrueValue = 1;
                col.CellTemplate.Value = false;
                col.CellTemplate.Style.NullValue = false;
                col.Width = 70;
                lvwInfo.Columns.Insert(5, col);

                lvwInfo.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (lvwInfo.Rows.Count > 6)
                    lvwInfo.Columns["nmCli"].Width = 369;
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
        }
        #endregion

        #region "Gravar"
        private void Gravar()
        {
            try
            {
                ENReserva entidade = new ENReserva();

                if (!ValidaDados())
                    return;

                if (FormHelper.Instance.Pergunta("Deseja finalizar a(s) reserva(s) selecionada(s)?", false) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in lvwInfo.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["idFinalizado"].Value))
                        {
                            entidade.cdReserva = Convert.ToInt32(row.Cells["cdReserva"].Value);
                            entidade.idFinalizado = Convert.ToBoolean(row.Cells["idFinalizado"].Value);

                            if (FormHelper.Instance.Pergunta("Deseja finalizar a reserva " + row.Cells["cdReserva"].Value + "?", false) == DialogResult.Yes)
                                NEReserva.Instance.FinalizarReserva(entidade);
                        }
                    }

                    FormHelper.Instance.Informacao("Reserva(s) finalizada(s) com sucesso!");
                }

                Limpar();
            }
            catch(Exception ex)
            {
                throw ex;
            }            
        }
        #endregion

        #region "ValidaDados"
        private bool ValidaDados()
        {
            int selecionadas = 0;
            foreach(DataGridViewRow row in lvwInfo.Rows)
            {
                if (Convert.ToBoolean(row.Cells["idFinalizado"].Value))
                    selecionadas++;
            }

            if(selecionadas == 0)
            {
                FormHelper.Instance.Advertencia("Selecione ao menos uma reserva para finalizar!");
                return false;
            }

            return true;
        }
        #endregion

        #endregion

        #region "Eventos"

        #region "btnPadraoConfirmar_Click"
        private void btnPadraoConfirmar_Click(object sender, EventArgs e)
        {
            Gravar();
        }
        #endregion

        #region "lvwInfo_CellClick"
        private void lvwInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    if (e.ColumnIndex == 0 || e.ColumnIndex == 5)
                        lvwInfo.SelectedRows[0].Cells["idFinalizado"].Value = Convert.ToBoolean(lvwInfo.SelectedRows[0].Cells["idFinalizado"].Value) == true ? false : true;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            } 
        }
        #endregion

        #region "frmFinalizarReserva_KeyDown"
        private void frmFinalizarReserva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
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

        #region "btnPadraoRefresh_Click"
        private void btnPadraoRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                Limpar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        #region "mnuEditarReserva_Click"
        private void mnuEditarReserva_Click(object sender, EventArgs e)
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

                    frmReserva frmReserva = new frmReserva(entidade, itens);
                    this.Enabled = false;
                    frmReserva.ShowDialog();
                    frmReserva.BringToFront();
                    this.Enabled = true;
                }
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
