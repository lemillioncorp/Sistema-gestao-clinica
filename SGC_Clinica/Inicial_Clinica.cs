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
    public partial class Inicial_Clinica : Form
    {
        
        public Inicial_Clinica( )
        {
           
            InitializeComponent();


        }
        //=======================================================
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //=====================DESEJA SAIR DA APLICATION NÂO REtorna
            if (MessageBox.Show("Deseja Sair da Aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            //===============DEseja sair da aplication? Sim e Sai mesmo da Aplicatio
            Application.Exit();

        }
        //=====================================================================
        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }
        //=====================================================================
        private void toolStripSplitButton8_ButtonClick(object sender, EventArgs e)
        {

        }
        //=====================================================================
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Frm_Exame_simples frm = new Frm_Exame_simples();
            frm.ShowDialog();
            frm.Dispose();


        }
        //=====================================================================
        private void itemMenuCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }
        //=====================================================================
        private void itemMenuExel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }
        //=====================================================================
        private void itemMenuWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }
        //=====================================================================
        private void toolStripSplitButton9_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            Frm_Configuracao_BD FrmBD = new Frm_Configuracao_BD();
            FrmBD.ShowDialog();
            FrmBD.Dispose();
        }
        //=====================================================================
        private void Inicial_Clinica_Load(object sender, EventArgs e)
        {


        }
        //=====================================================================
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Frm_Cadastro_Funcionario funcionario = new Frm_Cadastro_Funcionario();
            funcionario.ShowDialog();
            funcionario.Dispose();
        }
        //=====================================================================
        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Frm_Consulta consulta = new Frm_Consulta();
            consulta.ShowDialog();
            consulta.Dispose();
        }
        //=====================================================================
        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Frm_Consulta_cargo consulta = new Frm_Consulta_cargo();
            consulta.ShowDialog();
            consulta.Dispose();
        }
        //=====================================================================
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void Inicial_Clinica_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void Inicial_Clinica_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}
