namespace AgendaSQL
{
    partial class frmPesquisar
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
            btn_Pesquisar = new System.Windows.Forms.Button();
            btn_cancelar = new System.Windows.Forms.Button();
            text_pesquisa = new System.Windows.Forms.TextBox();
            lbl_Pesquisar = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_Pesquisar
            // 
            btn_Pesquisar.Location = new System.Drawing.Point(241, 92);
            btn_Pesquisar.Name = "btn_Pesquisar";
            btn_Pesquisar.Size = new System.Drawing.Size(110, 42);
            btn_Pesquisar.TabIndex = 0;
            btn_Pesquisar.Text = "Pesquisar";
            btn_Pesquisar.UseVisualStyleBackColor = true;
            btn_Pesquisar.Click += button1_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new System.Drawing.Point(12, 92);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new System.Drawing.Size(110, 42);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // text_pesquisa
            // 
            text_pesquisa.Location = new System.Drawing.Point(12, 45);
            text_pesquisa.Name = "text_pesquisa";
            text_pesquisa.Size = new System.Drawing.Size(339, 23);
            text_pesquisa.TabIndex = 2;
            // 
            // lbl_Pesquisar
            // 
            lbl_Pesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Pesquisar.Location = new System.Drawing.Point(12, 9);
            lbl_Pesquisar.Name = "lbl_Pesquisar";
            lbl_Pesquisar.Size = new System.Drawing.Size(100, 23);
            lbl_Pesquisar.TabIndex = 3;
            lbl_Pesquisar.Text = "Pesquisar";
            lbl_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPesquisar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(363, 146);
            ControlBox = false;
            Controls.Add(lbl_Pesquisar);
            Controls.Add(text_pesquisa);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_Pesquisar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPesquisar";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Pesquisar";
            Load += frmPesquisar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox text_pesquisa;
        private System.Windows.Forms.Label lbl_Pesquisar;
    }
}