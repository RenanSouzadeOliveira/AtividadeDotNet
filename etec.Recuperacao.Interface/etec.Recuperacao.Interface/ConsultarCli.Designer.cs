namespace etec.Recuperacao.Interface
{
    partial class ConsultarCli
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
            this.dtCli = new System.Windows.Forms.DataGridView();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnCadastrarCarro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCli)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCli
            // 
            this.dtCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCli.Location = new System.Drawing.Point(13, 13);
            this.dtCli.Name = "dtCli";
            this.dtCli.Size = new System.Drawing.Size(702, 150);
            this.dtCli.TabIndex = 0;
            this.dtCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCli_CellContentClick);
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(12, 169);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(98, 23);
            this.btnCad.TabIndex = 1;
            this.btnCad.Text = "Cadastrar Cliente";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnCadastrarCarro
            // 
            this.btnCadastrarCarro.Location = new System.Drawing.Point(116, 169);
            this.btnCadastrarCarro.Name = "btnCadastrarCarro";
            this.btnCadastrarCarro.Size = new System.Drawing.Size(88, 23);
            this.btnCadastrarCarro.TabIndex = 2;
            this.btnCadastrarCarro.Text = "Cadastrar Carro";
            this.btnCadastrarCarro.UseVisualStyleBackColor = true;
            this.btnCadastrarCarro.Click += new System.EventHandler(this.btnCadastrarCarro_Click);
            // 
            // ConsultarCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 262);
            this.Controls.Add(this.btnCadastrarCarro);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.dtCli);
            this.Name = "ConsultarCli";
            this.Text = "ConsultarCli";
            this.Load += new System.EventHandler(this.ConsultarCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCli;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnCadastrarCarro;
    }
}