using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MyProject
{
    public partial class ProductManage : Form
    {
        string connection = @"Server=localhost;Database=productmanage;Username=root;Password=1234;";
        int productID = 0;
        public ProductManage()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(MySqlConnection mySqlCon = new MySqlConnection(connection))
            {
                mySqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("ProductAddOrEdit", mySqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_ProductID", productID);
                mySqlCmd.Parameters.AddWithValue("_ProductTitle", txtTitle.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_ProductDescription", txtDesc.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_ProductPrice", txtPrice.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_ProductQuantity", txtQuantity.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_ProductCategory", txtCategory.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!");
                Clear();
                GridFill();
            }
        }

        void GridFill()
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connection))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ProductViewAll", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtbProduct = new DataTable();
                sqlDa.Fill(dtbProduct);
                dataGridView1.DataSource = dtbProduct;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        void Clear()
        {
            txtTitle.Text = txtDesc.Text = txtPrice.Text = txtQuantity.Text = txtCategory.Text = "";
            productID = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            GridFill();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                txtTitle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtQuantity.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtCategory.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                productID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connection))
            {
                mySqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("ProductSearchByValue", mySqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dtbProduct = new DataTable();
                sqlDa.Fill(dtbProduct);
                dataGridView1.DataSource = dtbProduct;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(connection))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xoá sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    mySqlCon.Open();
                    MySqlCommand mySqlCmd = new MySqlCommand("ProductDeleteByID", mySqlCon);
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    mySqlCmd.Parameters.AddWithValue("_ProductID", productID);
                    mySqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully!");
                    Clear();
                    GridFill();
                }
            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Product Manage";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dataGridView1, openFileDialog.FileName);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát khỏi ứng dụng không?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
