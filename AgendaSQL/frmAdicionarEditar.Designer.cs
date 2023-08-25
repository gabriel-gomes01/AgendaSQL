namespace AgendaSQL
{
    partial class frmAdicionarEditar
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
            cmd_gravar = new System.Windows.Forms.Button();
            cmd_fechar = new System.Windows.Forms.Button();
            label_nome = new System.Windows.Forms.Label();
            text_nome = new System.Windows.Forms.TextBox();
            text_telefone = new System.Windows.Forms.TextBox();
            label_telefone = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cmd_gravar
            // 
            cmd_gravar.Location = new System.Drawing.Point(186, 165);
            cmd_gravar.Name = "cmd_gravar";
            cmd_gravar.Size = new System.Drawing.Size(113, 46);
            cmd_gravar.TabIndex = 0;
            cmd_gravar.Text = "Gravar";
            cmd_gravar.UseVisualStyleBackColor = true;
            cmd_gravar.Click += cmd_gravar_Click;
            // 
            // cmd_fechar
            // 
            cmd_fechar.Location = new System.Drawing.Point(305, 165);
            cmd_fechar.Name = "cmd_fechar";
            cmd_fechar.Size = new System.Drawing.Size(122, 46);
            cmd_fechar.TabIndex = 1;
            cmd_fechar.Text = "Fechar";
            cmd_fechar.UseVisualStyleBackColor = true;
            cmd_fechar.Click += cmd_fechar_Click;
            // 
            // label_nome
            // 
            label_nome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label_nome.Location = new System.Drawing.Point(12, 9);
            label_nome.Name = "label_nome";
            label_nome.Size = new System.Drawing.Size(100, 23);
            label_nome.TabIndex = 2;
            label_nome.Text = "Nome";
            // 
            // text_nome
            // 
            text_nome.Location = new System.Drawing.Point(12, 35);
            text_nome.MaxLength = 100;
            text_nome.Name = "text_nome";
            text_nome.Size = new System.Drawing.Size(410, 23);
            text_nome.TabIndex = 3;
            // 
            // text_telefone
            // 
            text_telefone.Location = new System.Drawing.Point(12, 100);
            text_telefone.MaxLength = 20;
            text_telefone.Name = "text_telefone";
            text_telefone.Size = new System.Drawing.Size(201, 23);
            text_telefone.TabIndex = 5;
            // 
            // label_telefone
            // 
            label_telefone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label_telefone.Location = new System.Drawing.Point(12, 74);
            label_telefone.Name = "label_telefone";
            label_telefone.Size = new System.Drawing.Size(73, 23);
            label_telefone.TabIndex = 4;
            label_telefone.Text = "Telefone";
            // 
            // frmAdicionarEditar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(439, 223);
            ControlBox = false;
            Controls.Add(text_telefone);
            Controls.Add(label_telefone);
            Controls.Add(text_nome);
            Controls.Add(label_nome);
            Controls.Add(cmd_fechar);
            Controls.Add(cmd_gravar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdicionarEditar";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmAdicionarEditar";
            Load += frmAdicionarEditar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button cmd_gravar;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_telefone;
        private System.Windows.Forms.Label label_telefone;
    }
}