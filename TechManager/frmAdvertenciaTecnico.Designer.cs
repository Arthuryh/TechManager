﻿namespace TechManager
{
    partial class frmAdvertenciaTecnico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvertenciaTecnico));
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.lblJustificativa = new System.Windows.Forms.Label();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.dataGridAdvert = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.justificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advertencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdvert)).BeginInit();
            this.SuspendLayout();
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtJustificativa.Enabled = false;
            this.txtJustificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificativa.ForeColor = System.Drawing.Color.Gray;
            this.txtJustificativa.Location = new System.Drawing.Point(674, 395);
            this.txtJustificativa.MaxLength = 50;
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(349, 97);
            this.txtJustificativa.TabIndex = 1;
            this.txtJustificativa.Text = "Escreva sua justificativa aqui!";
            this.txtJustificativa.TextChanged += new System.EventHandler(this.txtJustificativa_TextChanged);
            // 
            // lblJustificativa
            // 
            this.lblJustificativa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJustificativa.AutoSize = true;
            this.lblJustificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificativa.Location = new System.Drawing.Point(523, 423);
            this.lblJustificativa.Name = "lblJustificativa";
            this.lblJustificativa.Size = new System.Drawing.Size(137, 25);
            this.lblJustificativa.TabIndex = 5;
            this.lblJustificativa.Text = "Justificativa :";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.btnHome.ImageActive = global::TechManager.Properties.Resources.if_go_home_118770;
            this.btnHome.Location = new System.Drawing.Point(58, 489);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 109);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNome.Location = new System.Drawing.Point(54, 175);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(136, 23);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Tecnico ( Nome )";
            // 
            // pcbProfessor
            // 
            this.pcbProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbProfessor.Image = global::TechManager.Properties.Resources.tec1;
            this.pcbProfessor.Location = new System.Drawing.Point(46, 12);
            this.pcbProfessor.Name = "pcbProfessor";
            this.pcbProfessor.Size = new System.Drawing.Size(145, 149);
            this.pcbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProfessor.TabIndex = 0;
            this.pcbProfessor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 729);
            this.panel1.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(674, 624);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 33);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnEnviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(869, 624);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 33);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(523, 315);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(71, 25);
            this.lblAdvertencia.TabIndex = 6;
            this.lblAdvertencia.Text = "Aviso:";
            // 
            // dataGridAdvert
            // 
            this.dataGridAdvert.AllowUserToAddRows = false;
            this.dataGridAdvert.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridAdvert.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAdvert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridAdvert.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAdvert.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridAdvert.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridAdvert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAdvert.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAdvert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAdvert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdvert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idAdv,
            this.justificativa,
            this.advertencia,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridAdvert.DoubleBuffered = true;
            this.dataGridAdvert.EnableHeadersVisualStyles = false;
            this.dataGridAdvert.HeaderBgColor = System.Drawing.Color.Brown;
            this.dataGridAdvert.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridAdvert.Location = new System.Drawing.Point(378, 24);
            this.dataGridAdvert.Name = "dataGridAdvert";
            this.dataGridAdvert.ReadOnly = true;
            this.dataGridAdvert.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAdvert.Size = new System.Drawing.Size(862, 245);
            this.dataGridAdvert.TabIndex = 0;
            this.dataGridAdvert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAdvert_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "aula";
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // idAdv
            // 
            this.idAdv.DataPropertyName = "idAdv";
            this.idAdv.HeaderText = "idAdv";
            this.idAdv.Name = "idAdv";
            this.idAdv.ReadOnly = true;
            // 
            // justificativa
            // 
            this.justificativa.DataPropertyName = "justificado";
            this.justificativa.HeaderText = "Column6";
            this.justificativa.Name = "justificativa";
            this.justificativa.ReadOnly = true;
            this.justificativa.Visible = false;
            // 
            // advertencia
            // 
            this.advertencia.DataPropertyName = "advertencia";
            this.advertencia.HeaderText = "Column7";
            this.advertencia.Name = "advertencia";
            this.advertencia.ReadOnly = true;
            this.advertencia.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "professor";
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idMaquina";
            this.Column3.HeaderText = "ID Máquina";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "problema";
            this.Column4.HeaderText = "Problema";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "data";
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(514, 565);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(659, 20);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Selecione um problema para mandar uma Justificativa, e depois clique no botão env" +
    "iar!";
            // 
            // frmAdvertenciaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.dataGridAdvert);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtJustificativa);
            this.Controls.Add(this.lblJustificativa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdvertenciaTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advertencia Técnico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdvertencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdvert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.Label lblJustificativa;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblAdvertencia;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridAdvert;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn justificativa;
        private System.Windows.Forms.DataGridViewTextBoxColumn advertencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}