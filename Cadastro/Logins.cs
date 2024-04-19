using ClosedXML.Excel;
using Npgsql;
using System.Data;

namespace Cadastro
{
    public partial class Logins : Form
    {
        Conectar conectar = new Conectar();
        System.Windows.Forms.Timer timer;

        public Logins()
        {
            InitializeComponent();


            // Configurar o Timer para chamar o método LimparBanco a cada 10 dias
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)TimeSpan.FromDays(1).TotalMilliseconds; // Verifica a cada dia
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void LimparBanco()
        {
            using (NpgsqlConnection conn = conectar.log())
            {
                // Defina sua lógica de limpeza do banco aqui
                string sql = "DELETE FROM log WHERE data_registro < current_date - interval '10 days'";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registros antigos foram removidos do banco de dados.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não há registros antigos para remover.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conn.Close();
            }
        }
       
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan diff = GetTimeUntilNextCleanup();
            MessageBox.Show($"Os registros antigos serão excluídos em {diff.Days} dias.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparBanco();
        }

        private TimeSpan GetTimeUntilNextCleanup()
        {
            DateTime today = DateTime.Today;
            int daysUntilNextCleanup = 10 - ((today.Day - 25) % 10);
            if (daysUntilNextCleanup <= 0) // Se a limpeza for hoje ou já passou
            {
                daysUntilNextCleanup = 10 - ((today.Day - 25) % 10) + 10; // O próximo múltiplo de 10 será no próximo mês
            }
            DateTime nextCleanup = today.AddDays(daysUntilNextCleanup);
            return nextCleanup - today;
        }
        private void dataGridViewLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarDados()
        {
            using (NpgsqlConnection conn = conectar.log())
            {


                string sql = "SELECT usuario, registro FROM log "; // Substitua "sua_tabela" pelo nome da tabela que deseja consultar
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Preencher a DataGridView com os resultados da consulta
                dataGridViewLogin.DataSource = table;
                conn.Close();
            }
        }

        private void Logins_Load(object sender, EventArgs e)
        {
            CarregarDados();

            TimeSpan diff = GetTimeUntilNextCleanup();
            MessageBox.Show($"Os registros antigos serão excluídos em {diff.Days} dias.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarParaExcel();

        }
        private void ExportarParaExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook|*.xlsx",
                ValidateNames = true
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable dt = (DataTable)dataGridViewLogin.DataSource;
                        workbook.Worksheets.Add(dt, "Logins");

                        try
                        {
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Dados exportados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao exportar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
