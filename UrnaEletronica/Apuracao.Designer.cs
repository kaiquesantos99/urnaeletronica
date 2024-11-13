namespace UrnaEletronica
{
    partial class Apuracao
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
            dgvApuracao = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvApuracao).BeginInit();
            SuspendLayout();
            // 
            // dgvApuracao
            // 
            dgvApuracao.AllowUserToAddRows = false;
            dgvApuracao.AllowUserToDeleteRows = false;
            dgvApuracao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApuracao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApuracao.Location = new Point(12, 12);
            dgvApuracao.Name = "dgvApuracao";
            dgvApuracao.ReadOnly = true;
            dgvApuracao.Size = new Size(464, 281);
            dgvApuracao.TabIndex = 0;
            // 
            // Apuracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 309);
            Controls.Add(dgvApuracao);
            Name = "Apuracao";
            Text = "Apuracao";
            Load += Apuracao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApuracao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvApuracao;
    }
}