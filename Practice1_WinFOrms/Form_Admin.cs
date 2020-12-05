using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1_WinFOrms
{
    public partial class Form_Admin : Form
    {
        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommandBuilder cmd;
        DataSet set;
        int rowIndex;
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Id ,name, surname ,Birthdate,Occupation,OrderHiringNumber,OrderDismissNumber  from Employee";
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
                set = new DataSet();
                da = new SqlDataAdapter(sql, connection);
                cmd = new SqlCommandBuilder(da);
                da.TableMappings.Add("Table", "MyEmployee");
                da.Fill(set,"MyEmployee");
                dataGridView1.DataSource = set.Tables["MyEmployee"];
                dataGridView1.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;


                SqlCommand updateCommand = new SqlCommand("UserUpdateCommand", connection);
                updateCommand.CommandType = CommandType.StoredProcedure;

                SqlParameterCollection upParams = updateCommand.Parameters;
                upParams.Add("@pId", SqlDbType.Int, 1, "Id");
                upParams["@pId"].SourceVersion = DataRowVersion.Original;
                upParams.Add("@pName", SqlDbType.NVarChar, 30, "Name");
                upParams.Add("@pSurname", SqlDbType.NVarChar, 30, "Surname");
                upParams.Add("@pBithdate", SqlDbType.Date, 30, "Birthdate");
                upParams.Add("@pOccupation", SqlDbType.NVarChar, 30, "Occupation");
                upParams.Add("@pOrderHiringNumber", SqlDbType.Int, 8, "OrderHiringNumber");
                upParams.Add("@pOrderDismissNumber", SqlDbType.Int, 8, "OrderDismissNumber");
                da.UpdateCommand = updateCommand;

                SqlCommand deleteCommand = new SqlCommand("UserDelCommand", connection);
                deleteCommand.CommandType = CommandType.StoredProcedure;

                SqlParameterCollection delParams = deleteCommand.Parameters;
                delParams.Add("@pId", SqlDbType.Int, 1, "Id");
                delParams["@pId"].SourceVersion = DataRowVersion.Original;



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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    DataSet set1 = new DataSet();
                    rowIndex = dataGridView1.SelectedCells[0].RowIndex + 1;
                    DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];
                    string sql = "Select picture from Employee where id = @pId";
                    connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Employee"].ConnectionString);
                    SqlDataAdapter da1 = new SqlDataAdapter(sql, connection);

                    da1.SelectCommand.Parameters.AddWithValue("@pId", rowIndex);
                    da1.Fill(set1);
                    byte[] bytes = (byte[])set1.Tables[0].Rows[0]["picture"];
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

        private void bt_Update_Click(object sender, EventArgs e)
        {
 
            da.Update(set, "MyEmployee");
            MessageBox.Show("Table was updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Fill_Click(object sender, EventArgs e)
        {
            Form_Admin_Load(sender, e);
        }
    }
}
