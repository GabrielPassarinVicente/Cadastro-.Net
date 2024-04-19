using Npgsql;
using System.Data;

namespace Cadastro;

public partial class Cadastros : Form
{
   
    private NpgsqlConnection conexao;
    Conectar conectar = new Conectar();
    public Cadastros()
    {
        InitializeComponent();
    }

    private void Cadastros_Load(object sender, EventArgs e)
    {
        CarregarDados();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

        if (e.ColumnIndex == dataGridView1.Columns["btnExcluir"].Index && e.RowIndex >= 0)
        {
            // Verifica se a célula "codigo" não está vazia
            if (dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value != null && !string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value.ToString()))
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta linha?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Obtém o valor da célula da coluna "codigo" da linha a ser excluída
                    int codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["codigo"].Value);

                    using (NpgsqlConnection conn = conectar.Conectando())
                    {
                        string deleteSql = "DELETE FROM Db_Cadastro WHERE codigo = @codigo";
                        NpgsqlCommand cmd = new NpgsqlCommand(deleteSql, conn);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                        cmd.ExecuteNonQuery();

                        CarregarDados();

                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Não é possível excluir uma linha vazia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    private void CarregarDados()
    {
        using (NpgsqlConnection conn =conectar.Conectando())
        {
           

            string sql = "SELECT * FROM Db_Cadastro"; 
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.Columns.Clear();

            // Adicionar coluna de botão
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
}

