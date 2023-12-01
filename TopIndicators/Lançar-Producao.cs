using K4os.Compression.LZ4.Internal;
using Microsoft.ReportingServices.Diagnostics.Internal;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;


namespace TopIndicators
{
    public partial class Form1 : Form
    {
        private int idLinha;
        private SqlConnection connection;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        public int id_producao { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            int id_producao = this.id_producao;
            int status_producao = 0;
            // Conecte-se ao banco de dados
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Execute a consulta
            string query = "SELECT status_producao FROM producao_linha WHERE id_producao = @id_producao";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_producao", id_producao);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Itere sobre os resultados da consulta
                    while (reader.Read())
                    {
                        // Pegue os valores dos campos da consulta
                        status_producao = (int)reader["status_producao"];//
                    }
                }
                connection.Close();
            }
            if (status_producao == 0)
            {
                // Conecte-se ao banco de dados
                cmb_homens.Text = "0";
                MySqlConnection connection4 = new MySqlConnection(connectionString);
                connection4.Open();

                // Execute a consulta
                string query4 = "SELECT id_produto_acabado, id_producao, id_produto_materia_prima, id_produto_material, quantidade_produzidas,quantidade_demanda_atual, tempo_parada_linha, quantidade_operadores, turno" +
                    " FROM producao_linha WHERE id_producao = @id_producao";
                MySqlCommand command4 = new MySqlCommand(query4, connection4);
                command4.Parameters.AddWithValue("@id_producao", id_producao);

                using (MySqlDataReader reader4 = command4.ExecuteReader())
                {
                    if (reader4.HasRows)
                    {
                        // Itere sobre os resultados da consulta
                        while (reader4.Read())
                        {
                            // Pegue os valores dos campos da consulta
                            string idProdutoAcabado = reader4["id_produto_acabado"].ToString();//
                            int idProducao = (int)reader4["id_producao"];//
                            int idProdutoMateriaPrima = (int)reader4["id_produto_materia_prima"];//
                            int idProdutoMaterial = (int)reader4["id_produto_material"];//
                            int quantidadeProduzidas = (int)reader4["quantidade_produzidas"];//
                            int quantidadeDemandaAtual = (int)reader4["quantidade_demanda_atual"];//
                            string tempo_parada_linha = reader4["tempo_parada_linha"].ToString();////
                            cmb_homens.Text = reader4["quantidade_operadores"].ToString();////
                            lbl_turno.Text = reader4["turno"].ToString();////

                            // Armazene os valores nas label.text
                            tvb_cod_linha.Text = id_producao.ToString();
                            //cod_materia_prima.Text = idProdutoMateriaPrima.ToString();
                            blb_nome_Linha.Text = idProdutoAcabado;
                            text_demanda.Text = quantidadeDemandaAtual.ToString();
                            //cod_material.Text = idProdutoMaterial.ToString();
                            txb_produzidas.Text = quantidadeProduzidas.ToString();
                            ID_pac.Text = idProdutoAcabado.ToString();
                            maskedTextBox4.Text = tempo_parada_linha;


                        }
                        string connectionStringX = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;"; // Substitua pela sua própria string de conexão

                        using (MySqlConnection connectionX = new MySqlConnection(connectionStringX))
                        {
                            try
                            {
                                connectionX.Open();

                                string queryX = "SELECT Material_Consumo, Materia_Prima_Consumo FROM produto_acabado WHERE Nome = @Nome";
                                MySqlCommand commandCreate2X = new MySqlCommand(queryX, connectionX);

                                commandCreate2X.Parameters.AddWithValue("@Nome", ID_pac.Text);

                                using (MySqlDataReader reader = commandCreate2X.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        // Adiciona as opções ao ComboBox
                                        while (reader.Read())
                                        {
                                            cod_material.Text = reader["Material_Consumo"].ToString();
                                            cod_materia_prima.Text = reader["Materia_Prima_Consumo"].ToString();

                                            connectionX.Close();
                                        }
                                    }
                                }
                            }
                            catch { }

                        }
                    }
                    connection4.Close();
                }
                
               
                
            }
            if(status_producao == 1)
            {
                // Conecte-se ao banco de dados

                MySqlConnection connection4 = new MySqlConnection(connectionString);
                connection4.Open();

                // Execute a consulta
                string query4 = "SELECT id_produto_acabado, id_producao, id_produto_materia_prima, id_produto_material, quantidade_produzidas,quantidade_demanda_atual, tempo_parada_linha, hora_inicial, quantidade_refugo_materia_prima, quantidade_refugo_material, quantidade_refugo_produto_acabado, quantidade_produzidas, quantidade_operadores, turno    " +
                    "FROM producao_linha WHERE id_producao = @id_producao";
                MySqlCommand command4 = new MySqlCommand(query4, connection4);
                command4.Parameters.AddWithValue("@id_producao", id_producao);

                using (MySqlDataReader reader4 = command4.ExecuteReader())
                {
                    if (reader4.HasRows)
                    {
                        // Itere sobre os resultados da consulta
                        while (reader4.Read())
                        {
                            // Pegue os valores dos campos da consulta
                            string idProdutoAcabado = reader4["id_produto_acabado"].ToString();//
                            int idProducao = (int)reader4["id_producao"];//
                            int idProdutoMateriaPrima = (int)reader4["id_produto_materia_prima"];//
                            int idProdutoMaterial = (int)reader4["id_produto_material"];//
                            int quantidadeProduzidas = (int)reader4["quantidade_produzidas"];//
                            int quantidadeDemandaAtual = (int)reader4["quantidade_demanda_atual"];
                            int quantidade_operadores = (int)reader4["quantidade_operadores"];
                            //
                            string tempo_parada_linha = reader4["tempo_parada_linha"].ToString();//

                            string hora_inicial = reader4["hora_inicial"].ToString();

                            lbl_turno.Text = reader4["turno"].ToString(); //



                            // Obtém a hora da DateTime
                            int hora = DateTime.Parse(tempo_parada_linha).Hour;
                            int hora1 = DateTime.Parse(hora_inicial).Hour;

                            // Obtém o minuto da DateTime
                            int minuto = DateTime.Parse(tempo_parada_linha).Minute;
                            int minuto1 = DateTime.Parse(hora_inicial).Minute;

                            // Armazena a hora e minuto na variável
                            tempo_parada_linha = $"{hora:00}:{minuto:00}";
                            hora_inicial = $"{hora1:00}:{minuto1:00}";

                            int quantidade_refugo_materia_prima = (int)reader4["quantidade_refugo_materia_prima"];//
                            int quantidade_refugo_material = (int)reader4["quantidade_refugo_material"];//
                            int quantidade_refugo_produto_acabado = (int)reader4["quantidade_refugo_produto_acabado"];//
                            int quantidade_produzidas = (int)reader4["quantidade_produzidas"];//

                            DateTime agora = DateTime.Now;

                            // Obtém o horário inicial da produção
                            DateTime inicioProducao = Convert.ToDateTime(hora_inicial);

                            // Calcula o tempo de produção
                            TimeSpan tempoProducao = agora - inicioProducao;

                            // Obtém as horas e os minutos do tempo de produção
                            int horas = tempoProducao.Hours;
                            int minutos = tempoProducao.Minutes;

                            // Define o texto do textbox
                            textBox7.Text = $"{horas:00}:{minutos:00}";//TimeSpan horaMinuto = tempo_parada_linha.TimeOfDay;

                            // Armazena a hora e minuto na variável
                            //string horaMinutoFormatada = horaMinuto.ToString("HH:mm");
                            cmb_homens.Text = quantidade_operadores.ToString();
                            maskedTextBox4.Text = tempo_parada_linha;
                            maskedTextBox2.Text = hora_inicial;
                            maskedTextBox5.Text = quantidade_refugo_materia_prima.ToString();
                            maskedTextBox7.Text = quantidade_refugo_material.ToString();
                            maskedTextBox6.Text = quantidade_refugo_produto_acabado.ToString();
                            txb_produzidas.Text = quantidade_produzidas.ToString();

                            // Armazene os valores nas label.text
                            tvb_cod_linha.Text = id_producao.ToString();
                            //cod_materia_prima.Text = idProdutoMateriaPrima.ToString();
                            blb_nome_Linha.Text = idProdutoAcabado;
                            text_demanda.Text = quantidadeDemandaAtual.ToString();
                            cod_material.Text = idProdutoMaterial.ToString();
                            txb_produzidas.Text = quantidadeProduzidas.ToString();
                            ID_pac.Text = idProdutoAcabado.ToString();
                        }
                    }
                    connection4.Close();

                    string query_paradas = "SELECT tempo, tipo FROM paradas_linha_producao WHERE id_producao = @id_producao";
                    MySqlCommand command_paradas = new MySqlCommand(query_paradas, connection4);
                    command_paradas.Parameters.AddWithValue("@id_producao", id_producao);
                    connection4.Open();

                    using (MySqlDataReader reader2 = command_paradas.ExecuteReader())
                    {
                        if (reader2.HasRows)
                        {
                            // Itere sobre os resultados da consulta
                            while (reader2.Read())
                            {
                                string tempoParada = reader2["tempo"].ToString();

                                string horaMinutoSegundo = "12:34:56";

                                // Obtém o índice do caractere ':' após a hora
                                int indiceSeparador = tempoParada.IndexOf(":", 2);

                                // Obtém a subcadeia dos minutos e segundos
                                string minutoSegundo = tempoParada.Substring(indiceSeparador + 1);

                                // Verifica se o minuto é zero
                                bool minutoZero = minutoSegundo[0] == '0';

                                // Verifica se o segundo é zero
                                bool segundoZero = minutoSegundo[2] == '0';

                                // Se o minuto for zero, adiciona um zero antes
                                if (minutoZero)
                                {
                                    minutoSegundo = "0" + minutoSegundo.Substring(1);
                                }

                                // Se o segundo for zero, adiciona um zero antes
                                if (segundoZero)
                                {
                                    minutoSegundo = minutoSegundo.Substring(0, 2) + "0" + minutoSegundo.Substring(3);
                                }


                                string tipoProducao = reader2["tipo"].ToString();
                                Button botaoParada = new Button();
                                botaoParada.Text = $"Tempo: {minutoSegundo}, Tipo: {tipoProducao}";
                                botaoParada.Dock = DockStyle.Top;
                                botaoParada.ForeColor = Color.Black;
                                botaoParada.BackColor = Color.LightBlue;// Para empilhar os botões de cima para baixo

                                // Adicione o botão ao Panel
                                panel5.Controls.Add(botaoParada);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado de paradas de linha.");
                        }
                    }
                    connection4.Close();

                }
                
                
                string connectionStringX = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;"; // Substitua pela sua própria string de conexão

                using (MySqlConnection connectionX = new MySqlConnection(connectionStringX))
                {
                    try
                    {
                        connectionX.Open();

                        string queryX = "SELECT Material_Consumo, Materia_Prima_Consumo FROM produto_acabado WHERE Nome = @NomeProduto";
                        MySqlCommand commandCreate2X = new MySqlCommand(queryX, connectionX);

                        commandCreate2X.Parameters.AddWithValue("@NomeProduto", ID_pac.Text);

                        using (MySqlDataReader reader = commandCreate2X.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Adiciona as opções ao ComboBox
                                while (reader.Read())
                                {
                                    cod_materia_prima.Text = reader["Materia_Prima_Consumo"].ToString();
                                    cod_material.Text = reader["Material_Consumo"].ToString();

                                    connectionX.Close();
                                }
                            }
                        }
                    }
                    catch { }

                }
            }
        }

        private void Lbl_logout_Click(object sender, EventArgs e)
        {


            // Imprime a hora e minuto
            //Console.WriteLine(horaMinutoFormatada);

            // Imprime a hora e minuto
            //Console.WriteLine(horaAtual.ToString("HH:mm"))
            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connectionA = new MySqlConnection(connectionStringA))
            {

                try
                {                                               ///UPDATE usuario SET Nome = @Nome, Senha = @Senha, id_setor = @Setor WHERE ID = @ID"
                    connectionA.Open();
                    string queryCreate1 = "UPDATE producao_linha SET tempo_parada_linha = @tempo_parada_linha, hora_inicial = @hora_inicial, " +
                                            "quantidade_refugo_materia_prima = @quantidade_refugo_materia_prima, quantidade_refugo_material = @quantidade_refugo_material, " +
                                            "quantidade_refugo_produto_acabado = @quantidade_refugo_produto_acabado, " +
                                            "quantidade_produzidas = @quantidade_produzidas, status_producao = @status, quantidade_operadores = @quantidade_operadores WHERE id_producao = @id_producao";

                    MySqlCommand commandCreateA = new MySqlCommand(queryCreate1, connectionA);
                    commandCreateA.Parameters.AddWithValue("@tempo_parada_linha", maskedTextBox4.Text);
                    commandCreateA.Parameters.AddWithValue("@hora_inicial", maskedTextBox2.Text);
                    commandCreateA.Parameters.AddWithValue("@quantidade_refugo_materia_prima", int.Parse(maskedTextBox5.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_refugo_material", int.Parse(maskedTextBox7.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_refugo_produto_acabado", int.Parse(maskedTextBox6.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_produzidas", int.Parse(txb_produzidas.Text));
                    commandCreateA.Parameters.AddWithValue("@id_producao", int.Parse(tvb_cod_linha.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_operadores", int.Parse(cmb_homens.Text));
                    commandCreateA.Parameters.AddWithValue("@status", 1);

                    commandCreateA.ExecuteNonQuery();
                    connectionA.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.Close();
            }

        }
        private List<ParadaLinha> paradasDeLinha = new List<ParadaLinha>();
        private void btn_adc_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == null)
            {
                maskedTextBox1.Text = "00:00";
            }

            string valorMascara = maskedTextBox1.Text;

            // Divida o valor em horas e minutos
            string[] partes = valorMascara.Split(':');
            int horas = 0;
            int minutos = 0;

            if (partes.Length == 2 && int.TryParse(partes[0], out horas) && int.TryParse(partes[1], out minutos))
            {
                // Calcule o tempo total em minutos
                int tempoTotalMinutos = horas * 60 + minutos;

                // Converta o tempo total em minutos de volta para o formato "00:20"
                string tempoFormatado = $"{tempoTotalMinutos / 60:D2}:{tempoTotalMinutos % 60:D2}";

                // Use o tempoFormatado como necessário (por exemplo, exibindo-o em um controle)
                maskedTextBox1.Text = tempoFormatado;
            }
            else
            {
                // Trate o erro, por exemplo, exibindo uma mensagem ao usuário
                //textBox3.Text = "Formato inválido";
            }
            string tempoParada = maskedTextBox1.Text;
            string tipoProducao = cmb_tipoProducao.Text;


            // Atualize o tempo total
            TimeSpan tempoTotal = TimeSpan.Zero;
            foreach (ParadaLinha paradaAtual in paradasDeLinha)
            {
                TimeSpan tempo;
                if (TimeSpan.TryParse(paradaAtual.Tempo, out tempo))
                {
                    tempoTotal += tempo;
                }
            }

            string connectionStringX = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connectionX = new MySqlConnection(connectionStringX))
            {
                connectionX.Open();

                string tempoFormatado = maskedTextBox1.Text; // Substitua pelo valor real

                // Divida o valor em horas e minutos
                string[] partesx = tempoFormatado.Split(':');
                int horasx = 0;
                int minutosx = 0;

                if (partes.Length == 2 && int.TryParse(partesx[0], out horasx) && int.TryParse(partesx[1], out minutosx))
                {
                    // Calcule o tempo total em minutos
                    int tempoTotalMinutos = horasx * 60 + minutosx;

                    // Agora, tempoTotalMinutos contém o valor em minutos
                    textBox1.Text = tempoTotalMinutos.ToString(); // Saída: 80 minutos (para "01:20")
                }
                else
                {
                    // Trate o erro, por exemplo, exibindo uma mensagem ao usuário
                    Console.WriteLine("Formato inválido");
                }
                string tempoParada1 = textBox1.Text;
                string tipoProducao1 = cmb_tipoProducao.Text;
                string observacoes = textBox3.Text;
                int IdProducao = int.Parse(tvb_cod_linha.Text);// Se você deseja armazenar as observações

                // Crie uma consulta SQL de inserção

                string query = "INSERT INTO paradas_linha_producao(id_producao, tempo, tipo, observação) VALUES(@id_producao, @tempo, @tipo, @observação)";
                //

                using (MySqlCommand commandX = new MySqlCommand(query, connectionX))
                {
                    // Defina os parâmetros da consulta SQL
                    commandX.Parameters.AddWithValue("@tempo", tempoParada1);
                    commandX.Parameters.AddWithValue("@tipo", tipoProducao);
                    commandX.Parameters.AddWithValue("@observação", observacoes);
                    commandX.Parameters.AddWithValue("@id_producao", IdProducao);

                    // Execute a consulta SQL de inserção
                    commandX.ExecuteNonQuery();
                    Button botaoParada = new Button();
                    botaoParada.Text = $"Tempo: {tempoParada}, Tipo: {tipoProducao}";
                    botaoParada.Dock = DockStyle.Top;
                    botaoParada.ForeColor = Color.Black;
                    botaoParada.BackColor = Color.LightBlue;// Para empilhar os botões de cima para baixo

                    // Adicione o botão ao Panel
                    panel5.Controls.Add(botaoParada);

                    string tempo_paradas_formatado = tempoParada; // Exemplo de valor "00:00"
                    int minutosTotalP = 0;
                    int minutosTotalF = 0;
                    // Divida a string em horas e minutos
                    string[] partesP = tempo_paradas_formatado.Split(':');
                    if (partesP.Length == 2)
                    {
                        int horasP = int.Parse(partesP[0]);
                        int minutosP = int.Parse(partesP[1]);

                        // Calcule o valor total em minutos
                        minutosTotalP = (horasP * 60) + minutosP;
                    }
                    string tempo_paradas_form = maskedTextBox4.Text;
                    if (tempo_paradas_form == "  :")
                    {
                        tempo_paradas_form = "00:00";
                    }
                       

                    // Divida a string em horas e minutos
                    string[] partesF = tempo_paradas_form.Split(':');
                    if (partesF.Length == 2)
                    {
                        int horasF = int.Parse(partesF[0]);
                        int minutosF = int.Parse(partesF[1]);

                        // Calcule o valor total em minutos
                        minutosTotalF = (horasF * 60) + minutosF;
                    }
                    int totalMinutos = minutosTotalP + minutosTotalF;

                    int horasPF = totalMinutos / 60;
                    int minutosRestantesPF = totalMinutos % 60;

                    maskedTextBox4.Text = $"{horasPF:00}:{minutosRestantesPF:00}";

                }

                // Exiba o tempo total em maskedTextBox4
                //maskedTextBox4.Text = tempoTotal.ToString(@"hh\:mm");

                maskedTextBox1.Text = null;
                cmb_tipoProducao.Text = null;
                textBox3.Text = null;
            }

        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;

            // Obtém o horário inicial da produção
            DateTime inicioProducao = Convert.ToDateTime(maskedTextBox2.Text);

            // Calcula o tempo de produção
            TimeSpan tempoProducao = agora - inicioProducao;

            // Obtém as horas e os minutos do tempo de produção
            int horas = tempoProducao.Hours;
            int minutos = tempoProducao.Minutes;

            // Define o texto do textbox
            textBox7.Text = $"{horas:00}:{minutos:00}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidade_demanda = int.Parse(text_demanda.Text);
            int quantidade_produzida = int.Parse(txb_produzidas.Text);
            int homens_linha = int.Parse(cmb_homens.Text);
            int quantidadeMP = 0;
            int quantidadeCP = 0;
            if (quantidade_produzida < quantidade_demanda)
            {
                MessageBox.Show("A quantidade produzida está abaixo da demanda \n CONTINUE A PRODUÇÂO !!!");
                return;
            }
            else if (quantidade_produzida > quantidade_demanda)
            {

                if (homens_linha != 0)
                {
                    string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString1))
                    {
                        connection.Open();

                        string queryQuan = "SELECT t1.Quantidade AS QuantidadeMP, t2.Quantidade AS QuantidadeCM\r\nFROM produto_materia_prima AS t1\r\nJOIN produto_materia_prima_componente AS t2\r\nON t1.Nome = '" + cod_materia_prima.Text + "'\r\nAND t2.Nome = '" + cod_material.Text + "'";
                        MySqlCommand command = new MySqlCommand(queryQuan, connection);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    quantidadeMP = int.Parse(reader["QuantidadeMP"].ToString());
                                    quantidadeCP = int.Parse(reader["QuantidadeMP"].ToString());
                                    if(quantidadeMP < quantidade_produzida)
                                    {
                                        MessageBox.Show("Quantidade de Materia Prima Inferior ao Produzido \n Contate o Líder!!!");
                                        return;
                                    }
                                    if (quantidadeCP < quantidade_produzida)
                                    {
                                        MessageBox.Show("Quantidade de Componente Inferior ao Produzido \n Contate o Líder!!!");
                                        return;
                                    }
                                }
                            }
                        }
                        quantidadeMP -= quantidade_produzida;
                        quantidadeCP -= quantidade_produzida;
                        string queryCreate = "UPDATE produto_materia_prima SET Quantidade = " + quantidadeMP + " WHERE Nome = '" + cod_materia_prima.Text + "';";
                        MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                        {
                            //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                            commandCreate.ExecuteNonQuery();

                        }
                        string queryCreate2 = "UPDATE produto_materia_prima_componente SET Quantidade = " + quantidadeCP + " WHERE Nome = '" + cod_material.Text + "';";
                        MySqlCommand commandCreate2 = new MySqlCommand(queryCreate2, connection);
                        {
                            //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                            commandCreate.ExecuteNonQuery();

                        }
                        connection.Close();
                    }


                    double quantidade_operadores = double.Parse(cmb_homens.Text);
                    double quantidade_Produzida = double.Parse(txb_produzidas.Text);

                    string hora_inicio = maskedTextBox2.Text;

                    string tempo_total_producao = textBox7.Text;
                    int indiceSeparador = tempo_total_producao.IndexOf(":", 2);
                    int hora = int.Parse(tempo_total_producao.Substring(0, 2));
                    int horaEmMinutos = hora * 60;
                    int minutos = int.Parse(tempo_total_producao.Substring(indiceSeparador + 1));
                    int tempo_total_producaoMinutos = horaEmMinutos + minutos;


                    string paradasLinha = maskedTextBox4.Text;
                    int hora2 = int.Parse(paradasLinha.Substring(0, 2));
                    int horaEmMinutos2 = hora2 * 60;
                    int minutos2 = int.Parse(paradasLinha.Substring(indiceSeparador + 1));
                    int paradasLinhaMinutos = horaEmMinutos2 + minutos2;



                    int refugo_produto_acabado = int.Parse(maskedTextBox6.Text);
                    int refugo_materia_prima = int.Parse(maskedTextBox5.Text);
                    int refugo_material = int.Parse(maskedTextBox7.Text);
                    int ID_Produto = int.Parse(tvb_cod_linha.Text);
                    int ID_Cliente = 0;

                    DateTime agora = DateTime.Now;


                    int horasx = agora.Hour;
                    int minutosx = agora.Minute;

                    // Define o texto do textbox
                    string tempo_fechamento = $"{horasx:00}:{minutosx:00}";



                    double pecas_carregadas = quantidade_Produzida + refugo_materia_prima + refugo_produto_acabado;
                    double tempo_producao_minutos = tempo_total_producaoMinutos - paradasLinhaMinutos;

                    //double PPH = quantidade_Produzida / tempo_producao_minutos / (quantidade_operadores * 60);

                    double KU_valor = tempo_producao_minutos / (tempo_producao_minutos + paradasLinhaMinutos);
                    double KU_total = KU_valor * 100;
                    double KU = double.Parse(KU_total.ToString("F2"));


                    double PPH_passo1 = tempo_producao_minutos / 60;
                    double PPH_passo1_1 = double.Parse(PPH_passo1.ToString("F2"));
                    double PPH_passo2 = quantidade_Produzida / PPH_passo1_1;
                    double PPH_passo2_2 = double.Parse(PPH_passo2.ToString("F2"));
                    double PPH_passo3 = PPH_passo2_2 / quantidade_operadores;
                    double PPH = double.Parse(PPH_passo3.ToString("F2"));



                    double YIELD_passo1 = quantidade_Produzida * 100 / pecas_carregadas;
                    double YIELD = double.Parse(YIELD_passo1.ToString("F2"));

                    int status = 1;

                    string connectionStringFinalizar = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                    MySqlConnection connectionFinalizar = new MySqlConnection(connectionStringFinalizar);


                    string query = "INSERT INTO producao(quantidade_Produzida, hora_inicio, hora_final, tempo_total_producao, paradasLinha, " +
                        "refugo_produto_acabado, refugo_materia_prima, refugo_material, ID_Produto, ID_Cliente, PPH, KU, YIELD_Materia_Prima, status, Turno) " +
                        "VALUES(@quantidade_Produzida, @hora_inicio, @hora_final, @tempo_total_producao, " +
                        "@paradasLinha, @refugo_produto_acabado, @refugo_materia_prima, @refugo_material, " +
                        "@ID_Produto, @ID_Cliente, @PPH, @KU, @YIELD_Materia_Prima, @status, @Turno )";

                    using (MySqlCommand commandFinalizar = new MySqlCommand(query, connectionFinalizar))
                    {
                        connectionFinalizar.Open();
                        // Defina os parâmetros da consulta SQL
                        commandFinalizar.Parameters.AddWithValue("@quantidade_Produzida", quantidade_Produzida);
                        commandFinalizar.Parameters.AddWithValue("@hora_inicio", hora_inicio);
                        commandFinalizar.Parameters.AddWithValue("@hora_final", tempo_fechamento);
                        commandFinalizar.Parameters.AddWithValue("@tempo_total_producao", tempo_total_producao);
                        commandFinalizar.Parameters.AddWithValue("@paradasLinha", paradasLinha);
                        commandFinalizar.Parameters.AddWithValue("@refugo_produto_acabado", refugo_produto_acabado);
                        commandFinalizar.Parameters.AddWithValue("@refugo_materia_prima", refugo_materia_prima);
                        commandFinalizar.Parameters.AddWithValue("@refugo_material", refugo_material);
                        commandFinalizar.Parameters.AddWithValue("@ID_Produto", ID_Produto);
                        commandFinalizar.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                        commandFinalizar.Parameters.AddWithValue("@PPH", PPH);
                        commandFinalizar.Parameters.AddWithValue("@KU", KU);
                        commandFinalizar.Parameters.AddWithValue("@YIELD_Materia_Prima", YIELD);
                        commandFinalizar.Parameters.AddWithValue("@status", status);
                        commandFinalizar.Parameters.AddWithValue("@Turno", lbl_turno.Text);

                        // Execute a consulta SQL de inserção
                        commandFinalizar.ExecuteNonQuery();
                        connectionFinalizar.Close();

                    }

                    MySqlConnection connectionStatus = new MySqlConnection(connectionStringFinalizar);


                    string queryStatus = "UPDATE producao_linha SET status_producao = 2 WHERE id_producao = @id_producao";
                    //

                    using (MySqlCommand commandStatus = new MySqlCommand(queryStatus, connectionStatus))
                    {
                        connectionStatus.Open();
                        // Defina os parâmetros da consulta SQL
                        commandStatus.Parameters.AddWithValue("@id_producao", int.Parse(tvb_cod_linha.Text));

                        // Execute a consulta SQL de inserção
                        commandStatus.ExecuteNonQuery();
                        connectionStatus.Close();

                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("A quantidade OPERADORES não selecionado!!!");

                }


            }
            else if (quantidade_produzida == quantidade_demanda)
            {
                if (homens_linha != 0)
                {
                    string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                    using (MySqlConnection connection = new MySqlConnection(connectionString1))
                    {
                        connection.Open();

                        string queryQuan = "SELECT t1.Quantidade AS QuantidadeMP, t2.Quantidade AS QuantidadeCM\r\nFROM produto_materia_prima AS t1\r\nJOIN produto_materia_prima_componente AS t2\r\nON t1.Nome = '" + cod_materia_prima.Text + "'\r\nAND t2.Nome = '" + cod_material.Text + "'";
                        MySqlCommand command = new MySqlCommand(queryQuan, connection);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    quantidadeMP = int.Parse(reader["QuantidadeMP"].ToString());
                                    quantidadeCP = int.Parse(reader["QuantidadeMP"].ToString());
                                    if (quantidadeMP < quantidade_produzida)
                                    {
                                        MessageBox.Show("Quantidade de Materia Prima "+ cod_materia_prima.Text +" Inferior ao Produzido \n Contate o Líder!!!");
                                        return;
                                    }
                                    if (quantidadeCP < quantidade_produzida)
                                    {
                                        MessageBox.Show("Quantidade de Componente "+ cod_material.Text + " Inferior ao Produzido \n Contate o Líder!!!");
                                        return;
                                    }
                                }
                            }
                        }
                        quantidadeMP -= quantidade_produzida;
                        quantidadeCP -= quantidade_produzida;
                        string queryCreate = "UPDATE produto_materia_prima SET Quantidade = " + quantidadeMP + " WHERE Nome = '" + cod_materia_prima.Text + "';";
                        MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                        {
                            //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                            commandCreate.ExecuteNonQuery();

                        }
                        string queryCreate2 = "UPDATE produto_materia_prima_componente SET Quantidade = " + quantidadeCP + " WHERE Nome = '" + cod_material.Text + "';";
                        MySqlCommand commandCreate2 = new MySqlCommand(queryCreate2, connection);
                        {
                            //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                            commandCreate2.ExecuteNonQuery();

                        }
                        connection.Close();
                    }
                    double quantidade_operadores =double.Parse(cmb_homens.Text);
                    double quantidade_Produzida = double.Parse(txb_produzidas.Text);

                    string hora_inicio = maskedTextBox2.Text;

                    string tempo_total_producao = textBox7.Text;
                    int indiceSeparador = tempo_total_producao.IndexOf(":", 2);
                    int hora = int.Parse(tempo_total_producao.Substring(0, 2));
                    int horaEmMinutos = hora * 60;
                    int minutos = int.Parse(tempo_total_producao.Substring(indiceSeparador + 1));
                    int tempo_total_producaoMinutos = horaEmMinutos + minutos;

                    int hora2 = 0;
                    string paradasLinha = maskedTextBox4.Text;
                    try
                    {
                        hora2 = int.Parse(paradasLinha.Substring(0, 2));
                    }
                    catch
                    {
                        hora2 = 0;
                    }
                    
                    int horaEmMinutos2 = hora2 * 60;
                    int minutos2 = int.Parse(paradasLinha.Substring(indiceSeparador + 1));
                    int paradasLinhaMinutos = horaEmMinutos2 + minutos2;



                    int refugo_produto_acabado = int.Parse(maskedTextBox6.Text);
                    int refugo_materia_prima = int.Parse(maskedTextBox5.Text);
                    int refugo_material = int.Parse(maskedTextBox7.Text);
                    int ID_Produto = int.Parse(tvb_cod_linha.Text);
                    int ID_Cliente = 0;

                    DateTime agora = DateTime.Now;


                    int horasx = agora.Hour;
                    int minutosx = agora.Minute;

                    // Define o texto do textbox
                    string tempo_fechamento = $"{horasx:00}:{minutosx:00}";



                    double pecas_carregadas = quantidade_Produzida + refugo_materia_prima + refugo_produto_acabado;
                    double tempo_producao_minutos = tempo_total_producaoMinutos - paradasLinhaMinutos;

                    //double PPH = quantidade_Produzida / tempo_producao_minutos / (quantidade_operadores * 60);

                    double KU_valor = tempo_producao_minutos / (tempo_producao_minutos + paradasLinhaMinutos);
                    double KU_total = KU_valor * 100;
                    double KU = double.Parse(KU_total.ToString("F2"));


                    double PPH_passo1 = tempo_producao_minutos / 60;
                    double PPH_passo1_1 = double.Parse(PPH_passo1.ToString("F2"));
                    double PPH_passo2 = pecas_carregadas / PPH_passo1_1;
                    double PPH_passo2_2 = double.Parse(PPH_passo2.ToString("F2"));
                    double PPH_passo3 = PPH_passo2_2 / quantidade_operadores;
                    double PPH = double.Parse(PPH_passo3.ToString("F2"));



                    double YIELD_passo1 = quantidade_Produzida * 100 / pecas_carregadas;
                    double YIELD = double.Parse(YIELD_passo1.ToString("F2"));

                    int status = 1;

                    string connectionStringFinalizar = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                    MySqlConnection connectionFinalizar = new MySqlConnection(connectionStringFinalizar);


                    string query = "INSERT INTO producao(quantidade_Produzida, hora_inicio, hora_final, tempo_total_producao, paradasLinha, " +
                        "refugo_produto_acabado, refugo_materia_prima, refugo_material, ID_Produto, ID_Cliente, PPH, KU, YIELD_Materia_Prima, status, Turno ) " +
                        "VALUES(@quantidade_Produzida, @hora_inicio, @hora_final, @tempo_total_producao, " +
                        "@paradasLinha, @refugo_produto_acabado, @refugo_materia_prima, @refugo_material, " +
                        "@ID_Produto, @ID_Cliente, @PPH, @KU, @YIELD_Materia_Prima, @status, @Turno )";

                    using (MySqlCommand commandFinalizar = new MySqlCommand(query, connectionFinalizar))
                    {
                        connectionFinalizar.Open();
                        // Defina os parâmetros da consulta SQL
                        commandFinalizar.Parameters.AddWithValue("@quantidade_Produzida", quantidade_Produzida);
                        commandFinalizar.Parameters.AddWithValue("@hora_inicio", hora_inicio);
                        commandFinalizar.Parameters.AddWithValue("@hora_final", tempo_fechamento);
                        commandFinalizar.Parameters.AddWithValue("@tempo_total_producao", tempo_total_producao);
                        commandFinalizar.Parameters.AddWithValue("@paradasLinha", paradasLinha);
                        commandFinalizar.Parameters.AddWithValue("@refugo_produto_acabado", refugo_produto_acabado);
                        commandFinalizar.Parameters.AddWithValue("@refugo_materia_prima", refugo_materia_prima);
                        commandFinalizar.Parameters.AddWithValue("@refugo_material", refugo_material);
                        commandFinalizar.Parameters.AddWithValue("@ID_Produto", ID_Produto);
                        commandFinalizar.Parameters.AddWithValue("@ID_Cliente", ID_Cliente);
                        commandFinalizar.Parameters.AddWithValue("@PPH", PPH);
                        commandFinalizar.Parameters.AddWithValue("@KU", KU);
                        commandFinalizar.Parameters.AddWithValue("@YIELD_Materia_Prima", YIELD);
                        commandFinalizar.Parameters.AddWithValue("@status", status);
                        commandFinalizar.Parameters.AddWithValue("@Turno", lbl_turno.Text);

                        // Execute a consulta SQL de inserção
                        commandFinalizar.ExecuteNonQuery();
                        connectionFinalizar.Close();

                    }

                    MySqlConnection connectionStatus = new MySqlConnection(connectionStringFinalizar);


                    string queryStatus = "UPDATE producao_linha SET status_producao = 2 WHERE id_producao = @id_producao";
                    //

                    using (MySqlCommand commandStatus = new MySqlCommand(queryStatus, connectionStatus))
                    {
                        connectionStatus.Open();
                        // Defina os parâmetros da consulta SQL
                        commandStatus.Parameters.AddWithValue("@id_producao", int.Parse(tvb_cod_linha.Text));

                        // Execute a consulta SQL de inserção
                        commandStatus.ExecuteNonQuery();
                        connectionStatus.Close();

                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("A quantidade OPERADORES não selecionado!!!");
                }
            }
            else
            {
                MessageBox.Show("Produção Finalizado como DEMANDADO!!!");

            }
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;

            // Obtém o horário inicial da produção
            DateTime inicioProducao = Convert.ToDateTime(textBox7.Text);

            // Calcula o tempo de produção
            TimeSpan tempoProducao = agora - inicioProducao;

            // Obtém as horas e os minutos do tempo de produção
            int horas = tempoProducao.Hours;
            int minutos = tempoProducao.Minutes;

            // Define o texto do textbox
            textBox7.Text = $"{horas:00}:{minutos:00}";

        }

        private void Lbl_logout_Click_1(object sender, EventArgs e)
        {

            // Imprime a hora e minuto
            //Console.WriteLine(horaMinutoFormatada);

            // Imprime a hora e minuto
            //Console.WriteLine(horaAtual.ToString("HH:mm"))
            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connectionA = new MySqlConnection(connectionStringA))
            {

                try
                {                                               ///UPDATE usuario SET Nome = @Nome, Senha = @Senha, id_setor = @Setor WHERE ID = @ID"
                    connectionA.Open();
                    string queryCreate1 = "UPDATE producao_linha SET tempo_parada_linha = @tempo_parada_linha, hora_inicial = @hora_inicial, " +
                                            "quantidade_refugo_materia_prima = @quantidade_refugo_materia_prima, quantidade_refugo_material = @quantidade_refugo_material, " +
                                            "quantidade_refugo_produto_acabado = @quantidade_refugo_produto_acabado, " +
                                            "quantidade_produzidas = @quantidade_produzidas, status_producao = @status, quantidade_operadores = @quantidade_operadores WHERE id_producao = @id_producao";

                    MySqlCommand commandCreateA = new MySqlCommand(queryCreate1, connectionA);
                    commandCreateA.Parameters.AddWithValue("@tempo_parada_linha", maskedTextBox4.Text);
                    commandCreateA.Parameters.AddWithValue("@hora_inicial", maskedTextBox2.Text);
                    commandCreateA.Parameters.AddWithValue("@quantidade_refugo_materia_prima", int.Parse(maskedTextBox5.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_refugo_material", int.Parse(maskedTextBox7.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_refugo_produto_acabado", int.Parse(maskedTextBox6.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_produzidas", int.Parse(txb_produzidas.Text));
                    commandCreateA.Parameters.AddWithValue("@id_producao", int.Parse(tvb_cod_linha.Text));
                    commandCreateA.Parameters.AddWithValue("@quantidade_operadores", int.Parse(cmb_homens.Text));
                    commandCreateA.Parameters.AddWithValue("@status", 1);

                    commandCreateA.ExecuteNonQuery();
                    connectionA.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                this.Close();
            }
        }
    }
}
