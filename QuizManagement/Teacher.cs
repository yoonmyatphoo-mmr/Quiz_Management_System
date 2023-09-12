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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            uC_AddNewQuestions4.Visible = false;
            uC_UpdateQuestion1.Visible = false;
            uC_ViewDeleteQuestion1.Visible = false;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            uC_AddNewQuestions4.Visible = true;
            uC_AddNewQuestions4.BringToFront();
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            uC_UpdateQuestion1.Visible = true;
            uC_UpdateQuestion1.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            uC_ViewDeleteQuestion1.Visible = true;
            uC_ViewDeleteQuestion1.BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void uC_ViewDeleteQuestion1_Load(object sender, EventArgs e)
        {

        }
    }
}
