using MilkTea_TâyTây.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkTea_TâyTây
{
    public partial class ManageMT : Form
    {
        public ManageMT()
        {
            InitializeComponent();
            LoadAccountList();
            UpdateFont(dgvRevenue);
            createPieChart(dateTP3.Value.ToString("yyyy-MM-dd"), dateTP4.Value.ToString("yyyy-MM-dd"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void createPieChart(String x, String y)
        {
            pieChart.Series["s1"].Points.Clear();
            DataTable dt = MenuDAO.Instance.BestSellers(x, y);
            pieChart.Titles.Clear();
            pieChart.Titles.Add("Số lượng đồ uống được bán");
            pieChart.Series["s1"].IsValueShownAsLabel = true;
            foreach (DataRow dr in dt.Rows)
            {
                pieChart.Series["s1"].Points.AddXY(dr[0].ToString(), dr[1].ToString());
            }
            
        }

        void LoadAccountList()
        {
        }

        private void listBtn_Click(object sender, EventArgs e)
        {
            dgvRevenue.DataSource=RevenueByDate(dateTP1.Value.ToString("yyyy-MM-dd"), dateTP2.Value.ToString("yyyy-MM-dd"));
        }
        public DataTable RevenueByDate(String x, String y)
        {
            return MenuDAO.Instance.RevenueByDate(x, y);
        }
        public DataTable BestSellers(String x, String y)
        {
            return MenuDAO.Instance.BestSellers(x, y);
        }
        private void UpdateFont(DataGridView dgv)
        {
            //Change cell font

            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Times New Roman", 18F, GraphicsUnit.Pixel);
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; //display all cols as displayedCells
                //dgv.Columns[dgv.ColumnCount-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //display the last col as fill
            }
        }

        private void pieChartDetailBtn_Click(object sender, EventArgs e)
        {
            createPieChart(dateTP3.Value.ToString("yyyy-MM-dd"), dateTP4.Value.ToString("yyyy-MM-dd"));
        }
    }
}
