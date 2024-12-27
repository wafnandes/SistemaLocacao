using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirassoisLocacoes
{
    public partial class frmSplash : Form
    {
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            try
            {
                CarregaBarra();

                timer.Interval = 100;
                timer.Tick += timer_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                timer.Stop();
                throw ex;
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            IniciaSistema();
            pbCarrega.PerformStep();
            AbreTelaPrincipal();
        }

        private void IniciaSistema()
        {
            System.Diagnostics.Process[] listaprocessos = System.Diagnostics.Process.GetProcessesByName("GirassoisLocacoes");

            if (listaprocessos.Length > 1)
                Environment.Exit(0);

            pbCarrega.PerformStep();
            //FormHelper.Instance.LogSistema("Inicia sistema");
            pbCarrega.PerformStep();
        }

        public void AbreTelaPrincipal()
        {
            try
            {
                Task.Delay(5000);
                timer.Interval = 100;
                pbCarrega.PerformStep();
                Thread Principal = new Thread(new ThreadStart(IniciaPrincipal));
                Principal.SetApartmentState(ApartmentState.STA);
                Principal.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                timer.Stop();
                throw ex;
            }
        }

        public void CarregaBarra()
        {
            while (pbCarrega.Value < 100)
            {
                pbCarrega.Maximum = 100;
                pbCarrega.Step = 20;
                pbCarrega.PerformStep();
            }
        }

        public static void IniciaPrincipal()
        {
            Application.Run(new frmPrincipal());
        }
    }
}
