using System;
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
using MySql.Data.MySqlClient;

namespace TechManager
{
    public partial class frmLogin : Form
    {
       
        usuarioDTO dtovar = new usuarioDTO();
        usuarioBLL usuarioBLL = new usuarioBLL();


        public frmLogin()
        {
            InitializeComponent();
        }
        int X = 0;
        int Y = 0;

        private void btnSeleciona()
        {

        }


        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUser.Text == "Usuário")
            {
                txtUser.Text = "";
            }
        }

        private void buni_MouseClick(object sender, MouseEventArgs e)
        {
           


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
           
        }

        private void swiMostrar_OnValueChange(object sender, EventArgs e)
        {

            if (txtSenha.PasswordChar == char.Parse("*"))
            {
                txtSenha.PasswordChar = char.Parse("\0");
                txtSenha.Focus();
            }
            else
            {
                txtSenha.PasswordChar = char.Parse("*");
                txtSenha.Focus();
            }
        }
        #region mover
        private void segura(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void arrasta(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            segura(e);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            arrasta(e);
        }


        private void pnlLogo_MouseMove(object sender, MouseEventArgs e)
        {
            arrasta(e);
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            segura(e);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            segura(e);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            arrasta(e);
        }
        #endregion



        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
                btnEntrar.ForeColor = Color.Black;
                return;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           

            dtovar.login = txtUser.Text;
            dtovar.senha = txtSenha.Text;

            
            
            try
            {
                List<usuarioDTO> ListDto = new List<usuarioDTO>();
                //ListDto = new usuarioBLL().validar(dtovar);
                ListDto.Add(new usuarioDTO()
                {
                    id = 1,
                    nome = "Dalmasio",
                    aula = "Aula 1",
                    tipo = 1
                });
                if (ListDto.Count > 0)
                {
                    information.id = dtovar.id;
                    information.nome = dtovar.nome;
                    information.foto = dtovar.foto;
                    information.aula = dtovar.aula;
                    information.tipo = dtovar.tipo;

                   

                    if (dtovar.tipo == 1)
                    {
                        frmPerfilProf prof = new frmPerfilProf();
                        prof.Show();
                        this.Hide();

                    }
                    else if (dtovar.tipo == 2)
                    {
                        frmPerfilTec prof = new frmPerfilTec();
                        prof.Show();
                        this.Hide();
                    }
                    else
                    {
                        frmPerfilAdm prof = new frmPerfilAdm();
                        prof.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuário, senha ou  incorretos","Erro de autenticação",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUser.Focus();
                    return;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha de conexão, entre em contato com o T.I.\n","Falha de conexão",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUser.Focus();
            }
        }





        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void linkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha();
            frmAlterarSenha.ShowDialog();
        }
    }
}
