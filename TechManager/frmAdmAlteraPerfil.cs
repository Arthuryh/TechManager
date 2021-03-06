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
using System.Text.RegularExpressions;


namespace TechManager
{
    public partial class frmAdmAlteraPerfil : Form
    {
        public frmAdmAlteraPerfil()
        {
            InitializeComponent();
        }
        usuarioDTO dto = new usuarioDTO();
        usuarioBLL bll = new usuarioBLL();

        private void frmAdmAlteraPerfil_Load(object sender, EventArgs e)
        {
            desativaCampos();
            carregaGrid();
            lblMensagem.Text = "Selecione um registro na tabela.";

        }

        private void carregaGrid()
        {
            dgvAltera.AutoGenerateColumns = false;
            try
            {
                List<usuarioDTO> ListDto = new List<usuarioDTO>();
                ListDto = new usuarioBLL().listaUsuario();


                dgvAltera.DataSource = ListDto;
                CurrencyManager cm = (CurrencyManager)BindingContext[dgvAltera.DataSource];
                cm.EndCurrentEdit();
                cm.ResumeBinding();
                cm.SuspendBinding();

                foreach (DataGridViewRow row in dgvAltera.Rows)
                {

                    if(Convert.ToInt32(row.Cells["tipo"].Value) == 1)
                    {
                        row.Cells["teste"].Value = Convert.ToString("Professor");
                    }
                    else if (Convert.ToInt32(row.Cells["tipo"].Value) == 2)
                    {
                        row.Cells["teste"].Value = Convert.ToString("Técnico");

                    }

                    else
                    {
                        row.Visible = false;


                    }


                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            mktxtRG.ForeColor = Color.Black;

        }


        private void desativaCampos()
        {
            txtConfirmarSenha.Enabled = false;
            txtEmail.Enabled = false;
            txtLogin.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            mktxtRG.Enabled = false;
        }
        private void Habilita()
        {

            txtConfirmarSenha.Enabled = true;
            txtEmail.Enabled = true;
            txtLogin.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            mktxtRG.Enabled = true;
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (!mktxtRG.MaskCompleted)
            {
                lblMensagem.Text = ("O campo CPF está incompleto.");
                lblMensagem.ForeColor = Color.Red;
                mktxtRG.BackColor = Color.Salmon;

                return;
            }
            else
            {
                if (Valida(mktxtRG.Text))
                {
                    lblMensagem.Text = ("");
                }
                else
                {
                    lblMensagem.Text = ("CPF inválido");
                    lblMensagem.ForeColor = Color.Red;
                    mktxtRG.BackColor = Color.Salmon;
                    mktxtRG.Focus();
                    return;
                }
            }
            if (!verificaCampos())
            {
                return;
            }
            else
            {
                dto.nome = txtNome.Text;
                dto.login = txtLogin.Text;
                dto.senha = txtSenha.Text;
                dto.email = txtEmail.Text;
                dto.rg = mktxtRG.Text;
               

                try
                {
                    bll.admAlteraUsuario(dto);
                    lblMensagem.Text = "Alterado com sucesso!";
                    LimpaCampos();
                    carregaGrid();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Erro Inexperado, contate o T.I." + er, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if ((c is TextBox) || (c is MaskedTextBox))
                    (c as Control).Text = "";
                    
                    

            }
        }

        private bool verificaCampos()
        {
            string email = txtEmail.Text;
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txtNome.Text == "" || txtLogin.Text == "" || txtEmail.Text == "" || mktxtRG.Text == "")
            {
                lblMensagem.Text = "Todos os campos devem ser preenchidos!";
                lblMensagem.ForeColor = Color.Red;
                txtNome.Focus();
                return false;
            }
            if (mktxtRG.TextLength < 8)
            {
                lblMensagem.Text = "RG incompleto!";
                mktxtRG.Focus();
                mktxtRG.BackColor = Color.Salmon;
                lblMensagem.ForeColor = Color.Red;
                mktxtRG.Focus();
                return false;
            }
            else
            {
                mktxtRG.BackColor = Color.White;

            }

            if (txtSenha.Text.Length < 7)
            {
                lblMensagem.Text = "Senha deve ter no mínimo 8 caracteres";
                lblMensagem.ForeColor = Color.Red;
                txtSenha.BackColor = Color.Salmon;
                txtSenha.Focus();
                return false;
            }
            else
            {
                txtSenha.BackColor = Color.White;
                mktxtRG.BackColor = Color.White;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblMensagem.Text = "As senhas não coincidem!";
                lblMensagem.ForeColor = Color.Red;
                txtSenha.BackColor = Color.Salmon;

                txtSenha.Focus();
                return false;
            }
            else
            {
                txtSenha.BackColor = Color.White;

            }

            if (rg.IsMatch(email))
            {
                lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
                lblMensagem.ForeColor = Color.Green;
                txtEmail.BackColor = Color.White;

            }
            else
            {
                lblMensagem.Text = "Email Inválido!";
                lblMensagem.ForeColor = Color.Red;
                txtEmail.BackColor = Color.Salmon;
                txtEmail.Focus();

                return false;
            }

            return true;

        }

        private void dgvAltera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Habilita();
            mktxtRG.Clear();
            mktxtRG.ForeColor = Color.Black;
            int sel = dgvAltera.CurrentRow.Index;

            txtConfirmarSenha.Text = "";
            txtEmail.Text = Convert.ToString(dgvAltera["email", sel].Value);
            txtLogin.Text = Convert.ToString(dgvAltera["login", sel].Value);;
            txtNome.Text = Convert.ToString(dgvAltera["nome", sel].Value);;
            //txtNomeFotoPerfil.Text = Convert.ToString(dgvAltera["foto", sel].Value);;
            txtSenha.Text = Convert.ToString(dgvAltera["senha", sel].Value);
            mktxtRG.Text = Convert.ToString(dgvAltera["rg", sel].Value);
            dto.id = Convert.ToInt32(dgvAltera["id", sel].Value);
            
            lblMensagem.Text = "Após terminar a edição clique em ALTERAR";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desativaCampos();
            LimpaCampos();
            mktxtRG.Text = "Apenas números";
            lblMensagem.Text = "Selecione um registro na tabela.";

        }

        private void mktxtRG_MouseClick(object sender, MouseEventArgs e)
        {
            mktxtRG.Clear();
        }

        private void mktxtRG_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool Valida(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();



            if (cpf.Length < 11)
            {
                return false;

            }


            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "00000000000":
                    return false;
                case "2222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }

        private void mktxtRG_TextChanged_1(object sender, EventArgs e)
        {
            mktxtRG.BackColor = Color.White;
        }
    }
}
