namespace GerenciaHoras.View
{
    partial class Fml_SisGenHoras
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnNovoProjeto = new System.Windows.Forms.Button();
            this.BtnDeletarProjeto = new System.Windows.Forms.Button();
            this.BtnRetomarProjeto = new System.Windows.Forms.Button();
            this.BtnConsultarHistorico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvTabelaProjetos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabelaProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNovoProjeto
            // 
            this.BtnNovoProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.BtnNovoProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNovoProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoProjeto.Location = new System.Drawing.Point(45, 35);
            this.BtnNovoProjeto.Name = "BtnNovoProjeto";
            this.BtnNovoProjeto.Size = new System.Drawing.Size(80, 40);
            this.BtnNovoProjeto.TabIndex = 0;
            this.BtnNovoProjeto.Text = "Novo Projeto";
            this.BtnNovoProjeto.UseVisualStyleBackColor = false;
            this.BtnNovoProjeto.Click += new System.EventHandler(this.BtnNovoProjeto_Click);
            // 
            // BtnDeletarProjeto
            // 
            this.BtnDeletarProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.BtnDeletarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDeletarProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletarProjeto.Location = new System.Drawing.Point(170, 35);
            this.BtnDeletarProjeto.Name = "BtnDeletarProjeto";
            this.BtnDeletarProjeto.Size = new System.Drawing.Size(80, 40);
            this.BtnDeletarProjeto.TabIndex = 1;
            this.BtnDeletarProjeto.Text = "Deletar Projeto";
            this.BtnDeletarProjeto.UseVisualStyleBackColor = false;
            // 
            // BtnRetomarProjeto
            // 
            this.BtnRetomarProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.BtnRetomarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRetomarProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetomarProjeto.Location = new System.Drawing.Point(296, 35);
            this.BtnRetomarProjeto.Name = "BtnRetomarProjeto";
            this.BtnRetomarProjeto.Size = new System.Drawing.Size(80, 40);
            this.BtnRetomarProjeto.TabIndex = 2;
            this.BtnRetomarProjeto.Text = "Retomar Projeto";
            this.BtnRetomarProjeto.UseVisualStyleBackColor = false;
            // 
            // BtnConsultarHistorico
            // 
            this.BtnConsultarHistorico.BackColor = System.Drawing.SystemColors.Info;
            this.BtnConsultarHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConsultarHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarHistorico.Location = new System.Drawing.Point(418, 35);
            this.BtnConsultarHistorico.Name = "BtnConsultarHistorico";
            this.BtnConsultarHistorico.Size = new System.Drawing.Size(80, 40);
            this.BtnConsultarHistorico.TabIndex = 3;
            this.BtnConsultarHistorico.Text = "Consultar Historico";
            this.BtnConsultarHistorico.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 5, 50, 5);
            this.label1.Size = new System.Drawing.Size(425, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Faça o controle de suas horas trabalhadas.";
            // 
            // DgvTabelaProjetos
            // 
            this.DgvTabelaProjetos.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DgvTabelaProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabelaProjetos.Location = new System.Drawing.Point(12, 81);
            this.DgvTabelaProjetos.Name = "DgvTabelaProjetos";
            this.DgvTabelaProjetos.Size = new System.Drawing.Size(520, 268);
            this.DgvTabelaProjetos.TabIndex = 5;
            // 
            // Fml_SisGenHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.DgvTabelaProjetos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConsultarHistorico);
            this.Controls.Add(this.BtnRetomarProjeto);
            this.Controls.Add(this.BtnDeletarProjeto);
            this.Controls.Add(this.BtnNovoProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Fml_SisGenHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gerenciador de Horas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabelaProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNovoProjeto;
        private System.Windows.Forms.Button BtnDeletarProjeto;
        private System.Windows.Forms.Button BtnRetomarProjeto;
        private System.Windows.Forms.Button BtnConsultarHistorico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvTabelaProjetos;
    }
}

