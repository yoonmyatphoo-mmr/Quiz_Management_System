using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagement.Teacher_UC
{
    public partial class UC_AddNewQuestions : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        Int64 questionNo = 1;

        public UC_AddNewQuestions()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddNewQuestions_Load(object sender, EventArgs e)
        {
            query = "select max(qset) from Questions";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id + 1).ToString();

            }
            else
            {
                txtSet.Text = "1";
            }

            questionLabel.Text = questionNo.ToString();
            labelNoSet.Visible = false;
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {
            if (txtSet.Text != "")
            {
                clearAll();
                query = "select qNo from Questions where qset = '" + txtSet.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    questionLabel.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                }
                else
                {
                    questionLabel.Text = "1";
                    questionNo = Int64.Parse(questionLabel.Text.ToString());
                    labelNoSet.Visible = true;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set will be changed!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString()) + 1).ToString();
                questionLabel.Text = "1";
            }
        }

        private void labelNoSet_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string qset = txtSet.Text;
            string qNo = questionNo.ToString();
            string question = txtQuestion.Text;
            string option1 = txtOption1.Text;
            string option2 = txtOption2.Text;
            string option3 = txtOption3.Text;
            string option4 = txtOption4.Text;
            string ans = txtAnswer.Text;

            query = "insert into Questions (qset,qNo,question,optionA,optionB,optionC,optionD,ans) values ('" + qset + "','" + qNo + "','" + question + "','" + option1 + "','" + option2 + "','" + option3 + "','" + option4 + "','" + ans + "')";
            fn.setData(query, "Question Added!");
            clearAll();
            questionNo++;
            questionLabel.Text = questionNo.ToString();

        }
        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
