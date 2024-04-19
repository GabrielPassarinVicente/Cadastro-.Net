using Npgsql;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Categoria : Form
    {
        private string tipoSelecionado = "Funcionário";
        Conectar conexaoBD = new Conectar();


        public Categoria()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Categoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = textBox3.Text;
            string cod = textBox1.Text;

            using (NpgsqlConnection conn = conexaoBD.Conecta())
            {
                // Verifica se já existe um registro com o mesmo código ou categoria
                string sqlCheck = "SELECT COUNT(*) FROM cadCategoria WHERE codigo = @codigo OR categoria = @categoria";
                using (NpgsqlCommand cmdCheck = new NpgsqlCommand(sqlCheck, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@codigo", cod);
                    cmdCheck.Parameters.AddWithValue("@categoria", categoria);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um registro com o mesmo código ou categoria.");
                        return; // Sai do método sem inserir o registro
                    }
                }

                // Se não houver registro duplicado, insere o novo registro
                string sqlInsert = "INSERT INTO cadCategoria (codigo, categoria) VALUES (@codigo, @categoria)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", cod);
                    cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserido com sucesso.");
                    textBox1.Text = "";
                    textBox3.Text = "";
                }
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
