using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GirassoisLocacoes.Entidades;
using GirassoisLocacoes.Forms;
using GirassoisLocacoes.Negocio;
using PdfSharp.Drawing.Layout;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Data.Common;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using PdfSharp.Pdf.Advanced;

namespace GirassoisLocacoes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmCliente));         
        }

        private void abreTela(Type form)
        { 
            foreach(Form tela in Application.OpenForms)
            {
                if (tela.GetType().Equals(form))
                    return;
            }
            ENLogSistema log = new ENLogSistema();

            log.comando = "Abre tela " + form.Name;
            NELogSistema.Instance.Gravar(log);

            Form frm = null;
            frm = new Form();
            frm = (Form)Activator.CreateInstance(form);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void espaçoáreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmEspaco));
        }

        private void parâmetrosDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmParametros));
        }

        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmReserva));
        }

        private void finalizarReservaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmFinalizarReserva));
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmHistorico));
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                #if !DEBUG
                Autenticacao();
                #endif

                DataSet ds = new DataSet();

                ds = NELogSistema.Instance.ObterInfoDatabase();

                toolStripNomeBase.Text = "Ambiente: " + ds.Tables[0].Rows[0]["DB_NAME"].ToString();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void agendamentoDePreçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmAgendamentoPrecos));
        }

        private void Autenticacao()
        {
            try
            {
                frmLoginSenha formSenha = new frmLoginSenha(this.Width, this.Height);

                formSenha.ShowDialog(this);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void cadastroDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmEstoque));
        }

        private void btnNovaReserva_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmReserva));
        }

        private void btnFinalizarReserva_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmFinalizarReserva));
        }

        private void históricoDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abreTela(typeof(frmHistorico));
        }

        private void btnEstoqueNaData_Click(object sender, EventArgs e)
        {

        }
    }
}
