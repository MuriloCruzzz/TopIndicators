using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListagemUsuarios
{
    public class ListaDeUsuarios
    {
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=teste1;Uid=root;Pwd=123456789;");
        //public string connectionString;

        
        public void LerUsuarios(ListView listView1)
        {

            try
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT Id, Nome, id_setor FROM usuario";

                    using (var reader = command.ExecuteReader())
                    {

                        //listView1.View = View.Details;
                        //listView1.Columns.Add("ID");
                        //listView1.Columns.Add("Nome");
                        //listView1.Columns.Add("id_setor");

                        while (reader.Read())
                        {
                            string id = reader["id"].ToString();
                            string nome = reader["nome"].ToString();
                            string setor = reader["id_setor"].ToString();

                            ListViewItem item = new ListViewItem(id);
                            item.SubItems.Add(nome);
                            item.SubItems.Add(setor);

                            listView1.Items.Add(item);
                        }
                    }
                    connection.Close();
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}














































/*


namespace ListagemUsuarios
{
   

    public class ListaDeUsuarios
    {
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=teste1;Uid=root;Pwd=123456789;");
        public string connectionString;
        public void LerUsuarios(ListView listView1)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Setor");

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    //connection.Open();
                    command.CommandText = "SELECT Id, Nome, id_setor FROM usuario";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string id = reader["id"].ToString();
                            string nome = reader["nome"].ToString();
                            string setor = reader["setor"].ToString();

                            ListViewItem item = new ListViewItem(id);
                            item.SubItems.Add(nome);
                            item.SubItems.Add(setor);

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }

    }
}

*/