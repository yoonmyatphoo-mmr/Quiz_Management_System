using System.Data;

namespace QuizManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            wrongLabel.Visible = false;
            wrongCredential.Visible = false;
        }

        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelectUser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;

            }
            else if (txtSelectUser.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Yoon Yoon" && txtPassword.Text == "yoon@1@2@")
            {
                wrongLabel.Visible = false;
                Teacher te = new Teacher();
                te.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.Show();
            this.Hide();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string enteredRollNo = txtEnrollmentNo.Text;
            string query = "SELECT RollNo FROM StudentData";
            DataSet ds = fn.getData(query);

            // Extract the enrollment numbers from the dataset
            List<string> enrollmentNumbers = new List<string>();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                enrollmentNumbers.Add(row["RollNo"].ToString());
            }

            // Check if the entered enrollment number exists in the list of enrollment numbers
            if (enrollmentNumbers.Contains(enteredRollNo))
            {
                wrongCredential.Visible = false;
                // Successful login, hide the login form and show the Teacher form
                this.Hide();
                Teacher te = new Teacher();
                te.Show();
            }
            else
            {
                // Display an error message for an invalid login attempt
                wrongCredential.Visible = true;
            }
        }

    }
}