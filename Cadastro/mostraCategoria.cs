using Npgsql;
using System.Data;

namespace Cadastro
{
    public partial class mostraCategoria : Form
    {
        Conectar conexaoBD = new Conectar();

        public mostraCategoria()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnExcluir"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Verifica se a célula "codigo" não está vazia
                    if (dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value != null && !string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value.ToString()))
                    {
                        // Obtém o valor da célula da coluna "codigo" da linha a ser excluída
                        string codigo = dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value.ToString();

                        using (NpgsqlConnection conn = conexaoBD.Conecta())
                        {
                            string deleteSql = "DELETE FROM cadCategoria WHERE codigo = @codigo";
                            NpgsqlCommand cmd = new NpgsqlCommand(deleteSql, conn);
                            cmd.Parameters.AddWithValue("@codigo", codigo);
                            cmd.ExecuteNonQuery();

                            CarregarDados();

                            conn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possível excluir uma linha vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void CarregarDados()
        {
            using (NpgsqlConnection conn = conexaoBD.Conecta())
            {

                string sql = "SELECT codigo, categoria FROM cadCategoria"; 
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.Columns.Clear();

                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Exclui";
                btnColumn.Name = "btnExcluir";
                btnColumn.Text = "Excluir";
                btnColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(btnColumn);


                dataGridView1.DataSource = table;
                
                conn.Close();
            }
        }

        private void mostraCategoria_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
    }
}
