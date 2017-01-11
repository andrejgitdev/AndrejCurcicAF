using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AndrejCurcicAF
{
    // Creating our Listbox, Datatable and DataGridView for later use
    public partial class CompanyForm : Form
    {
        private ListBox companyList = new ListBox();
        private DataTable dataEmployeesSource = new DataTable();
        private DataGridView dataEmployees = new DataGridView();

        //Connection String
        string cs = ConfigurationManager.ConnectionStrings["AFTestDbConnectionString"].ConnectionString;

        // we initialize our methods but dont load them
        public CompanyForm()
        {
            InitializeComponent();

            initDataEmployees();
            initCompanyList();

            companyList.SelectedIndexChanged += listbox1_SelectedIndexChanged;
        }

        // The first DataEmployees method to fill our DataGridView is executed
        private void initDataEmployees()
        {
            const string sql = "Select fname, ename, c.companyName AS companyName FROM dbo.Users u inner join dbo.Company c on c.companyName = u.company;";
            dataEmployeesSource = selectIntoDataTable(sql);
            dataEmployees.DataSource = dataEmployeesSource;
        }

        // Method to fill our CompanyList which later works as a filter for our DataGridView
        private void initCompanyList()
        {
            const string sql = "Select companyName from dbo.Company order by companyName asc";
            try
            {
                DataTable dt = selectIntoDataTable(sql);
                companyList.DataSource = dt;
                companyList.ValueMember = "companyName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are no companies to display");
            }
        }
        // Filling our DataTable locally to enable fast filtering
        private DataTable selectIntoDataTable(string sql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(cs))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                    {
                        a.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    con.Close();
                }
            }
                return dt;
            }
        // Here we show the changed value based on the selected index from our CompanyList
        private void listbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)companyList.SelectedItem;
            string selectedText = (string)selectedRow.Row["companyName"];
            DataView dv = dataEmployeesSource.DefaultView;
            string filter = string.Format("companyName = '{0}'", selectedText);
            dv.RowFilter = filter;
            dataEmployees.DataSource = dv;
        }
        // Create company, we create a company here and insert it into our dbo.Company table
        private void createCompany_Click_1(object sender, EventArgs e)
        {
            if (textBoxCompanyName.Text == "")
            {
                MessageBox.Show("Vänligen fyll i informationen");
                return;
            }
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into dbo.Company (companyName) values(@companyName)", con);
                cmd.Parameters.AddWithValue("@companyName", textBoxCompanyName.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                ((DataTable)companyList.DataSource).Rows.Add(textBoxCompanyName.Text);
                con.Close();
                MessageBox.Show("Grattis! Du har skapat ett företag");

            }
        }
    }
}