﻿
namespace Estudio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoEmTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.consultarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.modalidadeToolStripMenuItem,
            this.turmaToolStripMenuItem,
            this.cadastrarAlunoEmTurmaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.cadastrarLoginToolStripMenuItem,
            this.consultarAlunoToolStripMenuItem,
            this.atualizarAlunoToolStripMenuItem,
            this.excluirAlunoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoToolStripMenuItem_Click);
            // 
            // cadastrarLoginToolStripMenuItem
            // 
            this.cadastrarLoginToolStripMenuItem.Name = "cadastrarLoginToolStripMenuItem";
            this.cadastrarLoginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cadastrarLoginToolStripMenuItem.Text = "Cadastrar Login";
            this.cadastrarLoginToolStripMenuItem.Click += new System.EventHandler(this.cadastrarLoginToolStripMenuItem_Click);
            // 
            // atualizarAlunoToolStripMenuItem
            // 
            this.atualizarAlunoToolStripMenuItem.Name = "atualizarAlunoToolStripMenuItem";
            this.atualizarAlunoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.atualizarAlunoToolStripMenuItem.Text = "Atualizar Aluno";
            this.atualizarAlunoToolStripMenuItem.Click += new System.EventHandler(this.atualizarAlunoToolStripMenuItem_Click);
            // 
            // excluirAlunoToolStripMenuItem
            // 
            this.excluirAlunoToolStripMenuItem.Name = "excluirAlunoToolStripMenuItem";
            this.excluirAlunoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.excluirAlunoToolStripMenuItem.Text = "Excluir Aluno";
            this.excluirAlunoToolStripMenuItem.Click += new System.EventHandler(this.excluirAlunoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_2);
            // 
            // modalidadeToolStripMenuItem
            // 
            this.modalidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarModalidadeToolStripMenuItem,
            this.consultarModalidadeToolStripMenuItem,
            this.atualizarModalidadeToolStripMenuItem,
            this.excluirModalidadeToolStripMenuItem});
            this.modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            this.modalidadeToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.modalidadeToolStripMenuItem.Text = "Modalidade";
            // 
            // cadastrarModalidadeToolStripMenuItem
            // 
            this.cadastrarModalidadeToolStripMenuItem.Name = "cadastrarModalidadeToolStripMenuItem";
            this.cadastrarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.cadastrarModalidadeToolStripMenuItem.Text = "Cadastrar Modalidade";
            this.cadastrarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.cadastrarModalidadeToolStripMenuItem_Click);
            // 
            // consultarModalidadeToolStripMenuItem
            // 
            this.consultarModalidadeToolStripMenuItem.Name = "consultarModalidadeToolStripMenuItem";
            this.consultarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.consultarModalidadeToolStripMenuItem.Text = "Consultar Modalidade";
            this.consultarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.consultarModalidadeToolStripMenuItem_Click);
            // 
            // atualizarModalidadeToolStripMenuItem
            // 
            this.atualizarModalidadeToolStripMenuItem.Name = "atualizarModalidadeToolStripMenuItem";
            this.atualizarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.atualizarModalidadeToolStripMenuItem.Text = "Atualizar Modalidade";
            this.atualizarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.atualizarModalidadeToolStripMenuItem_Click);
            // 
            // excluirModalidadeToolStripMenuItem
            // 
            this.excluirModalidadeToolStripMenuItem.Name = "excluirModalidadeToolStripMenuItem";
            this.excluirModalidadeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.excluirModalidadeToolStripMenuItem.Text = "Excluir Modalidade";
            this.excluirModalidadeToolStripMenuItem.Click += new System.EventHandler(this.excluirModalidadeToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caToolStripMenuItem,
            this.consultarTurmaToolStripMenuItem,
            this.atualizarTurmaToolStripMenuItem,
            this.excluirTurmaToolStripMenuItem});
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.turmaToolStripMenuItem.Text = "Turma";
            // 
            // caToolStripMenuItem
            // 
            this.caToolStripMenuItem.Name = "caToolStripMenuItem";
            this.caToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.caToolStripMenuItem.Text = "Cadastrar Turma";
            this.caToolStripMenuItem.Click += new System.EventHandler(this.caToolStripMenuItem_Click);
            // 
            // consultarTurmaToolStripMenuItem
            // 
            this.consultarTurmaToolStripMenuItem.Name = "consultarTurmaToolStripMenuItem";
            this.consultarTurmaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.consultarTurmaToolStripMenuItem.Text = "Consultar Turma";
            this.consultarTurmaToolStripMenuItem.Click += new System.EventHandler(this.consultarTurmaToolStripMenuItem_Click);
            // 
            // atualizarTurmaToolStripMenuItem
            // 
            this.atualizarTurmaToolStripMenuItem.Name = "atualizarTurmaToolStripMenuItem";
            this.atualizarTurmaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.atualizarTurmaToolStripMenuItem.Text = "Atualizar Turma";
            this.atualizarTurmaToolStripMenuItem.Click += new System.EventHandler(this.atualizarTurmaToolStripMenuItem_Click);
            // 
            // excluirTurmaToolStripMenuItem
            // 
            this.excluirTurmaToolStripMenuItem.Name = "excluirTurmaToolStripMenuItem";
            this.excluirTurmaToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.excluirTurmaToolStripMenuItem.Text = "Excluir Turma";
            this.excluirTurmaToolStripMenuItem.Click += new System.EventHandler(this.excluirTurmaToolStripMenuItem_Click);
            // 
            // cadastrarAlunoEmTurmaToolStripMenuItem
            // 
            this.cadastrarAlunoEmTurmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.cadastrarAlunoEmTurmaToolStripMenuItem.Name = "cadastrarAlunoEmTurmaToolStripMenuItem";
            this.cadastrarAlunoEmTurmaToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.cadastrarAlunoEmTurmaToolStripMenuItem.Text = "Aluno em Turma";
            this.cadastrarAlunoEmTurmaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunoEmTurmaToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(201, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(595, 324);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Validação";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 161);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(289, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "1111";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "gjm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // consultarAlunoToolStripMenuItem
            // 
            this.consultarAlunoToolStripMenuItem.Name = "consultarAlunoToolStripMenuItem";
            this.consultarAlunoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarAlunoToolStripMenuItem.Text = "Consultar Aluno";
            this.consultarAlunoToolStripMenuItem.Click += new System.EventHandler(this.consultarAlunoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Estúdio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoEmTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlunoToolStripMenuItem;
    }
}

