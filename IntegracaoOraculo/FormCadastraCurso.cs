using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace IntegracaoOraculo
{
    public partial class FormCadastraCurso : Form
    {
        private MySqlConnection conn = null;
        private MySqlDataAdapter da = null;
        private DataSet ds = null;
        public FormCadastraCurso()
        {
            InitializeComponent();
        }
        private void atualizatela()
        {
            string cs = "Server=127.0.0.1;Port=3306;Database=insideensina;Uid=root;Pwd=;pooling = false; convert zero datetime=True";
            string stm = "SELECT ID, display_name, user_email, user_login FROM wp_users;";

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                ds = new DataSet();
                da = new MySqlDataAdapter(stm, conn);
                da.Fill(ds, "wp_users");

                dgvAlunosCurso.DataSource = ds.Tables["wp_users"];
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void FormCadastraCurso_Load(object sender, EventArgs e)
        {
            atualizatela();
        }

        private void dgvAlunosCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunosCurso.SelectedRows.Count > 0)
            {
                string id = dgvAlunosCurso.SelectedRows[0].Cells[0].Value + string.Empty;

                string cs = "Server=127.0.0.1;Port=3306;Database=insideensina;Uid=root;Pwd=;pooling = false; convert zero datetime=True";
                string stm = @"SELECT wp_usermeta.meta_key AS 
                               Cursos FROM `wp_users` INNER JOIN 
                               wp_usermeta ON (wp_users.ID = wp_usermeta.user_id) WHERE 
                               wp_usermeta.meta_key LIKE 'course_status%' AND wp_users.ID = " + @id;
                try
                {
                    conn = new MySqlConnection(cs);
                    conn.Open();
                    ds = new DataSet();
                    da = new MySqlDataAdapter(stm, conn);
                    da.Fill(ds, "wp_users");

                    dgvCusosAlunos.DataSource = ds.Tables["wp_users"];
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            string id = dgvAlunosCurso.SelectedRows[0].Cells[0].Value + string.Empty;
            string meta_key_compras = "";
            string meta_key_estoque = "";
            string meta_key_faturamento = "";
            string meta_key_financeiro = "";
            string meta_key_gerencial = "";
            string meta_key_operacional = "";
            string meta_key_rastreamento = "";
            string meta_key_suporte = "";
            string meta_key_cadastros = "";

            if (cbCompras.Checked == true)
            {
                meta_key_compras = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2244','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2244','1476471410'); ";
            }
            if (cbEstoque.Checked == true)
            {
                meta_key_estoque = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2303','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2303','1476471410'); ";
            }
            if (cbFaturamento.Checked == true)
            {
                meta_key_faturamento = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2291','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2291','1476471410'); ";
            }
            if (cbFinanceiro.Checked == true)
            {
                meta_key_financeiro = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2305','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2305','1476471410'); ";
            }
            if (cbGerencial.Checked == true)
            {
                meta_key_gerencial = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2307','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2307','1476471410'); ";
            }
            if (cbOperacional.Checked == true)
            {
                meta_key_operacional = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2297','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2297','1476471410'); ";
            }
            if (cbRastreamento.Checked == true)
            {
                meta_key_rastreamento = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status3403','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'3403','1476471410'); ";
            }
            if (cbSuporte.Checked == true)
            {
                meta_key_suporte = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2309','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2309','1476471410'); ";
            }
            if (cbCadastros.Checked == true)
            {
                meta_key_cadastros = "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES  ('" + @id + "'," + "'course_status2236','1'); " +
                    "INSERT INTO wp_usermeta (user_id,meta_key,meta_value) VALUES ('" + @id + "'," + "'2236','1476471410'); ";
            }

            if (dgvAlunosCurso.SelectedRows.Count > 0)
            {
                var command = conn.CreateCommand();
              
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        command.CommandText = meta_key_compras + meta_key_cadastros  + meta_key_estoque + meta_key_faturamento + meta_key_financeiro + meta_key_gerencial
                            + meta_key_operacional + meta_key_rastreamento + meta_key_suporte;
                        command.ExecuteNonQuery();

                        MessageBox.Show("Modulos inseridos com sucesso!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
                finally
                {
                    if (conn != null)
                    {
                        atualizatela();
                        conn.Close();
                    }
                }
                cbSuporte.Checked = false;
                cbRastreamento.Checked = false;
                cbOperacional.Checked = false;
                cbGerencial.Checked = false;
                cbFinanceiro.Checked = false;
                cbFaturamento.Checked = false;
                cbEstoque.Checked = false;
                cbCompras.Checked = false;
                cbCadastros.Checked = false;

            }
        }

        private void cbCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvCusosAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2309") > -1))
                    {
                        e.Value = "Suporte";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2236") > -1))
                    {
                        e.Value = "Cadastros";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2307") > -1))
                    {
                        e.Value = "Gerencial";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2305") > -1))
                    {
                        e.Value = "Financeiro";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2303") > -1))
                    {
                        e.Value = "Estoque";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2297") > -1))
                    {
                        e.Value = "Operacional";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2291") > -1))
                    {
                        e.Value = "Faturamento";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status3403") > -1))
                    {
                        e.Value = "Rastreamento";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

            if (dgvCusosAlunos.Columns[e.ColumnIndex].Name == "Cursos")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    stringValue = stringValue.ToLower();
                    if ((stringValue.IndexOf("course_status2244") > -1))
                    {
                        e.Value = "Compras";
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }

                }
            }

        }
    }
}
