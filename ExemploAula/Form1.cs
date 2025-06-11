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
            if(TxtUsuário.Text == "Admin" && TxtSenha.Text == "123456") 
            {
                MessageBox.Show("Usuário logado com sucesso");
                TxtUsuário.Clear();
                TxtSenha.Clear();

            }
            else
            {
                MessageBox.Show("Usuário ou senha errados");
                TxtUsuário.Clear();
                TxtSenha.Clear(); 
            }

            Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
