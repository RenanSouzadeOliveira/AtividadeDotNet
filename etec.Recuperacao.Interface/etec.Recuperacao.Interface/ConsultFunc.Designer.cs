namespace etec.Recuperacao.Interface
{
    partial class ConsultFunc
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
            this.dtFunc = new System.Windows.Forms.DataGridView();
            this.btnCadFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFunc
            // 
            this.dtFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFunc.Location = new System.Drawing.Point(13, 13);
            this.dtFunc.Name = "dtFunc";
            this.dtFunc.Size = new System.Drawing.Size(721, 150);
            this.dtFunc.TabIndex = 0;
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Location = new System.Drawing.Point(13, 170);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(119, 23);
            this.btnCadFunc.TabIndex = 1;
            this.btnCadFunc.Text = "Cadastrar Funcionário";
            this.btnCadFunc.UseVisualStyleBackColor = true;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // ConsultFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 199);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.dtFunc);
            this.Name = "ConsultFunc";
            this.Text = "ConsultFunc";
            this.Load += new System.EventHandler(this.ConsultFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtFunc;
        private System.Windows.Forms.Button btnCadFunc;
    }
}