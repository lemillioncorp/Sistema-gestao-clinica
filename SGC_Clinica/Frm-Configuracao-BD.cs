using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlServerCe;
using MetroFramework;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGC_Clinica
{
    public partial class Frm_Configuracao_BD : Form
    {
        public Frm_Configuracao_BD()
        {
            InitializeComponent();
        }

        private void btn_fechar_janela_Click(object sender, EventArgs e)
        {
        
            btn_fechar_janela.Refresh();
            this.Close();
        }

        private void Frm_Configuracao_BD_Load(object sender, EventArgs e)
        {

            


        }

        private void btn_ligar_Click(object sender, EventArgs e)
        {

        }

       

     /*   private void ckb_ver_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_ver.Checked == false)
            {
                this.txt_senha.UseSystemPasswordChar = true;

            }
            else
            {

                this.txt_senha.UseSystemPasswordChar = false;
            }
        }

        private void lbl_inserir_Click(object sender, EventArgs e)
        {

        }
        */
    }
}

