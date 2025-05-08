namespace ProjetoIntegrador.Login
{
    partial class Login
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
            pnl_header = new Panel();
            lbl_titulo = new Label();
            lbl_titulologin = new Label();
            lbl_RAtext = new Label();
            txt_RA = new TextBox();
            txt_senha = new TextBox();
            lbl_senhatext = new Label();
            btn_entrar = new Button();
            pnl_header.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.MidnightBlue;
            pnl_header.Controls.Add(lbl_titulo);
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(730, 49);
            pnl_header.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.ButtonHighlight;
            lbl_titulo.Location = new Point(335, 18);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(38, 15);
            lbl_titulo.TabIndex = 1;
            lbl_titulo.Text = "SEHD";
            lbl_titulo.Click += lbl_titulo_Click_2;
            // 
            // lbl_titulologin
            // 
            lbl_titulologin.AutoSize = true;
            lbl_titulologin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulologin.ForeColor = Color.MidnightBlue;
            lbl_titulologin.Location = new Point(335, 147);
            lbl_titulologin.Name = "lbl_titulologin";
            lbl_titulologin.Size = new Size(37, 15);
            lbl_titulologin.TabIndex = 1;
            lbl_titulologin.Text = "Login";
            // 
            // lbl_RAtext
            // 
            lbl_RAtext.AutoSize = true;
            lbl_RAtext.BackColor = Color.DarkGray;
            lbl_RAtext.ForeColor = Color.DimGray;
            lbl_RAtext.Location = new Point(227, 182);
            lbl_RAtext.Name = "lbl_RAtext";
            lbl_RAtext.Size = new Size(22, 15);
            lbl_RAtext.TabIndex = 4;
            lbl_RAtext.Text = "RA";
            lbl_RAtext.Click += lbl_RAtext_Click;
            // 
            // txt_RA
            // 
            txt_RA.BackColor = Color.DarkGray;
            txt_RA.BorderStyle = BorderStyle.None;
            txt_RA.Location = new Point(226, 182);
            txt_RA.Name = "txt_RA";
            txt_RA.Size = new Size(253, 16);
            txt_RA.TabIndex = 5;
            // 
            // txt_senha
            // 
            txt_senha.BackColor = Color.DarkGray;
            txt_senha.BorderStyle = BorderStyle.None;
            txt_senha.Location = new Point(226, 216);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(253, 16);
            txt_senha.TabIndex = 6;
            // 
            // lbl_senhatext
            // 
            lbl_senhatext.AutoSize = true;
            lbl_senhatext.BackColor = Color.DarkGray;
            lbl_senhatext.ForeColor = Color.DimGray;
            lbl_senhatext.Location = new Point(227, 216);
            lbl_senhatext.Name = "lbl_senhatext";
            lbl_senhatext.Size = new Size(39, 15);
            lbl_senhatext.TabIndex = 7;
            lbl_senhatext.Text = "Senha";
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = Color.MidnightBlue;
            btn_entrar.ForeColor = SystemColors.HighlightText;
            btn_entrar.Location = new Point(314, 250);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(75, 23);
            btn_entrar.TabIndex = 8;
            btn_entrar.Text = "ENTRAR";
            btn_entrar.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(730, 406);
            Controls.Add(btn_entrar);
            Controls.Add(lbl_senhatext);
            Controls.Add(txt_senha);
            Controls.Add(lbl_RAtext);
            Controls.Add(lbl_titulologin);
            Controls.Add(pnl_header);
            Controls.Add(txt_RA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_header;
        private Label lbl_titulo;
        private Label lbl_titulologin;
        private Label lbl_RAtext;
        private TextBox txt_RA;
        private TextBox txt_senha;
        private Label lbl_senhatext;
        private Button btn_entrar;
    }
}