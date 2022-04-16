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

    public partial class MainWindow : Form
    {
        public enum WindowState
        {
            Comenzi,
            Clienti,
            Produse,
            Sisteme
        }

        public SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\University\BD\DatabaseProjectBD\DatabaseProjectBD\Database.mdf;Integrated Security=True");
        private WindowState currentWindowState;
        
        public MainWindow()
        {
            InitializeComponent();
            btnComenzi.Click += SwitchViewOnClick;
            btnClienti.Click += SwitchViewOnClick;
            btnSisteme.Click += SwitchViewOnClick;
            btnProduse.Click += SwitchViewOnClick;
            currentWindowState = WindowState.Comenzi;
            RefreshData();
        }

        public WindowState CurrentWindowState 
        {
            get => currentWindowState;
            set
            {
                currentWindowState = value;
            }
        }

        public void SwitchViewOnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Name){
                case "btnComenzi":
                    CurrentWindowState = WindowState.Comenzi;
                    break;
                case "btnClienti":
                    CurrentWindowState = WindowState.Clienti;
                    break;
                case "btnSisteme":
                    CurrentWindowState = WindowState.Sisteme;
                    break;
                case "btnProduse":
                    CurrentWindowState= WindowState.Produse;
                    break;
            }
            RefreshWindow();
        }

        public void RefreshWindow()
        {
            switch (CurrentWindowState)
            {
                case WindowState.Comenzi:
                    lblState.Text = "COMENZI";
                    btnCauta.Text = "Cauta Comanda";
                    break;
                case WindowState.Clienti:
                    lblState.Text = "CLIENTI";
                    btnCauta.Text = "Cauta Client";
                    break;
                case WindowState.Sisteme:
                    lblState.Text = "SISTEME";
                    btnCauta.Text = "Cauta Sistem";
                    break;
                case WindowState.Produse:
                    lblState.Text = "PRODUSE";
                    btnCauta.Text = "Cauta Produs";
                    break;
            }

            RefreshData();
        }

        public void RefreshData()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                switch (CurrentWindowState)
                {
                    case WindowState.Comenzi:
                        cmd.CommandText = "select * from [Comenzi]";
                        break;
                    case WindowState.Clienti:
                        cmd.CommandText = "select * from [Clienti]";
                        break;
                    case WindowState.Sisteme:
                        cmd.CommandText = "select * from [Sisteme]";
                        break;
                    case WindowState.Produse:
                        cmd.CommandText = "select * from [Produse]";
                        break;
                }
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                connection.Close();
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            switch (CurrentWindowState)
            {
                case WindowState.Comenzi:
                    break;
                case WindowState.Clienti:
                    AdaugaClientWindow adaugaClientWindow = new AdaugaClientWindow(connection);
                    adaugaClientWindow.ShowDialog();
                    break;
                case WindowState.Sisteme:
                    AdaugaSistemWindow adaugaSistemWindow = new AdaugaSistemWindow(connection);
                    adaugaSistemWindow.ShowDialog();
                    break;
                case WindowState.Produse:
                    break;
            }
            RefreshData();
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tboxCautare.Text))
                {
                    RefreshData();
                    return;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                switch (CurrentWindowState)
                {
                    case WindowState.Comenzi:
                        cmd.CommandText = "select * from [Comenzi] where Nume = '" + tboxCautare.Text + "'";
                        break;
                    case WindowState.Clienti:
                        cmd.CommandText = "select * from [Clienti] where Nume = '" + tboxCautare.Text + "'";
                        break;
                    case WindowState.Sisteme:
                        cmd.CommandText = "select * from [Sisteme] where Nume = '" + tboxCautare.Text + "'";
                        break;
                    case WindowState.Produse:
                        cmd.CommandText = "select * from [Produse] where Nume = '" + tboxCautare.Text + "'";
                        break;
                }
                cmd.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            IList<int>selectedRows = new List<int>();

            try
            {
                foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
                {
                    selectedRows.Add(Int16.Parse(dataGridView.Rows[item.Index].Cells[0].Value.ToString()));
                }
                foreach(var row in selectedRows)
                {
                    deleteRow(row.ToString());

                }
                RefreshData();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
        public void deleteRow(string IDNumber)
        {
            string table = "";
            string columnName = "";
            try
            {
                switch (CurrentWindowState)
                {
                    case WindowState.Comenzi:
                        table = "Comenzi";
                        columnName = "ComandaID";
                        break;
                    case WindowState.Clienti:
                        table = "Clienti";
                        columnName = "ClientID";
                        break;
                    case WindowState.Sisteme:
                        table = "Sisteme";
                        columnName = "SistemID";
                        break;
                    case WindowState.Produse:
                        table = "Produse";
                        columnName = "ProdusID";
                        break;
                }

                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
