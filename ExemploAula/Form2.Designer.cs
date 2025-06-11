namespace ExemploAula
{
    partial class frmmenu
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
            btnvoltar = new Button();
            SuspendLayout();
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(215, 342);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(369, 23);
            btnvoltar.TabIndex = 0;
            btnvoltar.Text = "Voltar a tela de login";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // frmmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnvoltar);
            Name = "frmmenu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnvoltar;
    }
}