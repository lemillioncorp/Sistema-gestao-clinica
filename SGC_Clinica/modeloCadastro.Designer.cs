﻿namespace SGC_Clinica
{
    partial class modeloCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modeloCadastro));
            this.pn_dados2 = new System.Windows.Forms.Panel();
            this.pn_dados1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.btn_fechar_janela = new System.Windows.Forms.Button();
            this.btn_word_ferramenta = new System.Windows.Forms.Button();
            this.btn_Inicial = new System.Windows.Forms.Button();
            this.pn_botoes = new System.Windows.Forms.Panel();
            this.pn_dados1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_dados2
            // 
            this.pn_dados2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_dados2.BackColor = System.Drawing.Color.GhostWhite;
            this.pn_dados2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_dados2.Location = new System.Drawing.Point(-2, 95);
            this.pn_dados2.Name = "pn_dados2";
            this.pn_dados2.Size = new System.Drawing.Size(1026, 369);
            this.pn_dados2.TabIndex = 4;
            this.pn_dados2.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_dados2_Paint);
            // 
            // pn_dados1
            // 
            this.pn_dados1.BackColor = System.Drawing.Color.ForestGreen;
            this.pn_dados1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_dados1.Controls.Add(this.label1);
            this.pn_dados1.Controls.Add(this.panel1);
            this.pn_dados1.Controls.Add(this.btn_fechar_janela);
            this.pn_dados1.Controls.Add(this.btn_word_ferramenta);
            this.pn_dados1.Controls.Add(this.btn_Inicial);
            this.pn_dados1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_dados1.Location = new System.Drawing.Point(0, 0);
            this.pn_dados1.Name = "pn_dados1";
            this.pn_dados1.Size = new System.Drawing.Size(1013, 102);
            this.pn_dados1.TabIndex = 3;
            this.pn_dados1.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_dados1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Software Gestão de Clínica";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pb_icon);
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Location = new System.Drawing.Point(837, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(113, 89);
            this.panel1.TabIndex = 11;
            // 
            // pb_icon
            // 
            this.pb_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_icon.BackColor = System.Drawing.Color.White;
            this.pb_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_icon.BackgroundImage")));
            this.pb_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_icon.Cursor = System.Windows.Forms.Cursors.No;
            this.pb_icon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pb_icon.ErrorImage")));
            this.pb_icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_icon.InitialImage")));
            this.pb_icon.Location = new System.Drawing.Point(2, 0);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(109, 89);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_icon.TabIndex = 12;
            this.pb_icon.TabStop = false;
            // 
            // btn_fechar_janela
            // 
            this.btn_fechar_janela.Location = new System.Drawing.Point(173, -1);
            this.btn_fechar_janela.Name = "btn_fechar_janela";
            this.btn_fechar_janela.Size = new System.Drawing.Size(87, 39);
            this.btn_fechar_janela.TabIndex = 10;
            this.btn_fechar_janela.Text = "&Fechar";
            this.btn_fechar_janela.UseVisualStyleBackColor = true;
            this.btn_fechar_janela.Click += new System.EventHandler(this.btn_fechar_janela_Click);
            // 
            // btn_word_ferramenta
            // 
            this.btn_word_ferramenta.Location = new System.Drawing.Point(86, -1);
            this.btn_word_ferramenta.Name = "btn_word_ferramenta";
            this.btn_word_ferramenta.Size = new System.Drawing.Size(87, 39);
            this.btn_word_ferramenta.TabIndex = 9;
            this.btn_word_ferramenta.Text = "Word";
            this.btn_word_ferramenta.UseVisualStyleBackColor = true;
            this.btn_word_ferramenta.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_Inicial
            // 
            this.btn_Inicial.Location = new System.Drawing.Point(-1, -1);
            this.btn_Inicial.Name = "btn_Inicial";
            this.btn_Inicial.Size = new System.Drawing.Size(87, 39);
            this.btn_Inicial.TabIndex = 8;
            this.btn_Inicial.Text = "&Inicial";
            this.btn_Inicial.UseVisualStyleBackColor = true;
            this.btn_Inicial.Click += new System.EventHandler(this.btn_Inicial_Click);
            // 
            // pn_botoes
            // 
            this.pn_botoes.BackColor = System.Drawing.Color.ForestGreen;
            this.pn_botoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_botoes.Location = new System.Drawing.Point(0, 459);
            this.pn_botoes.Name = "pn_botoes";
            this.pn_botoes.Size = new System.Drawing.Size(1013, 93);
            this.pn_botoes.TabIndex = 2;
            this.pn_botoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_botoes_Paint);
            // 
            // modeloCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 552);
            this.Controls.Add(this.pn_dados2);
            this.Controls.Add(this.pn_botoes);
            this.Controls.Add(this.pn_dados1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "modeloCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modeloCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.modeloCadastro_Load);
            this.pn_dados1.ResumeLayout(false);
            this.pn_dados1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pn_dados2;
        protected System.Windows.Forms.Panel pn_dados1;
        private System.Windows.Forms.Button btn_fechar_janela;
        private System.Windows.Forms.Button btn_word_ferramenta;
        private System.Windows.Forms.Button btn_Inicial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel pn_botoes;
    }
}