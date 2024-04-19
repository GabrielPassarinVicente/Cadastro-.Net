using Npgsql;

namespace Cadastro
{
    public partial class Adm : Form
    {
        Conectar conecta = new Conectar();

        public Adm()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

        }
        private void Adm_Load(object sender, EventArgs e)
        {

        }
        private void Adm_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Chama o método button1_Click para simular o clique no botão
                button1_Click(sender, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = conecta.log())
            {
                string senhaAdministradora = textBox1.Text;

                string sql = "SELECT COUNT(*) FROM log WHERE senhaAdministradora = @senhaAdministradora";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@senhaAdministradora", senhaAdministradora);

                try
                {

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {

                        Logins obj = new Logins();
                        obj.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Senha incorretos.");
                    }
                }catch (Exception ex) { }
            }
        }
    }
}
             

        
       



