using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql;

namespace IntegracaoOraculo
{
    class Usuarios
    {
        public static Contato getContato(int user_id)
        {
            try
            {
                using (SqlDataReader dr = Funcoes.getBuscaDinamicaSQLReader("*", "Contatos", ""))
                {
                    Contato cont = new Contato();
                    while (dr.Read())
                    {
                        Funcoes.preencheObjetos(dr, cont);
                    }
                    return cont;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
