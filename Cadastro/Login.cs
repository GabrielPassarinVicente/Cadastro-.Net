using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace Cadastro
{
    public partial class Login : Form
    {
        Conectar conecta = new Conectar();
       
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = button1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';

            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
               
                button1_Click(sender, e);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection conn = conecta.Login())
            {
                string user = textBox1.Text;
                string senha = textBox2.Text;
                
                string sql = "SELECT COUNT(*) FROM Login WHERE usuario = @usuario AND senha = @senha";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@usuario", user);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        RegistrarLog(user);
                        Opçoes op = new Opçoes();
                        op.Show();
                        textBox1.Text = "";
                        textBox2.Text = "";
                        conn.Close();

                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário ou senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar fazer login: " + ex.Message);
                }
            }

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }

        private void novaSenha_Click(object sender, EventArgs e)
        {
            Redefinir senha = new Redefinir();
            senha.ShowDialog();
        }
        public void RegistrarLog(string user)
        {

            using (NpgsqlConnection conn = conecta.log())
            {
                // Verifica se já existe um registro para o usuário
                string sqlCheck = "SELECT COUNT(*) FROM log WHERE usuario = @usuario";
                NpgsqlCommand cmdCheck = new NpgsqlCommand(sqlCheck, conn);
                cmdCheck.Parameters.AddWithValue("@usuario", user);

                int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (count > 0)
                {
                    // Se o registro existir, atualiza-o
                    string sqlUpdate = "UPDATE log SET registro = @registro WHERE usuario = @usuario";
                    NpgsqlCommand cmdUpdate = new NpgsqlCommand(sqlUpdate, conn);
                    cmdUpdate.Parameters.AddWithValue("@usuario", user);
                    cmdUpdate.Parameters.AddWithValue("@registro", DateTime.Now);

                    try
                    {
                        cmdUpdate.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar o registro de log: " + ex.Message);
                    }
                }
                else
                {
                    // Se o registro não existir, insere um novo
                    string sqlInsert = "INSERT INTO log (usuario, registro) VALUES (@usuario, @registro)";
                    NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@usuario", user);
                    cmdInsert.Parameters.AddWithValue("@registro", DateTime.Now);

                    try
                    {
                        cmdInsert.ExecuteNonQuery();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir o novo registro de log: " + ex.Message);
                    }
                }
            }

        }

      
    }

}
