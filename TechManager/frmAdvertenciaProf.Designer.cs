﻿namespace TechManager
{
    partial class frmAdvertenciaProf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvertenciaProf));
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtJustificativa = new System.Windows.Forms.TextBox();
            this.lblJustificativa = new System.Windows.Forms.Label();
            this.dataGridAdvert = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Máquina";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Problema";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            // 
            // txtJustificativa
            // 
            this.txtJustificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJustificativa.Location = new System.Drawing.Point(431, 364);
            this.txtJustificativa.Multiline = true;
            this.txtJustificativa.Name = "txtJustificativa";
            this.txtJustificativa.Size = new System.Drawing.Size(349, 163);
            this.txtJustificativa.TabIndex = 1;
            // 
            // lblJustificativa
            // 
            this.lblJustificativa.AutoSize = true;
            this.lblJustificativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJustificativa.Location = new System.Drawing.Point(280, 430);
            this.lblJustificativa.Name = "lblJustificativa";
            this.lblJustificativa.Size = new System.Drawing.Size(137, 25);
            this.lblJustificativa.TabIndex = 11;
            this.lblJustificativa.Text = "Justificativa :";
            // 
            // dataGridAdvert
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridAdvert.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridAdvert.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridAdvert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAdvert.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAdvert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridAdvert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdvert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridAdvert.DoubleBuffered = true;
            this.dataGridAdvert.EnableHeadersVisualStyles = false;
            this.dataGridAdvert.HeaderBgColor = System.Drawing.Color.Brown;
            this.dataGridAdvert.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridAdvert.Location = new System.Drawing.Point(243, 12);
            this.dataGridAdvert.Name = "dataGridAdvert";
            this.dataGridAdvert.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridAdvert.Size = new System.Drawing.Size(609, 252);
            this.dataGridAdvert.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.btnHome.ImageActive = global::TechManager.Properties.Resources.back__1_;
            this.btnHome.Location = new System.Drawing.Point(76, 538);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(76, 60);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLogo.Location = new System.Drawing.Point(-43, 175);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(306, 258);
            this.pcbLogo.TabIndex = 3;
            this.pcbLogo.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNome.Location = new System.Drawing.Point(40, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(155, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Professor ( Nome )";
            // 
            // pcbProfessor
            // 
            this.pcbProfessor.BackgroundImage = global::TechManager.Properties.Resources.if_User_27887;
            this.pcbProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbProfessor.Location = new System.Drawing.Point(58, 25);
            this.pcbProfessor.Name = "pcbProfessor";
            this.pcbProfessor.Size = new System.Drawing.Size(118, 106);
            this.pcbProfessor.TabIndex = 0;
            this.pcbProfessor.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pcbLogo);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 610);
            this.panel1.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(431, 565);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 33);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnEnviar.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEnviar.ForeColor = System.Drawing.Color.Black;
            this.btnEnviar.Location = new System.Drawing.Point(626, 565);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(120, 33);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvertencia.Location = new System.Drawing.Point(280, 300);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Size = new System.Drawing.Size(289, 25);
            this.lblAdvertencia.TabIndex = 17;
            this.lblAdvertencia.Text = "Advertencia: + Nao efetivada";
            // 
            // frmAdvertenciaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 610);
            this.Controls.Add(this.lblAdvertencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtJustificativa);
            this.Controls.Add(this.lblJustificativa);
            this.Controls.Add(this.dataGridAdvert);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdvertenciaProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advertencia Professor";
            this.Load += new System.EventHandler(this.frmAdvertencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtJustificativa;
        private System.Windows.Forms.Label lblJustificativa;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridAdvert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}