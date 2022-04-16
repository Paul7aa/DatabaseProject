using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProjectBD
{
    public partial class AdaugaClientWindow : Form
    {
        SqlConnection connection;

        public AdaugaClientWindow(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            tboxClientID.Text = (countRows() + 1).ToString();
        }

        public int countRows()
        {
            try
            {
                int count = 0;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Clienti";
                count = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                connection.Close();
                
                return count;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                connection.Close();
                this.Hide();
                return 0;
            }
        }

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tboxClientID.Text))
                {
                    MessageBox.Show("Campul ClientID nu poate fi gol!");
                    return;
                }

                Int16 clientID;

                if (!Int16.TryParse(tboxClientID.Text, out clientID))
                {
                    MessageBox.Show("Campul ClientID poate contine doar cifre!");
                    return;
                }

                if (tboxTelefon.Text.Any(x => !char.IsNumber(x)))
                {
                    MessageBox.Show("Campul Telefon poate contine doar 13 cifre!");
                    return;
                }

                if (tboxTelefon.Text.Length != 10 && !String.IsNullOrEmpty(tboxTelefon.Text))
                {
                    MessageBox.Show("Campul Telefon trebuie sa contina 10 cifre!");
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Clienti] (ClientID,Nume,Prenume,Email,Adresa,Telefon) values ('" + clientID.ToString() + "','"
                    + tboxNume.Text + "','" + tboxPrenume.Text + "','" + tboxEmail.Text + "','" + tboxAdresa.Text + "','"
                    + tboxTelefon.Text + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Hide();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                connection.Close();
                this.Hide();
            }
        }

    }
}
