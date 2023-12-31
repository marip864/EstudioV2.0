﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudio
{
    public partial class Form3 : Form
    {
        int opcao = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text, txtNome.Text, txtEnd.Text, txtNumero.Text, txtBairro.Text, txtCompl.Text, txtCEP.Text, txtCidade.Text, txtEstado.Text, txtTel.Text, txtEmail.Text);
            if(aluno.verificaCPF())
            {
                if (aluno.cadastrarAluno())
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Erro no cadastro!");
            }            
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtCPF.Text);
            if(e.KeyChar==13)
            {
                    if (aluno.consultarAluno())
                    {
                        MessageBox.Show("CPF já cadastrado!");
                        txtCPF.Text = "";
                    }
                    else
                    {
                        txtNome.Enabled = true;
                        txtEnd.Enabled = true;
                        txtNumero.Enabled = true;
                        txtBairro.Enabled = true;
                        txtCompl.Enabled = true;
                        txtCEP.Enabled = true;
                        txtCidade.Enabled = true;
                        txtEstado.Enabled = true;
                        txtTel.Enabled = true;
                        txtEmail.Enabled = true;
                        button1.Enabled = true;
                        txtNome.Focus();
                    }
                
                DAO_Conexao.con.Close();
            }
        }

        
    }
}
