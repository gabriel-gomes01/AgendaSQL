namespace AgendaSQL
{
    partial class frmResultados
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
            btn_Fechar = new System.Windows.Forms.Button();
            grid_resultados = new System.Windows.Forms.DataGridView();
            lbl_resultados = new System.Windows.Forms.Label();
            cmd_apagar = new System.Windows.Forms.Button();
            cmd_editar = new System.Windows.Forms.Button();
            cmd_ver_tudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)grid_resultados).BeginInit();
            SuspendLayout();
            // 
            // btn_Fechar
            // 
            btn_Fechar.Location = new System.Drawing.Point(500, 323);
            btn_Fechar.Name = "btn_Fechar";
            btn_Fechar.Size = new System.Drawing.Size(120, 45);
            btn_Fechar.TabIndex = 0;
            btn_Fechar.Text = "Fechar";
            btn_Fechar.UseVisualStyleBackColor = true;
            btn_Fechar.Click += btn_Fechar_Click;
            // 
            // grid_resultados
            // 
            grid_resultados.AllowUserToAddRows = false;
            grid_resultados.AllowUserToDeleteRows = false;
            grid_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_resultados.Location = new System.Drawing.Point(12, 12);
            grid_resultados.Name = "grid_resultados";
            grid_resultados.ReadOnly = true;
            grid_resultados.RowHeadersVisible = false;
            grid_resultados.RowTemplate.Height = 25;
            grid_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grid_resultados.Size = new System.Drawing.Size(608, 305);
            grid_resultados.TabIndex = 1;
            grid_resultados.CellClick += grid_resultados_CellClick;
            // 
            // lbl_resultados
            // 
            lbl_resultados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_resultados.Location = new System.Drawing.Point(12, 334);
            lbl_resultados.Name = "lbl_resultados";
            lbl_resultados.Size = new System.Drawing.Size(110, 37);
            lbl_resultados.TabIndex = 2;
            lbl_resultados.Text = "Resultado";
            lbl_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmd_apagar
            // 
            cmd_apagar.Location = new System.Drawing.Point(382, 323);
            cmd_apagar.Name = "cmd_apagar";
            cmd_apagar.Size = new System.Drawing.Size(112, 45);
            cmd_apagar.TabIndex = 3;
            cmd_apagar.Text = "Apagar";
            cmd_apagar.UseVisualStyleBackColor = true;
            cmd_apagar.Click += cmd_apagar_Click;
            // 
            // cmd_editar
            // 
            cmd_editar.Location = new System.Drawing.Point(271, 323);
            cmd_editar.Name = "cmd_editar";
            cmd_editar.Size = new System.Drawing.Size(105, 45);
            cmd_editar.TabIndex = 4;
            cmd_editar.Text = "Editar";
            cmd_editar.UseVisualStyleBackColor = true;
            cmd_editar.Click += cmd_editar_Click;
            // 
            // cmd_ver_tudo
            // 
            cmd_ver_tudo.Location = new System.Drawing.Point(160, 323);
            cmd_ver_tudo.Name = "cmd_ver_tudo";
            cmd_ver_tudo.Size = new System.Drawing.Size(105, 45);
            cmd_ver_tudo.TabIndex = 5;
            cmd_ver_tudo.Text = "Ver Tudo";
            cmd_ver_tudo.UseVisualStyleBackColor = true;
            cmd_ver_tudo.Click += cmd_ver_tudo_Click;
            // 
            // frmResultados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(632, 380);
            ControlBox = false;
            Controls.Add(cmd_ver_tudo);
            Controls.Add(cmd_editar);
            Controls.Add(cmd_apagar);
            Controls.Add(lbl_resultados);
            Controls.Add(grid_resultados);
            Controls.Add(btn_Fechar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResultados";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Resultados";
            Load += frmResultados_Load;
            ((System.ComponentModel.ISupportInitialize)grid_resultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.DataGridView grid_resultados;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_ver_tudo;
    }
}