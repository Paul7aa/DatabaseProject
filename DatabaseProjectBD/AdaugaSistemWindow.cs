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
    public partial class AdaugaSistemWindow : Form
    {
        SqlConnection connection;
        public AdaugaSistemWindow(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            tboxSistemID.Text = (countRows() + 1).ToString();
            cBoxTip.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTip.SelectedIndex = 0;

            for (int i = 2010; i < 2023; i++)
            {
                cBoxAnAparitie.Items.Add(i.ToString());
            }
            cBoxAnAparitie.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxAnAparitie.SelectedIndex = 0;
        }

        public int countRows()
        {
            try
            {
                int count = 0;
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT COUNT(*) FROM Sisteme";
                count = (int)cmd.ExecuteScalar();
                cmd.ExecuteNonQuery();
                connection.Close();

                return count;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                this.Hide();
                connection.Close();
                return 0;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tBoxProducator.Text))
                {
                    MessageBox.Show("Campul Producator nu poate fi gol!");
                    return;
                }
                if (String.IsNullOrEmpty(tBoxSerie.Text)) {
                    MessageBox.Show("Campul Serie nu poate fi gol!");
                    return;
                }
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into [Sisteme] (SistemID,Tip,Producator,Serie,AnAparitie) values ('" + tboxSistemID.Text + "','"
                    + cBoxTip.Items[cBoxTip.SelectedIndex].ToString() + "','" + tBoxProducator.Text + "','" + tBoxSerie.Text + "','" 
                    + cBoxAnAparitie.Items[cBoxAnAparitie.SelectedIndex].ToString()+"')";
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

        private void btnAnulare_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
