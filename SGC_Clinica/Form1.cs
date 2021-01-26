using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Clinica
{
    public partial class span : Form
    {
        public span()
        {
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value < 100)
            {
                this.progressBar1.Value = progressBar1.Value +2;

            }

            else
            {
                timer1.Enabled = false;
                this.Hide();
                Inicial_Clinica home = new Inicial_Clinica();
                home.ShowDialog();
               home.Dispose();
            }
        }

        private void span_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void lba_ini_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

