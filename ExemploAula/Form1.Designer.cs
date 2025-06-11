namespace ExemploAula
{
    partial class Form1
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
            LblLogin = new Label();
            LblUsuário = new Label();
            LblSenha = new Label();
            TxtUsuário = new TextBox();
            SuspendLayout();
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblLogin.Location = new Point(341, 32);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(99, 45);
            LblLogin.TabIndex = 0;
            LblLogin.Text = "Login";
            // 
            // LblUsuário
            // 
            LblUsuário.AutoSize = true;
            LblUsuário.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblUsuário.Location = new Point(139, 134);
            LblUsuário.Name = "LblUsuário";
            LblUsuário.Size = new Size(108, 37);
            LblUsuário.TabIndex = 1;
            LblUsuário.Text = "Usuário";
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSenha.Location = new Point(139, 217);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(89, 37);
            LblSenha.TabIndex = 2;
            LblSenha.Text = "Senha";
            // 
            // TxtUsuário
            // 
            TxtUsuário.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtUsuário.Location = new Point(290, 134);
            TxtUsuário.Name = "TxtUsuário";
            TxtUsuário.Size = new Size(138, 43);
            TxtUsuário.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtUsuário);
            Controls.Add(LblSenha);
            Controls.Add(LblUsuário);
            Controls.Add(LblLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLogin;
        private Label LblUsuário;
        private Label LblSenha;
        private TextBox TxtUsuário;
    }
}
