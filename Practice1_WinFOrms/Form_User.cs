using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_WinFOrms
{
    public partial class Form_User : Form
    {
        SqlConnection connection;
        SqlDataAdapter da;
        DataSet set;
        int rowIndex;
        public Form_User()
        {
            InitializeComponent();
        }

        private void Form_User_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "Select name , surname , Occupation  from Employee";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[3]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();

                    }

                    foreach(string[] s in data)
                    {
                        dataGridView1.Rows.Add(s);
                    }
          


                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedCells.Count > 0 )
            {
                try
                {
                    rowIndex = dataGridView1.SelectedCells[0].RowIndex + 1;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string sql = "Select picture from Employee where id = @pId";
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
                    da = new SqlDataAdapter(sql, connection);
                    set = new DataSet();
                    da.SelectCommand.Parameters.AddWithValue("@pId", rowIndex);
                    da.Fill(set);
                    byte[] bytes = (byte[])set.Tables[0].Rows[0]["picture"];
                    MemoryStream ms = new MemoryStream(bytes);
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch (Exception ex)
                {
                    return;
                }

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
