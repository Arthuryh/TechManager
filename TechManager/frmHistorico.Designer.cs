﻿namespace TechManager
{
    partial class frmHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.dgvHist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbHist = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 538);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(84, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Voltar";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::TechManager.Properties.Resources.back2;
            this.bunifuImageButton2.ImageActive = global::TechManager.Properties.Resources.back__1_;
            this.bunifuImageButton2.Location = new System.Drawing.Point(77, 465);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(76, 60);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-43, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 258);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
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
            // dgvHist
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.data,
            this.idMaquina});
            this.dgvHist.DoubleBuffered = true;
            this.dgvHist.EnableHeadersVisualStyles = false;
            this.dgvHist.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvHist.HeaderForeColor = System.Drawing.Color.White;
            this.dgvHist.Location = new System.Drawing.Point(260, 25);
            this.dgvHist.Name = "dgvHist";
            this.dgvHist.ReadOnly = true;
            this.dgvHist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHist.Size = new System.Drawing.Size(542, 189);
            this.dgvHist.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "aula";
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "professor";
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "problema";
            this.Column4.HeaderText = "Problema";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // idMaquina
            // 
            this.idMaquina.DataPropertyName = "idMaquina";
            this.idMaquina.HeaderText = "ID";
            this.idMaquina.Name = "idMaquina";
            this.idMaquina.ReadOnly = true;
            // 
            // cmbHist
            // 
            this.cmbHist.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHist.BorderRadius = 5;
            this.cmbHist.DisabledColor = System.Drawing.Color.Gray;
            this.cmbHist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHist.ForeColor = System.Drawing.Color.White;
            this.cmbHist.Location = new System.Drawing.Point(260, 240);
            this.cmbHist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHist.Name = "cmbHist";
            this.cmbHist.NomalColor = System.Drawing.Color.CornflowerBlue;
            this.cmbHist.onHoverColor = System.Drawing.Color.Gray;
            this.cmbHist.selectedIndex = -1;
            this.cmbHist.Size = new System.Drawing.Size(217, 35);
            this.cmbHist.TabIndex = 11;
            this.cmbHist.onItemSelected += new System.EventHandler(this.cmbHist_onItemSelected);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.Location = new System.Drawing.Point(503, 249);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(247, 26);
            this.txtUser.TabIndex = 12;
            this.txtUser.Text = "Usuário";
            this.txtUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUser_MouseClick);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 538);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmbHist);
            this.Controls.Add(this.dgvHist);
            this.Controls.Add(this.panel1);
            this.Name = "frmHistorico";
            this.Text = "frmHistorico";
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvHist;
        private Bunifu.Framework.UI.BunifuDropdown cmbHist;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaquina;
    }
}