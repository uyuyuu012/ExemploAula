namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUsu�rio.Text == "Admin" && TxtSenha.Text == "123456") 
            {
                MessageBox.Show("Usu�rio logado com sucesso");
                TxtUsu�rio.Clear();
                TxtSenha.Clear();

            }
            else
            {
                MessageBox.Show("Usu�rio ou senha errados");
                TxtUsu�rio.Clear();
                TxtSenha.Clear(); 
            }

            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
