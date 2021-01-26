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
    public partial class modeloCadastro : Form
    {
        int id_funcionario;
        public modeloCadastro( )
        {
            InitializeComponent();
        }
        public void AlteraBotoes(int op)
        {
            pn_dados1.Enabled = true;
            pn_dados2.Enabled = true;
            //tabPage1.Enabled = false;
           
           


            if (op == 1)
            {
              
                pn_dados1.Visible = true;
                pn_dados1.Enabled = true;
            }
            if (op == 2)
            {
                
                pn_dados2.Enabled = true;
              

            }
            if (op == 3)
            {
               
            }
        }


        private void modeloCadastro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);

        }

        private void pn_dados2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_dados1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_botoes_Paint(object sender, PaintEventArgs e)
        {

        }
        //===============================================================
        private void btn_fechar_janela_Click(object sender, EventArgs e)
        {
            
            Close();
            Dispose();
            Inicial_Clinica frm = new Inicial_Clinica();
        }
        //===============================================================
        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(2);
            //Abrir um form para Adicionar





        }
        //===============================================================
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(3);
        }
        //===============================================================
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }
        //===============================================================
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);

            //Gravar ficheiro no Banco de Dados

            #region Novo FUNCIONARIO
           
            #endregion



        }
        //===============================================================
        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }
        //===============================================================
        private void btn_Inicial_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            Inicial_Clinica frm = new Inicial_Clinica();
        }
        //===============================================================
    }
}
