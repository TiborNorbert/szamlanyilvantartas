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
using Org.BouncyCastle.Utilities.Collections;

namespace szamlanyilvantartas
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                // terv szerint
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                // váratlan hiba
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
                throw;
            }
            finally
            {
                //hiba és terv szerinti esetén is lefut
                conn.Close();
            }
            szamladata_update();
        }
        private void szamladata_update()
        {
            szamlak.Items.Clear();
            cmd.CommandText = "SELECT `id`,`tulajdonosNeve`,`egyenleg`,`nyitasdatum` FROM `szamlak` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    szamladata uj = new szamladata(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetInt32("egyenleg"), dr.GetDateTime("nyitasdatum"));
                    szamlak.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void szamlatarol_Click(object sender, EventArgs e)
        {
            if (nodata())
            {
                return;
            }
            // Kiirjuk az adatbázisba
            cmd.CommandText = "INSERT INTO `szamlak`(`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (NULL,@tulajnev,@egyenleg,@date)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tulajnev", nevtxt.Text);
            cmd.Parameters.AddWithValue("@egyenleg", egyenlegnum.Value.ToString());
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzitettük az adatait");
                    IDtxt.Text = "";
                    nevtxt.Text = "";
                    egyenlegnum.Value = egyenlegnum.Minimum;
                    dateTimePicker1.ResetText();
                }
                else
                {
                    MessageBox.Show("Sikertelen a rögzités");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            szamladata_update();
        }
        private bool nodata()
        {
            if (string.IsNullOrEmpty(nevtxt.Text))
            {
                nevtxt.Focus();
                return true;
            }
            if (egyenlegnum.Value<0)
            {
                MessageBox.Show("Nincsen Pénzed");
                return true;
            }
            return false;
        }

        private void valasztas_Click(object sender, EventArgs e)
        {
            if (szamlak.SelectedIndex<0)
            {
                return;
            }
            szamladata kivalasztottszamla = (szamladata)szamlak.SelectedItem;
            IDtxt.Text = kivalasztottszamla.Id.ToString();
            nevtxt.Text = kivalasztottszamla.Tulajnev;
            egyenlegnum.Value = kivalasztottszamla.Egyenleg;
            dateTimePicker1.Value = kivalasztottszamla.Datum;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM `szamlak` WHERE `id`=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", IDtxt.Text);
            conn.Open(); 
            if (cmd.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adat törlése sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                IDtxt.Text = "";
                nevtxt.Text = "";
                egyenlegnum.Text = "";
                dateTimePicker1.ResetText();
                szamladata_update();


            }
            else
            {

                MessageBox.Show("Az adat törlése sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (conn.State == ConnectionState.Open)
            {

                conn.Close();

            }
    }

        private void modositas_Click(object sender, EventArgs e)
        {
            if (szamlak.SelectedIndex < 0)
            {

                MessageBox.Show("Nincsen kijelölve számla!", "Hiányzó jelölés!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            szamladata kivalasztottSzamla = (szamladata)szamlak.SelectedItem;
            cmd.CommandText= "UPDATE `szamlak` SET `tulajdonosNeve`= @tulajnev,`egyenleg`= @egyenleg,`nyitasdatum`= @date WHERE `id`=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id",IDtxt.Text);
            cmd.Parameters.AddWithValue("@tulajnev", nevtxt.Text);
            cmd.Parameters.AddWithValue("@egyenleg", egyenlegnum.Value.ToString());
            cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            conn.Open();
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Módositotta az adatot");
                conn.Close();
                nevtxt.Text = "";
                egyenlegnum.Value = egyenlegnum.Minimum;
                dateTimePicker1.ResetText();
                szamladata_update();
            }
            else
            {
                MessageBox.Show("Sikeretelen módositás");
            }
            if (conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
