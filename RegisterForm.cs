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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        //Connection String, is also defined in App.config we just call the name here
        string cs = ConfigurationManager.ConnectionStrings["AFTestDbConnectionString"].ConnectionString;

        // method for create user button, if none of the fields contain text show errormessage and return
        private void createButton_Click(object sender, EventArgs e)
        {
            if (textBoxFname.Text == "" || textBoxEname.Text == "" || textBoxCompany.Text == "")
            {
                MessageBox.Show("Vänligen fyll i informationen");
                return;
            }
            try
            {
                //Create SqlConnection for the insert of the values from our register form
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into dbo.Users (fname, ename, company) values(@fname,@ename,@company)", con);
                cmd.Parameters.AddWithValue("@fname", textBoxFname.Text);
                cmd.Parameters.AddWithValue("@ename", textBoxEname.Text);
                cmd.Parameters.AddWithValue("@company", textBoxCompany.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                MessageBox.Show("Grattis! Du har skapat en användare");
                this.Hide();
                CompanyForm frm = new CompanyForm(); // When the user has created a new person continue to the second form
                frm.Show();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}