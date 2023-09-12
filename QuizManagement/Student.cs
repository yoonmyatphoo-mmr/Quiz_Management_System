using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagement
{
    public partial class Student : Form
    {
        function fn = new function();
        string query;
        DataSet ds;

        public Student()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string rollNo = txtRollNo.Text;
            string name = txtName.Text;
            string email = txtEmail.Text;
            string gender = comboGender.SelectedItem.ToString();
            string address = txtAddress.Text;

            query = "insert into StudentData (RollNo, Name, Email, Gender, Address) " +
                         "VALUES ('" + rollNo + "', '" + name + "', '" + email + "', '" + gender + "', '" + address + "')";
            fn.setData(query, "Successfully Register!!");
            ClearFormFields();
        }
        private void ClearFormFields()
        {
            txtRollNo.Clear();
            txtName.Clear();
            txtEmail.Clear();
            comboGender.SelectedIndex = -1; // Clear the ComboBox selection
            txtAddress.Clear();
        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
