namespace GerenciaHoras.View.Formularios
{
    partial class Fm_Cadastro
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
            this.LblNomeProjeto = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.LblHoraInicial = new System.Windows.Forms.Label();
            this.TxtNomeProjeto = new System.Windows.Forms.TextBox();
            this.TxtDataInicio = new System.Windows.Forms.TextBox();
            this.TxtHoraInicio = new System.Windows.Forms.TextBox();
            this.BtnAdicionarProjeto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNomeProjeto
            // 
            this.LblNomeProjeto.AutoSize = true;
            this.LblNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeProjeto.Location = new System.Drawing.Point(22, 32);
            this.LblNomeProjeto.Name = "LblNomeProjeto";
            this.LblNomeProjeto.Size = new System.Drawing.Size(114, 17);
            this.LblNomeProjeto.TabIndex = 0;
            this.LblNomeProjeto.Text = "Nome do Projeto";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblData.Location = new System.Drawing.Point(22, 81);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(163, 17);
            this.LblData.TabIndex = 1;
            this.LblData.Text = "Data de Início do Projeto";
            // 
            // LblHoraInicial
            // 
            this.LblHoraInicial.AutoSize = true;
            this.LblHoraInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraInicial.Location = new System.Drawing.Point(22, 135);
            this.LblHoraInicial.Name = "LblHoraInicial";
            this.LblHoraInicial.Size = new System.Drawing.Size(164, 17);
            this.LblHoraInicial.TabIndex = 2;
            this.LblHoraInicial.Text = "Hora de Início do Projeto";
            // 
            // TxtNomeProjeto
            // 
            this.TxtNomeProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeProjeto.Location = new System.Drawing.Point(25, 52);
            this.TxtNomeProjeto.MaxLength = 40;
            this.TxtNomeProjeto.Name = "TxtNomeProjeto";
            this.TxtNomeProjeto.Size = new System.Drawing.Size(200, 23);
            this.TxtNomeProjeto.TabIndex = 3;
            this.TxtNomeProjeto.TextChanged += new System.EventHandler(this.TxtNomeProjeto_TextChanged);
            this.TxtNomeProjeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeProjeto_KeyPress);
            // 
            // TxtDataInicio
            // 
            this.TxtDataInicio.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDataInicio.Enabled = false;
            this.TxtDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDataInicio.Location = new System.Drawing.Point(25, 101);
            this.TxtDataInicio.MaxLength = 10;
            this.TxtDataInicio.Name = "TxtDataInicio";
            this.TxtDataInicio.ReadOnly = true;
            this.TxtDataInicio.Size = new System.Drawing.Size(100, 23);
            this.TxtDataInicio.TabIndex = 4;
            // 
            // TxtHoraInicio
            // 
            this.TxtHoraInicio.BackColor = System.Drawing.SystemColors.Info;
            this.TxtHoraInicio.Enabled = false;
            this.TxtHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoraInicio.Location = new System.Drawing.Point(25, 155);
            this.TxtHoraInicio.MaxLength = 5;
            this.TxtHoraInicio.Name = "TxtHoraInicio";
            this.TxtHoraInicio.ReadOnly = true;
            this.TxtHoraInicio.Size = new System.Drawing.Size(100, 23);
            this.TxtHoraInicio.TabIndex = 5;
            // 
            // BtnAdicionarProjeto
            // 
            this.BtnAdicionarProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.BtnAdicionarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdicionarProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdicionarProjeto.Location = new System.Drawing.Point(218, 101);
            this.BtnAdicionarProjeto.Name = "BtnAdicionarProjeto";
            this.BtnAdicionarProjeto.Size = new System.Drawing.Size(75, 40);
            this.BtnAdicionarProjeto.TabIndex = 6;
            this.BtnAdicionarProjeto.Text = "Adicionar Projeto";
            this.BtnAdicionarProjeto.UseVisualStyleBackColor = false;
            this.BtnAdicionarProjeto.Click += new System.EventHandler(this.BtnAdicionarProjeto_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(218, 155);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 40);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Fm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 221);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAdicionarProjeto);
            this.Controls.Add(this.TxtHoraInicio);
            this.Controls.Add(this.TxtDataInicio);
            this.Controls.Add(this.TxtNomeProjeto);
            this.Controls.Add(this.LblHoraInicial);
            this.Controls.Add(this.LblData);
            this.Controls.Add(this.LblNomeProjeto);
            this.Name = "Fm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Projeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeProjeto;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblHoraInicial;
        private System.Windows.Forms.TextBox TxtNomeProjeto;
        private System.Windows.Forms.TextBox TxtDataInicio;
        private System.Windows.Forms.TextBox TxtHoraInicio;
        private System.Windows.Forms.Button BtnAdicionarProjeto;
        private System.Windows.Forms.Button BtnCancelar;
    }
}