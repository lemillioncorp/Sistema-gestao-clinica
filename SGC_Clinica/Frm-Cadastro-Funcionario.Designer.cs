namespace SGC_Clinica
{
    partial class Frm_Cadastro_Funcionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro_Funcionario));
            this.gb_dados = new System.Windows.Forms.GroupBox();
            this.btn_salvar_foto = new System.Windows.Forms.Button();
            this.btn_adicionar_foto = new System.Windows.Forms.Button();
            this.gb_habilitacao = new System.Windows.Forms.GroupBox();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.lb_departamento = new System.Windows.Forms.Label();
            this.txt_formacao = new System.Windows.Forms.TextBox();
            this.lb_formacao = new System.Windows.Forms.Label();
            this.lb_nivel = new System.Windows.Forms.Label();
            this.txt_nivel_academico = new System.Windows.Forms.ComboBox();
            this.gb_funcionario = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.mtb_numero_funcionario = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_bi = new System.Windows.Forms.Label();
            this.txt_bi_funcionario = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_contacto = new System.Windows.Forms.GroupBox();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.lb_endereco = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lb_conta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_genero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_genero_funcionario = new System.Windows.Forms.ComboBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.txt_nome_funcionario = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pn_dados2.SuspendLayout();
            this.pn_botoes.SuspendLayout();
            this.gb_dados.SuspendLayout();
            this.gb_habilitacao.SuspendLayout();
            this.gb_funcionario.SuspendLayout();
            this.gb_contacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_dados2
            // 
            this.pn_dados2.Controls.Add(this.gb_dados);
            this.pn_dados2.Controls.Add(this.gb_funcionario);
            this.pn_dados2.Size = new System.Drawing.Size(1019, 369);
            this.pn_dados2.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_dados2_Paint);
            // 
            // pn_botoes
            // 
            this.pn_botoes.Controls.Add(this.btn_salvar);
            this.pn_botoes.Controls.Add(this.btn_cancelar);
            this.pn_botoes.Controls.Add(this.btn_novo);
            this.pn_botoes.Controls.Add(this.btn_pesquisar);
            this.pn_botoes.Controls.Add(this.btn_editar);
            // 
            // gb_dados
            // 
            this.gb_dados.Controls.Add(this.btn_salvar_foto);
            this.gb_dados.Controls.Add(this.btn_adicionar_foto);
            this.gb_dados.Controls.Add(this.gb_habilitacao);
            this.gb_dados.Dock = System.Windows.Forms.DockStyle.Right;
            this.gb_dados.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_dados.Location = new System.Drawing.Point(493, 0);
            this.gb_dados.Name = "gb_dados";
            this.gb_dados.Size = new System.Drawing.Size(524, 367);
            this.gb_dados.TabIndex = 11;
            this.gb_dados.TabStop = false;
            this.gb_dados.Text = "Dados do Funcionário";
            // 
            // btn_salvar_foto
            // 
            this.btn_salvar_foto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar_foto.Location = new System.Drawing.Point(24, 110);
            this.btn_salvar_foto.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_salvar_foto.Name = "btn_salvar_foto";
            this.btn_salvar_foto.Size = new System.Drawing.Size(105, 45);
            this.btn_salvar_foto.TabIndex = 13;
            this.btn_salvar_foto.Text = "Salvar";
            this.btn_salvar_foto.UseVisualStyleBackColor = true;
            this.btn_salvar_foto.Click += new System.EventHandler(this.btn_salvar_foto_Click);
            // 
            // btn_adicionar_foto
            // 
            this.btn_adicionar_foto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adicionar_foto.Location = new System.Drawing.Point(23, 38);
            this.btn_adicionar_foto.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_adicionar_foto.Name = "btn_adicionar_foto";
            this.btn_adicionar_foto.Size = new System.Drawing.Size(106, 45);
            this.btn_adicionar_foto.TabIndex = 12;
            this.btn_adicionar_foto.Text = "Adicionar Fotografia";
            this.btn_adicionar_foto.UseVisualStyleBackColor = true;
            this.btn_adicionar_foto.Click += new System.EventHandler(this.btn_adicionar_foto_Click);
            // 
            // gb_habilitacao
            // 
            this.gb_habilitacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_habilitacao.Controls.Add(this.txt_departamento);
            this.gb_habilitacao.Controls.Add(this.lb_departamento);
            this.gb_habilitacao.Controls.Add(this.txt_formacao);
            this.gb_habilitacao.Controls.Add(this.lb_formacao);
            this.gb_habilitacao.Controls.Add(this.lb_nivel);
            this.gb_habilitacao.Controls.Add(this.txt_nivel_academico);
            this.gb_habilitacao.Location = new System.Drawing.Point(14, 193);
            this.gb_habilitacao.Name = "gb_habilitacao";
            this.gb_habilitacao.Size = new System.Drawing.Size(446, 158);
            this.gb_habilitacao.TabIndex = 10;
            this.gb_habilitacao.TabStop = false;
            this.gb_habilitacao.Text = "Informação  Habilitações ";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_departamento.Location = new System.Drawing.Point(34, 125);
            this.txt_departamento.MaxLength = 100;
            this.txt_departamento.Multiline = true;
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(378, 20);
            this.txt_departamento.TabIndex = 21;
            // 
            // lb_departamento
            // 
            this.lb_departamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_departamento.AutoSize = true;
            this.lb_departamento.Location = new System.Drawing.Point(35, 107);
            this.lb_departamento.Name = "lb_departamento";
            this.lb_departamento.Size = new System.Drawing.Size(233, 15);
            this.lb_departamento.TabIndex = 20;
            this.lb_departamento.Text = "Departamento ou Sector que vai Trabalhar";
            // 
            // txt_formacao
            // 
            this.txt_formacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_formacao.Location = new System.Drawing.Point(34, 75);
            this.txt_formacao.MaxLength = 200;
            this.txt_formacao.Multiline = true;
            this.txt_formacao.Name = "txt_formacao";
            this.txt_formacao.Size = new System.Drawing.Size(377, 20);
            this.txt_formacao.TabIndex = 19;
            // 
            // lb_formacao
            // 
            this.lb_formacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_formacao.AutoSize = true;
            this.lb_formacao.Location = new System.Drawing.Point(34, 58);
            this.lb_formacao.Name = "lb_formacao";
            this.lb_formacao.Size = new System.Drawing.Size(188, 15);
            this.lb_formacao.TabIndex = 18;
            this.lb_formacao.Text = "Área de Formação do Funcionário";
            // 
            // lb_nivel
            // 
            this.lb_nivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nivel.AutoSize = true;
            this.lb_nivel.Location = new System.Drawing.Point(35, 13);
            this.lb_nivel.Name = "lb_nivel";
            this.lb_nivel.Size = new System.Drawing.Size(180, 15);
            this.lb_nivel.TabIndex = 12;
            this.lb_nivel.Text = "Nível Académico do Funcionário";
            // 
            // txt_nivel_academico
            // 
            this.txt_nivel_academico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nivel_academico.FormattingEnabled = true;
            this.txt_nivel_academico.Location = new System.Drawing.Point(34, 32);
            this.txt_nivel_academico.Name = "txt_nivel_academico";
            this.txt_nivel_academico.Size = new System.Drawing.Size(374, 23);
            this.txt_nivel_academico.TabIndex = 5;
            // 
            // gb_funcionario
            // 
            this.gb_funcionario.Controls.Add(this.dateTimePicker1);
            this.gb_funcionario.Controls.Add(this.button1);
            this.gb_funcionario.Controls.Add(this.mtb_numero_funcionario);
            this.gb_funcionario.Controls.Add(this.button2);
            this.gb_funcionario.Controls.Add(this.lb_bi);
            this.gb_funcionario.Controls.Add(this.txt_bi_funcionario);
            this.gb_funcionario.Controls.Add(this.lb_telefone);
            this.gb_funcionario.Controls.Add(this.label2);
            this.gb_funcionario.Controls.Add(this.gb_contacto);
            this.gb_funcionario.Controls.Add(this.label3);
            this.gb_funcionario.Controls.Add(this.lb_idade);
            this.gb_funcionario.Controls.Add(this.label4);
            this.gb_funcionario.Controls.Add(this.label5);
            this.gb_funcionario.Controls.Add(this.lb_genero);
            this.gb_funcionario.Controls.Add(this.label6);
            this.gb_funcionario.Controls.Add(this.cmb_genero_funcionario);
            this.gb_funcionario.Controls.Add(this.lb_nome);
            this.gb_funcionario.Controls.Add(this.txt_nome_funcionario);
            this.gb_funcionario.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_funcionario.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_funcionario.Location = new System.Drawing.Point(0, 0);
            this.gb_funcionario.Name = "gb_funcionario";
            this.gb_funcionario.Size = new System.Drawing.Size(476, 367);
            this.gb_funcionario.TabIndex = 10;
            this.gb_funcionario.TabStop = false;
            this.gb_funcionario.Text = "Dados do Funcionário";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(887, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 66);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mtb_numero_funcionario
            // 
            this.mtb_numero_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtb_numero_funcionario.Location = new System.Drawing.Point(215, 140);
            this.mtb_numero_funcionario.Mask = "+(244)-000-000-000 | +(244)-000-000-000";
            this.mtb_numero_funcionario.Name = "mtb_numero_funcionario";
            this.mtb_numero_funcionario.Size = new System.Drawing.Size(215, 23);
            this.mtb_numero_funcionario.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(733, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 66);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lb_bi
            // 
            this.lb_bi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_bi.AutoSize = true;
            this.lb_bi.Location = new System.Drawing.Point(218, 68);
            this.lb_bi.Name = "lb_bi";
            this.lb_bi.Size = new System.Drawing.Size(97, 15);
            this.lb_bi.TabIndex = 13;
            this.lb_bi.Text = "BI Do Funcioário";
            // 
            // txt_bi_funcionario
            // 
            this.txt_bi_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_bi_funcionario.Location = new System.Drawing.Point(215, 86);
            this.txt_bi_funcionario.MaxLength = 14;
            this.txt_bi_funcionario.Multiline = true;
            this.txt_bi_funcionario.Name = "txt_bi_funcionario";
            this.txt_bi_funcionario.Size = new System.Drawing.Size(205, 21);
            this.txt_bi_funcionario.TabIndex = 12;
            // 
            // lb_telefone
            // 
            this.lb_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(218, 123);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(141, 15);
            this.lb_telefone.TabIndex = 11;
            this.lb_telefone.Text = "Telefones do Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(184, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "PESQUISAR";
            // 
            // gb_contacto
            // 
            this.gb_contacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_contacto.Controls.Add(this.txt_conta);
            this.gb_contacto.Controls.Add(this.lb_endereco);
            this.gb_contacto.Controls.Add(this.txt_endereco);
            this.gb_contacto.Controls.Add(this.lb_conta);
            this.gb_contacto.Location = new System.Drawing.Point(46, 177);
            this.gb_contacto.Name = "gb_contacto";
            this.gb_contacto.Size = new System.Drawing.Size(350, 180);
            this.gb_contacto.TabIndex = 9;
            this.gb_contacto.TabStop = false;
            this.gb_contacto.Text = "Informação sobre Endereço e Contacto";
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(22, 65);
            this.txt_conta.MaxLength = 80;
            this.txt_conta.Multiline = true;
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(307, 20);
            this.txt_conta.TabIndex = 19;
            // 
            // lb_endereco
            // 
            this.lb_endereco.AutoSize = true;
            this.lb_endereco.Location = new System.Drawing.Point(25, 95);
            this.lb_endereco.Name = "lb_endereco";
            this.lb_endereco.Size = new System.Drawing.Size(202, 15);
            this.lb_endereco.TabIndex = 12;
            this.lb_endereco.Text = "Endereço ou Morada do Funcionario";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(22, 113);
            this.txt_endereco.MaxLength = 120;
            this.txt_endereco.Multiline = true;
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(307, 20);
            this.txt_endereco.TabIndex = 11;
            // 
            // lb_conta
            // 
            this.lb_conta.AutoSize = true;
            this.lb_conta.Location = new System.Drawing.Point(24, 47);
            this.lb_conta.Name = "lb_conta";
            this.lb_conta.Size = new System.Drawing.Size(226, 15);
            this.lb_conta.TabIndex = 10;
            this.lb_conta.Text = " Email ou Conta do Facebook  ou Watsap";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(897, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CANCELAR";
            // 
            // lb_idade
            // 
            this.lb_idade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_idade.AutoSize = true;
            this.lb_idade.Location = new System.Drawing.Point(51, 123);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(103, 15);
            this.lb_idade.TabIndex = 8;
            this.lb_idade.Text = "Idade Funcionário";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(749, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "SALVAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(333, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ALTERAR";
            // 
            // lb_genero
            // 
            this.lb_genero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_genero.AutoSize = true;
            this.lb_genero.Location = new System.Drawing.Point(51, 67);
            this.lb_genero.Name = "lb_genero";
            this.lb_genero.Size = new System.Drawing.Size(46, 15);
            this.lb_genero.TabIndex = 6;
            this.lb_genero.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "INSERIR";
            // 
            // cmb_genero_funcionario
            // 
            this.cmb_genero_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_genero_funcionario.FormattingEnabled = true;
            this.cmb_genero_funcionario.Items.AddRange(new object[] {
            "Não Especificado",
            "Masculino ",
            "Femenino"});
            this.cmb_genero_funcionario.Location = new System.Drawing.Point(48, 85);
            this.cmb_genero_funcionario.Name = "cmb_genero_funcionario";
            this.cmb_genero_funcionario.Size = new System.Drawing.Size(160, 23);
            this.cmb_genero_funcionario.TabIndex = 5;
            // 
            // lb_nome
            // 
            this.lb_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(49, 19);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(107, 15);
            this.lb_nome.TabIndex = 4;
            this.lb_nome.Text = "Nome Funcionario";
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nome_funcionario.Location = new System.Drawing.Point(46, 37);
            this.txt_nome_funcionario.MaxLength = 80;
            this.txt_nome_funcionario.Multiline = true;
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(300, 20);
            this.txt_nome_funcionario.TabIndex = 3;
            // 
            // btn_editar
            // 
            this.btn_editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_editar.Image")));
            this.btn_editar.Location = new System.Drawing.Point(494, 14);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(87, 66);
            this.btn_editar.TabIndex = 15;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(177, 14);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(87, 66);
            this.btn_pesquisar.TabIndex = 14;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.Image")));
            this.btn_novo.Location = new System.Drawing.Point(34, 14);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(87, 66);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(636, 14);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(87, 66);
            this.btn_salvar.TabIndex = 16;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(779, 14);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(87, 66);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Frm_Cadastro_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1013, 552);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Frm_Cadastro_Funcionario";
            this.pn_dados2.ResumeLayout(false);
            this.pn_botoes.ResumeLayout(false);
            this.gb_dados.ResumeLayout(false);
            this.gb_habilitacao.ResumeLayout(false);
            this.gb_habilitacao.PerformLayout();
            this.gb_funcionario.ResumeLayout(false);
            this.gb_funcionario.PerformLayout();
            this.gb_contacto.ResumeLayout(false);
            this.gb_contacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_dados;
        private System.Windows.Forms.GroupBox gb_habilitacao;
        private System.Windows.Forms.Label lb_formacao;
        private System.Windows.Forms.Label lb_nivel;
        private System.Windows.Forms.GroupBox gb_funcionario;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.GroupBox gb_contacto;
        private System.Windows.Forms.Label lb_endereco;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lb_conta;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.Label lb_genero;
        private System.Windows.Forms.ComboBox cmb_genero_funcionario;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox txt_nome_funcionario;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.Label lb_departamento;
        private System.Windows.Forms.TextBox txt_formacao;
        private System.Windows.Forms.Label lb_bi;
        private System.Windows.Forms.TextBox txt_bi_funcionario;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.Button btn_adicionar_foto;
        private System.Windows.Forms.MaskedTextBox mtb_numero_funcionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_novo;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar_foto;
        private System.Windows.Forms.ComboBox txt_nivel_academico;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
