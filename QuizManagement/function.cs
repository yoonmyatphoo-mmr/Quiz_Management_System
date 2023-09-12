using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuizManagement
{
    internal class function
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\DELL\\OneDrive - University of Computer Studies (Taunggyi)\\Documents\\YoonMyatPhoo.mdf\";Integrated Security=True;Connect Timeout=30");

        public DataSet getData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con); // Set the SQL query and connection for the command
            SqlDataAdapter da = new SqlDataAdapter(cmd); // Initialize SqlDataAdapter with the command
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }

        public void setData(string query, string msg)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con); // Set the SQL query and connection for the command
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /* public SqlDataReader getForCombo(String query)
         {

         }*/
    }
   
}
