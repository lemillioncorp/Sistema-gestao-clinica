using MySql.Data.MySqlClient;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
       
        int count;
      
        MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=clinica");

            string usuario, senha; 

          
        private void button1_Click(object sender, EventArgs e)
        { 
             usuario = txtUsuario.Text;
            senha = txtSenha.Text;

          
                string query = " select * from usuario where nome= '" + txtUsuario.Text + "' && senha= ' " + txtSenha.Text + " ' ";
                MySqlDataAdapter data = new MySqlDataAdapter(query, conexao);

                DataTable dt = new DataTable();
                data.Fill(dt);
                if (dt.Rows.Count==1)
                {
                    label3.Text = "BEM VINDO AO SISTEMA DE GESTÃO DE CLINICA";
                   
                }
                else
                {
                    label3.Text = "Login Invalido";
                }
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
