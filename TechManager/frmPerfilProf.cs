﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace TechManager
{
    public partial class frmPerfilProf : Form
    {
        
        public frmPerfilProf()
        {
            

            InitializeComponent();
        }



        private void frmPerfilProf_Load(object sender, EventArgs e)
        {
          
            notifyIcon1.Visible = false;
            lblNome.Text = information.nome;
            pcbFotoProf.ImageLocation = information.foto;
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            frmProblemaProf prob = new frmProblemaProf();
            prob.ShowDialog();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmJustificativaProf adv = new frmJustificativaProf();
            adv.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void pcbFotoProf_Click(object sender, EventArgs e)
        {
            frmAlteraPerfil alteraPerfil = new frmAlteraPerfil();
            alteraPerfil.ShowDialog();
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            frmHistorico historico = new frmHistorico();
            historico.ShowDialog();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void frmPerfilProf_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cps.sp.gov.br/category/etec/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }
    }
}
