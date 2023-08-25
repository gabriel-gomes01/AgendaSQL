namespace AgendaSQL
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmd_visualizar = new System.Windows.Forms.Button();
            cmd_adicionar = new System.Windows.Forms.Button();
            cmd_pesquisar = new System.Windows.Forms.Button();
            cmd_sair = new System.Windows.Forms.Button();
            label_titulo = new System.Windows.Forms.Label();
            label_versao = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cmd_visualizar
            // 
            cmd_visualizar.Location = new System.Drawing.Point(86, 62);
            cmd_visualizar.Name = "cmd_visualizar";
            cmd_visualizar.Size = new System.Drawing.Size(184, 57);
            cmd_visualizar.TabIndex = 0;
            cmd_visualizar.Text = "Visualizar Tudo";
            cmd_visualizar.UseVisualStyleBackColor = true;
            cmd_visualizar.Click += cmd_visualizar_Click;
            // 
            // cmd_adicionar
            // 
            cmd_adicionar.Location = new System.Drawing.Point(86, 125);
            cmd_adicionar.Name = "cmd_adicionar";
            cmd_adicionar.Size = new System.Drawing.Size(184, 57);
            cmd_adicionar.TabIndex = 1;
            cmd_adicionar.Text = "Adicionar";
            cmd_adicionar.UseVisualStyleBackColor = true;
            cmd_adicionar.Click += cmd_adicionar_Click;
            // 
            // cmd_pesquisar
            // 
            cmd_pesquisar.Location = new System.Drawing.Point(86, 188);
            cmd_pesquisar.Name = "cmd_pesquisar";
            cmd_pesquisar.Size = new System.Drawing.Size(184, 57);
            cmd_pesquisar.TabIndex = 2;
            cmd_pesquisar.Text = "Pesquisar";
            cmd_pesquisar.UseVisualStyleBackColor = true;
            cmd_pesquisar.Click += cmd_pesquisar_Click;
            // 
            // cmd_sair
            // 
            cmd_sair.Location = new System.Drawing.Point(86, 251);
            cmd_sair.Name = "cmd_sair";
            cmd_sair.Size = new System.Drawing.Size(184, 57);
            cmd_sair.TabIndex = 3;
            cmd_sair.Text = "Sair";
            cmd_sair.UseVisualStyleBackColor = true;
            cmd_sair.Click += cmd_sair_Click;
            // 
            // label_titulo
            // 
            label_titulo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_titulo.Location = new System.Drawing.Point(69, 9);
            label_titulo.Name = "label_titulo";
            label_titulo.Size = new System.Drawing.Size(216, 50);
            label_titulo.TabIndex = 4;
            label_titulo.Text = "Agenda SQL";
            label_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_versao
            // 
            label_versao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label_versao.Location = new System.Drawing.Point(83, 320);
            label_versao.Name = "label_versao";
            label_versao.Size = new System.Drawing.Size(187, 33);
            label_versao.TabIndex = 5;
            label_versao.Text = "Versao";
            label_versao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(354, 371);
            ControlBox = false;
            Controls.Add(label_versao);
            Controls.Add(label_titulo);
            Controls.Add(cmd_sair);
            Controls.Add(cmd_pesquisar);
            Controls.Add(cmd_adicionar);
            Controls.Add(cmd_visualizar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AGENDA SQL";
            Load += frmMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button cmd_visualizar;
        private System.Windows.Forms.Button cmd_adicionar;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label label_titulo;
        private System.Windows.Forms.Label label_versao;
    }
}
