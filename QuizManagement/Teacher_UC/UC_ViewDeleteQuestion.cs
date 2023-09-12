using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace QuizManagement.Teacher_UC
{
    public partial class UC_ViewDeleteQuestion : UserControl
    {
        function fn = new function();
        string query;
        public UC_ViewDeleteQuestion()
        {
            InitializeComponent();
        }

        private void UC_ViewDeleteQuestion_Load(object sender, EventArgs e)
        {
            comboSet.Items.Clear();
            comboSet.Items.Add("All Questions");
            query = "select distinct qset from Questions";
            DataSet ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }

        }

        private void comboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSet.SelectedIndex != 0)
            {
                query = "select id,qNo,question,optionA,optionB,optionC,optionD, ans from Questions where qset = '" + comboSet.Text + "'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select id,qNo,question,optionA,optionB,optionC,optionD, ans from Questions";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        int id, questionNo;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Comfirm !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from Questions where id = '" + id + "' and qNo = '" + questionNo + "'";
                fn.setData(query, "Question Deleted!");
                UC_ViewDeleteQuestion_Load(this, null);
            }

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_ViewDeleteQuestion_Load(this, null);
        }
    }
}
