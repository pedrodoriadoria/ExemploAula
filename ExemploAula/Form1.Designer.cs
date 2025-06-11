namespace ExemploAula
{
    partial class frm1
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
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            btnlogar = new Button();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(358, 35);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(37, 15);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(174, 100);
            lblusuario.Name = "lblusuario";
            lblusuario.RightToLeft = RightToLeft.No;
            lblusuario.Size = new Size(47, 15);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "Usuário";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(174, 161);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "Senha";
            // 
            // btnlogar
            // 
            btnlogar.Location = new Point(358, 326);
            btnlogar.Name = "btnlogar";
            btnlogar.Size = new Size(75, 23);
            btnlogar.TabIndex = 5;
            btnlogar.Text = "Logar";
            btnlogar.UseVisualStyleBackColor = true;
            btnlogar.Click += btnlogar_Click;
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(434, 113);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 6;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(434, 161);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 7;
            // 
            // frm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(btnlogar);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "frm1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private Button btnlogar;
        private TextBox txtusuario;
        private TextBox txtsenha;
    }
}
