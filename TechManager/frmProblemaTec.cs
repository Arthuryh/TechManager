﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace TechManager
{
    public partial class frmProblemaTec : Form
    {
        public frmProblemaTec()
        {
            InitializeComponent();
        }
        probBll bll = new probBll();
        probDto dtoVar = new probDto();


        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaTecnico adv = new frmAdvertenciaTecnico();
            adv.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPerfilTec tec = new frmPerfilTec();
            tec.Show();
        }

        private void frmProblemaTec_Load(object sender, EventArgs e)
        {
            carregaGrid();
            lblNome.Text = information.nome;
            
        }

        

        private void dgvProb_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


            int sel = dgvProb.CurrentRow.Index;

            if (Convert.ToBoolean(dgvProb["check", sel].Value) == true)
            {
                dgvProb.CurrentRow.DefaultCellStyle.BackColor = Color.ForestGreen;
                dtoVar.Check = "1";
                dtoVar.idProb = Convert.ToInt32(dgvProb["id", sel].Value);
               
            }


            else
            {
                dgvProb.CurrentRow.DefaultCellStyle.BackColor = Color.Maroon;
                dtoVar.Check = "0";
                dtoVar.idProb = Convert.ToInt32(dgvProb["id", sel].Value);


            }
            try
                {
                    try
                    {
                        probBll bll = new probBll();
                        bll.alteraSituacao(dtoVar);
                    }
                    catch (Exception erro)
                    {
                    MessageBox.Show("Erro Inexperado, contate o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
                catch (Exception ex)
                 {
                MessageBox.Show("Erro Inexperado, contate o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    

               

        }
        private void carregaGrid()
        {
            
            dgvProb.AutoGenerateColumns = false;
            
            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().listarTec();
                dgvProb.DataSource = ListDto;

                CurrencyManager cm = (CurrencyManager)BindingContext[dgvProb.DataSource];
                cm.EndCurrentEdit();
                cm.ResumeBinding();
                cm.SuspendBinding();

                foreach (DataGridViewRow row in dgvProb.Rows)
                {
                    


                    if (Convert.ToString(row.Cells["cheka"].Value) == "")
                    {
                        row.Visible = true;

                    }
                    else
                    {
                        row.Visible = false;
                    }





                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro Inexperado, contate o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        
    }
        private void dgvProb_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
