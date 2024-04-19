using Npgsql;

namespace Cadastro
{
    public partial class Cadastro : Form
    {
        Conectar conexaoDb = new Conectar();
        private string? sql;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = textCadastrar.Text;
                string senha = textBox1.Text;

                using (NpgsqlConnection conn = conexaoDb.Login())
                {
                    // Verifica se o usuário já existe no banco de dados
                    string verificaUsuarioQuery = "SELECT COUNT(*) FROM Login WHERE usuario = @usuario";
                    using (NpgsqlCommand verificaCmd = new NpgsqlCommand(verificaUsuarioQuery, conn))
                    {
                        verificaCmd.Parameters.AddWithValue("@usuario", usuario);
                        int count = Convert.ToInt32(verificaCmd.ExecuteScalar());

                        // Se o usuário já existir, exibe uma mensagem e sai do método
                        if (count > 0)
                        {
                            MessageBox.Show("Usuário já existe no banco de dados.");
                            return;
                        }
                    }

                    // Se o usuário não existir, executa a inserção
                    string sql = "INSERT INTO Login (usuario, senha) VALUES (@usuario, @senha)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textCadastrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0';

            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
