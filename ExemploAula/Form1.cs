namespace ExemploAula
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "admin" && txtsenha.Text == "123456")
            {
                MessageBox.Show("Login realizado com sucesso");
                txtusuario.Clear();
                Hide();
                frmmenu frmmenu = new frmmenu();
                frmmenu.Show();

            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreta");


            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
