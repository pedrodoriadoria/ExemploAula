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
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            btnusuario = new Button();
            btnsenha = new Button();
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
            // btnusuario
            // 
            btnusuario.Location = new Point(397, 100);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(75, 23);
            btnusuario.TabIndex = 3;
            btnusuario.UseVisualStyleBackColor = true;
            // 
            // btnsenha
            // 
            btnsenha.Location = new Point(397, 153);
            btnsenha.Name = "btnsenha";
            btnsenha.Size = new Size(75, 23);
            btnsenha.TabIndex = 4;
            btnsenha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsenha);
            Controls.Add(btnusuario);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private Button btnusuario;
        private Button btnsenha;
    }
}
