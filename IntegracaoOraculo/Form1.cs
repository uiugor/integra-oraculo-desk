using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IntegracaoOraculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Properties.Settings prop = new Properties.Settings();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Funcoes.getConexao())
            {
                prop.Servidor = prop.Servidor;
                prop.Banco = prop.Banco;
                prop.Usuario = prop.Usuario;
                prop.Senha = prop.Senha;
            }
            else
            {
                MessageBox.Show("A conexão não foi estabelecida. Verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            atualizaTela();
        }

        static string JustHash(string password)
        {
            phpBBCryptoServiceProvider cPhpBB = new phpBBCryptoServiceProvider();
            return cPhpBB.phpbb_hash(password);
        }
        private void atualizaTela()
        {
            Contato cont = new Contato();
            dgvContato.DataSource = Funcoes.getBuscaDinamica("Contatos.CodContato, Contatos.Nome, Contatos.Email, Contatos.Usuario, Contatos.Senha, Clientes.Nome+' - '+Contatos.Nome AS Display_Name", "Contatos", "INNER JOIN Clientes on (Contatos.CodCliente = Clientes.CodCliente)");
            dgvContato.Columns[0].Width = 70;
            dgvContato.Columns[1].Width = 220;
            dgvContato.Columns[2].Width = 200;
            dgvContato.Columns[3].Width = 200;
            dgvContato.Columns[4].Width = 200;
            dgvContato.Columns[5].Width = 380;
        }

        private void dgvContato_DoubleClick(object sender, EventArgs e)
        {
            string nome = dgvContato.SelectedRows[0].Cells[1].Value + string.Empty;
            string email = dgvContato.SelectedRows[0].Cells[2].Value + string.Empty;
            string usuario = dgvContato.SelectedRows[0].Cells[3].Value + string.Empty;
            string senhaOraculo = dgvContato.SelectedRows[0].Cells[4].Value + string.Empty;
            string display_name = dgvContato.SelectedRows[0].Cells[5].Value + string.Empty;
            string descripOraculo = "";
            string senha = "";
            var connString = "Server=127.0.0.1;Port=3306;Database=insideensina;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            //Descriptografa senha do Oraculo que vem da GRID
            try
            {
                int ln1 = default(int);
                for (int i = 0; i != senhaOraculo.Length; i++)
                {
                    ln1 = Convert.ToInt32(Convert.ToChar(senhaOraculo.Substring(i, 1))) - 23;
                    descripOraculo += Convert.ToChar(ln1);
                }
                senha = descripOraculo;
            }
            catch (Exception erro)
            {
                throw (new Exception(erro.Message + " - " + erro.Source));
            }

            //Criptografa senha para padrão PHPASS
            try
            {
                senha = JustHash(senha);
            }
            catch (Exception erro)
            {
                throw (new Exception(erro.Message + " - " + erro.Source));
            }

            //Abre Conexão e Insere dados no banco MYSQL
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    command.CommandText = "INSERT INTO wp_users (user_login,user_pass,user_nicename,user_email,user_url,user_registered,user_activation_key,user_status,display_name) VALUES "
                        + "(" + "'" + (@usuario) + "', " + "'" + (@senha) + "'," + "'" + (@nome.Replace(' ', '.')) + "'," + "'" + (@email) + "'," + "''," + "''," + "''," + "''," + "'" + (@display_name) + "'" + ");";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Usuário inserido com sucesso","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao inserir cliente, verifique a conexão com o MYSQL!");
            }


        }

        public void dgvContato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvContato.SelectedRows.Count > 0)
            {
                string nome = dgvContato.SelectedRows[0].Cells[1].Value + string.Empty;
                string email = dgvContato.SelectedRows[0].Cells[2].Value + string.Empty;
                string usuario = dgvContato.SelectedRows[0].Cells[3].Value + string.Empty;
                string senha = dgvContato.SelectedRows[0].Cells[4].Value + string.Empty;
                string displayName = dgvContato.SelectedRows[0].Cells[5].Value + string.Empty;
                string txtdescrip = "";
                string phpass = "";
                try
                {
                    int ln1 = default(int);
                    for (int i = 0; i != senha.Length; i++)
                    {
                        ln1 = Convert.ToInt32(Convert.ToChar(senha.Substring(i, 1))) - 23;
                        txtdescrip += Convert.ToChar(ln1);
                    }
                    phpass = txtdescrip;
                }
                catch (Exception erro)
                {
                    throw (new Exception(erro.Message + " - " + erro.Source));
                }

                try
                {
                    phpass = JustHash(phpass);
                }
                catch (Exception erro)
                {
                    throw (new Exception(erro.Message + " - " + erro.Source));
                }

                txtNome.Text = "INSERT INTO wp_users (user_login,user_pass,user_nicename,user_email,user_url,user_registered,user_activation_key,user_status,display_name) VALUES " 
                    + "(" + "'" + (@usuario) + "', " + "'" + (@phpass) + "'," + "'" + (@nome.Replace(' ','.')) + "'," + "'" + (@email) + "'," + "''," + "''," + "''," + "''," + "'" + (@displayName) + "'" + ");";
            }
        }

        private void btMysql_Click(object sender, EventArgs e)
        {
            var connString = "Server=127.0.0.1;Port=3306;Database=insideensina;Uid=root;Pwd=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar MySql!");
            }
            if (connection.State == ConnectionState.Open)
            {
                command.CommandText = "INSERT INTO wp_users (user_login,user_pass,user_nicename,user_email,user_url,user_registered,user_activation_key,user_status,display_name) VALUES ('11testeee','11FASadSD','11IRGO_TESTE','11teste@bol.com','','','','','11IGRO_TESTE');";
                command.ExecuteNonQuery();
                //MySqlCommand cmdS = new MySqlCommand("INSERT INTO wp_users (user_login,user_pass,user_nicename,user_email,user_url,user_registered,user_activation_key,user_status,display_name) VALUES ('11testeee','11FASadSD','11IRGO_TESTE','11teste@bol.com','','','','','11IGRO_TESTE');");
                //cmdS.BeginExecuteNonQuery();
                //cmdS.ExecuteNonQuery();
            }
            
        }

        private void lblinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: igor_confetti@hotmail.com", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            FormListaUsuarios fmr = new FormListaUsuarios();
            fmr.Show();
        }

        private void btModulo_Click(object sender, EventArgs e)
        {
            FormCadastraCurso fmrCC = new FormCadastraCurso();
            fmrCC.Show();
        }
    }
}
