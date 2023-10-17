﻿using MySql.Data.MySqlClient;
using System;
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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Turma exc = new Turma();
            MySqlDataReader r = exc.consultarTodasTurmas();
            while (r.Read())
            {
                cbxTurma.Items.Add(r["nomeTurma"].ToString());                    
            }
            DAO_Conexao.con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((cbxTurma.Text != "")&&(cbxDiaSemana.Text != "")&&(cbxHora.Text != ""))
            {
                Turma turma = new Turma();
                turma.excluirTurma(turma.selecionaIdTurma(cbxTurma.Text),cbxDiaSemana.Text,cbxHora.Text);
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione uma opção para excluir!");
            }
        }

        private void cbxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDiaSemana.Items.Clear();  
            cbxDiaSemana.Enabled = true;
            Turma exc = new Turma();
            MySqlDataReader r = exc.consultar(cbxTurma.Text);
            while (r.Read())
            {
                cbxDiaSemana.Items.Add(r["diasemanaTurma"].ToString());
            }
            if(cbxDiaSemana.Items.Count == 0)
            {
                cbxDiaSemana.Enabled = false;
            }
            
            DAO_Conexao.con.Close();
                       
            
        }

        private void cbxHora_Click(object sender, EventArgs e)
        {

        }

        private void cbxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxHora.Enabled = true;
            Turma exc = new Turma();
            MySqlDataReader r = exc.consultarTurma01(cbxDiaSemana.Text, cbxTurma.Text);
            while (r.Read())
            {
                cbxHora.Items.Add(r["horaTurma"].ToString());
            }
            DAO_Conexao.con.Close();
        }
    }
}
