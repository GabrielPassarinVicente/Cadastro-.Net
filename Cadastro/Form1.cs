using Npgsql;
using System.Text.RegularExpressions;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        private string tipoSelecionado = "Pessoa Fisíca";


        Conectar conexaoBD = new Conectar();

        public Form1()
        {
            InitializeComponent();
            listTipo.Items.Add("Pessoa Fisíca");
            listTipo.Items.Add("Pessoa Juridica");

            listTipo.SelectedIndex = 0;

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidarCPF(string cpf)
        {
            // Remover caracteres não numéricos
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verificar se o CPF tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verificar se todos os dígitos são iguais, o que torna o CPF inválido
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Algoritmo para validar CPF
            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            int soma, resto;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadoresPrimeiroDigito[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (resto != int.Parse(cpf[9].ToString()))
                return false;

            tempCpf = cpf.Substring(0, 10);
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadoresSegundoDigito[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (resto != int.Parse(cpf[10].ToString()))
                return false;

            return true;
        }

        private bool ValidarCNPJ(string cnpj)
        {
            // Remover caracteres não numéricos
            cnpj = Regex.Replace(cnpj, @"[^\d]", "");

            // Verificar se o CNPJ tem 14 dígitos
            if (cnpj.Length != 14)
                return false;

            // Verificar se todos os dígitos são iguais, o que torna o CNPJ inválido
            if (new string(cnpj[0], 14) == cnpj)
                return false;

            // Algoritmo para validar CNPJ
            int[] multiplicadoresPrimeiroDigito = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCnpj;
            int soma, resto;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadoresPrimeiroDigito[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (resto != int.Parse(cnpj[12].ToString()))
                return false;

            tempCnpj = cnpj.Substring(0, 13);
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicadoresSegundoDigito[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            if (resto != int.Parse(cnpj[13].ToString()))
                return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipo();
            Dados();
            if (string.IsNullOrEmpty(textBox2.Text))
            {


            }
            else
            {
                Inserir();
            }




        }
        private void Dados()
        {


            string nome = textBox1.Text.Trim();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, insira um nome.");
                return;
            }

            DateTime dataNascimento = dateTimePicker1.Value.Date;

            string tipoPessoa = listTipo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipoPessoa))
            {
                MessageBox.Show("Por favor, selecione um tipo de pessoa.");
                return;
            }

            string documento = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Por favor, insira um documento.");
                return;
            }

            string endereco = textBox3.Text.Trim();

            string contato = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(contato))
            {
                MessageBox.Show("Por favor, insira um contato.");
                return;
            }

            string email = textBox5.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, insira um email.");
                return;
            }

            string observacao = textBox6.Text.Trim();
        }
        private void Inserir()
        {

            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                txtCod.Text = "1"; // Define o código como 1 se estiver vazio
            }

            int codigo = int.Parse(txtCod.Text);
            string nome = textBox1.Text;
            DateTime dataNascimento = dateTimePicker1.Value.Date;
            string tipoPessoa = listTipo.SelectedItem.ToString();
            string documento = textBox2.Text;
            string enderco = textBox3.Text;
            string contato = textBox4.Text;
            string email = textBox5.Text;
            string observacao = textBox6.Text;
            string categoria = label8.Text;

            using (NpgsqlConnection conn = conexaoBD.Conectando())
            {
                // Verificando se já existe um registro com o mesmo código, nome ou CPF
                string sqlCheck = "SELECT COUNT(*) FROM Db_Cadastro WHERE codigo = @codigo OR nome = @nome OR documento = @documento";
                using (NpgsqlCommand cmdCheck = new NpgsqlCommand(sqlCheck, conn))
                {
                    cmdCheck.Parameters.AddWithValue("@codigo", codigo);
                    cmdCheck.Parameters.AddWithValue("@nome", nome);
                    cmdCheck.Parameters.AddWithValue("@documento", documento);

                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um registro com o mesmo código, nome ou CPF.");
                        return; // Sai do método sem inserir o registro
                    }
                }

                // Se não houver registro duplicado, insere o novo registro
                string sqlInsert = "INSERT INTO Db_Cadastro (codigo, nome, dataNascimento, tipoPessoa, documento, enderco, contato, email, observacao, categoria) VALUES (@codigo, @nome, @dataNascimento, @tipoPessoa, @documento, @enderco, @contato, @email, @observacao, @categoria)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sqlInsert, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                    cmd.Parameters.AddWithValue("@tipoPessoa", tipoPessoa);
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@enderco", enderco);
                    cmd.Parameters.AddWithValue("@contato", contato);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@observacao", observacao);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gravado com sucesso");
                    conn.Close();   
                    // Limpa os campos após a inserção
                    LimparCampos();
                }
            }

        }
        private void LimparCampos()
        {
            txtCod.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            label8.Text = "";
        }

        private void tipo()
        {
            string texto = textBox2.Text;

            if (tipoSelecionado == "Pessoa Fisíca")
            {
                if (ValidarCPF(texto))
                {
                    return;
                }
                else
                {
                    MessageBox.Show("CPF inválido!");
                }
            }
            else if (tipoSelecionado == "Pessoa Juridica")
            {
                if (ValidarCNPJ(texto))
                {
                    return;

                }
                else
                {
                    MessageBox.Show("CNPJ inválido!");
                }
            }
        }

        private void listTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoSelecionado = listTipo.SelectedItem.ToString();

        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string input = textBox4.Text;

            string digitsOnly = Regex.Replace(input, @"[^\d]", "");

            if (digitsOnly.Length >= 10)
            {
                string formattedNumber = Regex.Replace(digitsOnly, @"(\d{2})(\d{3})(\d{4})", "($1) $2-$3");
                textBox4.Text = formattedNumber;
            }
            else
            {

                textBox4.Text = digitsOnly;
            }

            // Define o cursor para o final do texto após a formatação
            textBox4.SelectionStart = textBox4.Text.Length;


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Endereco_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            BuscarCategoriaPorCodigo();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void BuscarCategoriaPorCodigo()
        {
            string codigo = textBox7.Text;
           ;
            using (NpgsqlConnection conn = conexaoBD.Conecta())
            {
                string sql = "SELECT categoria FROM cadCategoria WHERE codigo = @codigo";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche a label8 com a categoria
                            label8.Text = reader["categoria"].ToString();
                        }
                        else
                        {
                            // Caso nenhum resultado seja encontrado
                            label8.Text = "Categoria não encontrada";
                        }


                    }
                }
            }
        }
    }


}
