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

namespace Project
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MANSIV;Initial Catalog=master;Integrated Security=True");

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Sid.Text == "" || SName.Text == "" || SAge.Text == "" || SPhone.Text == "" || SPass.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "insert into SellerTb1 values(" + Sid.Text + ",'" + SName.Text + "'," + SAge.Text + ",'" + SPhone.Text + "','" + SPass.Text + "')"; //Add qurey
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Create Successfully");
                        con.Close();
                        Sid.Text = "";
                        SName.Text = "";
                        SAge.Text = "";
                        SPhone.Text = "";
                        SPass.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
            this.Hide();
        }

        

        private void Sid_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SAge_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SPhone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SPass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
