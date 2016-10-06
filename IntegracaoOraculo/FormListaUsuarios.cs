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
    public partial class FormListaUsuarios : Form
    {
        private MySqlConnection conn = null;
        private MySqlDataAdapter da = null;
        private DataSet ds = null;
        public FormListaUsuarios()
        {
            InitializeComponent();
        }

        Properties.Settings prop = new Properties.Settings();
        private void atualizatela()
        {
            string cs = "Server=127.0.0.1;Port=3306;Database=insideensina;Uid=root;Pwd=;pooling = false; convert zero datetime=True";
            string stm = "SELECT * FROM wp_users";

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                ds = new DataSet();
                da = new MySqlDataAdapter(stm, conn);
                da.Fill(ds, "wp_users");

                dgvUsers.DataSource = ds.Tables["wp_users"];
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

        private void FormListaUsuarios_Load(object sender, EventArgs e)
        {
            atualizatela();
        }

        private void selecionaUsuario()
        {
            int selecionado = 0;
            try
            {
                selecionado = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            { }
            if (selecionado != 0 && selecionado != 1)
            {
 
            }
            else
            { }
        }
    }
}
