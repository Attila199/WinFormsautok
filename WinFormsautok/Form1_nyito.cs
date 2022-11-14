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

namespace WinFormsautok
{
    public partial class Form1_nyito : Form
    {
        MySqlConnection connection = null;
        MySqlCommand command = null;
        public Form1_nyito()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_nyito_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "local";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "auto";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                command.CommandText = "SELECT `id`,`rendszam`,`uzembehelyezve`,`szin`FROM `auto` WHERE 1";
                using (MySqlDataReader dr = command.ExecuteReader()) 
                {
                    while (dr.Read())
                    {
                        Auto uj = new Auto(dr.GetInt32("id"), dr.GetString("rendszám"), dr.GetInt32("üzembehelyezve"), dr.GetString("szín"));
                        AutokNyilvanTartas.Items.Add(uj);
                    }
                }
                connection.Close();
            }
            
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!!");
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }
            Autok_lista_update();

        }

        private void Autok_lista_update()
        {
            AutokNyilvanTartas.Items.Clear();
        }

        private void uj_auto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_rendszam.Text))
            {
                MessageBox.Show("Adjon meg rendszámot");
                textBox_rendszam.Focus();
                return;
            }
            if (numericUpDown1.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen évjárat!!!");
                numericUpDown1.Value = DateTime.Now.Year;
                numericUpDown1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_szin.Text))
            {
                MessageBox.Show("Nem adott meg színt!!!");
                textBox_szin.Focus();
                return;


            }
            command.CommandText = "INSERT INTO `auto` (`id`, `rendszam`, `uzembehelyezve`, `szin`) VALUES (NULL, @rendszam, @ev, @szin)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@rendszam", textBox_rendszam.Text);
            command.Parameters.AddWithValue("@ev", numericUpDown1.Text);
            command.Parameters.AddWithValue("@szin", textBox_szin.Text);
            try
            {
                if (command.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Sikeresen rögzítve!!!");
                    textBox_id.Text = "";
                    numericUpDown1.Value = numericUpDown1.Minimum;
                    textBox_szin.Text = "";

                }

                else
                {
                    MessageBox.Show("Sikertelen rögzités!!!");
                }
            }
            catch (MySqlException ex)
            {


                MessageBox.Show(ex.Message);
            }
        }
    }
}
