using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListagemDemanda
{
    public class ListarDemanda
    {
        //public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=teste1;Uid=root;Pwd=123456789;");
        //public string connectionString;


        public void LerDemanda(ListView listView2)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT id_Demanda, quantidade_Demandada, prazo, status, ID_Cliente, ID_Produto, qunatidade_produzida FROM demanda";

                        using (var reader = command.ExecuteReader())
                        {

                            //listView1.View = View.Details;
                            //listView1.Columns.Add("ID");
                            //listView1.Columns.Add("Nome");
                            //listView1.Columns.Add("id_setor");

                            while (reader.Read())
                            {
                                string id = reader["id_Demanda"].ToString();
                                string quantidade = reader["quantidade_Demandada"].ToString();
                                string prazo = reader["prazo"].ToString();
                                //string status = reader["status"].ToString();
                                string id_cliente = reader["ID_Cliente"].ToString();
                                string id_produto = reader["ID_Produto"].ToString();
                                string id_usuario = reader["qunatidade_produzida"].ToString();

                                ListViewItem item = new ListViewItem(id);
                                item.SubItems.Add(id);
                                item.SubItems.Add(quantidade);
                                item.SubItems.Add(prazo);
                                //item.SubItems.Add(status);
                                item.SubItems.Add(id_cliente);
                                item.SubItems.Add(id_produto);
                                item.SubItems.Add(id_usuario);

                                listView2.Items.Add(item);
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
}