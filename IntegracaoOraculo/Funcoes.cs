using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace IntegracaoOraculo
{
    class Funcoes
    {

        private static SqlConnection conn = new SqlConnection();

        public static bool connConectada = false;
        public static bool getConexao()
        {
            try
            {
                Properties.Settings propriedades = new Properties.Settings();
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = propriedades.Servidor;
                builder.InitialCatalog = propriedades.Banco;
                builder.UserID = propriedades.Usuario;
                builder.Password = propriedades.Senha;
                builder.PersistSecurityInfo = true;
                builder.MinPoolSize = 5;
                builder.MaxPoolSize = 250;

                conn.ConnectionString = builder.ToString();
                conn.Open();
                connConectada = true;
                return true;
            }
            catch (Exception erro)
            {
                return false;
                throw (new Exception(erro.Source + " - " + erro.Message));
            }
        }

        public static SqlConnection getConn()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                return conn;
            else if (getConexao())
                return conn;
            else
                return null;
        }

        public static void showDialog(Form form)
        {
            form.BringToFront();
            form.ShowDialog();
            form.Dispose();
        }

        public static void show(Form form)
        {
            form.Show();
            form.BringToFront();
        }

        public static DateTime dataBanco()
        {
            DateTime retorno = DateTime.Now;
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = Funcoes.getConn();
                cmd.CommandText = "Select GETDATE()";
                retorno = Convert.ToDateTime(cmd.ExecuteScalar());
            }
            return retorno;
        }

        //Buscas e Lists
        public static SqlDataReader getBuscaDinamicaSQLReader(string campo, string tabela, string condicao)
        {
            SqlDataReader dr = null;
            using (SqlCommand cmd = new SqlCommand("SELECT " + campo + " FROM " + tabela + " " + condicao, Funcoes.getConn()))
            {
                dr = cmd.ExecuteReader();
            }
            return dr;
        }

        public static DataTable getBuscaDinamica(string campo, string tabela, string condicao)
        {
            DataTable dr = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SELECT " + campo + " FROM " + tabela + " " + condicao, Funcoes.getConn()))
            {
                dr.Load(cmd.ExecuteReader());
            }
            return dr;
        }
        public static void preencheObjetos(SqlDataReader reader, Object objeto)
        {
            FieldInfo[] propriedades = objeto.GetType().GetFields();
            String nomeDoCampo = "";
            for (int i = 0; i < reader.FieldCount; i++)
            {
                nomeDoCampo = reader.GetName(i);

                if (!string.IsNullOrEmpty(reader[i].ToString()))
                {
                    foreach (FieldInfo p in propriedades)
                    {
                        if (p.Name == nomeDoCampo)
                        {
                            if (reader[i].GetType().Name == System.TypeCode.Decimal.ToString())
                            {
                                if (p.FieldType.Name == System.TypeCode.Decimal.ToString())
                                {
                                    p.SetValue(objeto, Convert.ToDecimal(reader.GetValue(i)));
                                }
                                else
                                {
                                    p.SetValue(objeto, Convert.ToInt32(reader.GetValue(i)));
                                }
                            }
                            else if (reader[i].GetType().Name == System.TypeCode.Single.ToString())
                            {
                                p.SetValue(objeto, Convert.ToDecimal(reader.GetValue(i)));
                            }
                            else
                            {
                                p.SetValue(objeto, reader.GetValue(i) == DBNull.Value ? reader.GetValue(i).ToString() : reader.GetValue(i));
                            }
                            break;
                        }
                    }
                }
            }
        }

        ////public static void ExportaUsuariosExcel(DataGridView dataGrid, string NomeFile, string SomaQntProdutos, string valorTotal)
        ////{
        ////    Excel.Application xlApp;
        ////    Excel.Workbook xlWorkBook;
        ////    Excel.Worksheet xlWorkSheet;
        ////    object misValue = System.Reflection.Missing.Value;

        ////    xlApp = new Excel.ApplicationClass();
        ////    xlWorkBook = xlApp.Workbooks.Add(misValue);

        ////    try
        ////    {
        ////        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

        ////        //add o cabeçalho das colunas
        ////        for (int i = 0; i < dataGrid.ColumnCount; i++)
        ////        {
        ////            xlWorkSheet.Cells[1, i + 1] = dataGrid.Columns[i].HeaderText;
        ////        }

        ////        //add o dados das colunas
        ////        for (int i = 2; i < dataGrid.RowCount + 2; i++)
        ////        {
        ////            for (int j = 0; j < dataGrid.ColumnCount; j++)
        ////            {
        ////                xlWorkSheet.Cells[i, j + 1] = dataGrid[j, i - 2].Value.ToString().Replace("\r\n", " ");
        ////            }
        ////        }

        ////        xlWorkSheet.Cells[dataGrid.RowCount + 3, 1] = "Total de Produtos:";
        ////        xlWorkSheet.Cells[dataGrid.RowCount + 3, 2] = SomaQntProdutos;
        ////        xlWorkSheet.Cells[dataGrid.RowCount + 3, 3] = "Valor Total:";
        ////        xlWorkSheet.Cells[dataGrid.RowCount + 3, 4] = valorTotal;

        ////        xlWorkBook.SaveAs(NomeFile, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
        ////        xlWorkBook.Close(true, misValue, misValue);
        ////        xlApp.Quit();
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        throw new Exception(ex.Message + "\nExportaExcel");
        ////    }

        ////    releaseObject(xlWorkSheet);
        ////    releaseObject(xlWorkBook);
        ////    releaseObject(xlApp);
        ////}

        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception(ex.Message + "\nreleaseObject");
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
