using DevExpress.XtraCharts.Native;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonaireDigital_Report
{
    public partial class Form1 : Form
    {
        //List<SaleDto> sales = new List<SaleDto>();
        public Form1()
        {
            InitializeComponent();
            btnsub.Click += Btnsub_Click;
        }
        private void Btnsub_Click(object sender, EventArgs e)
        {
            List<SaleDto> sales = new List<SaleDto>();

            try
            {
                DateTime start = dpstart.Value.Date;
                DateTime end = dpend.Value.Date;

                Program.Connection.Open();

                using (SqlCommand cmd = new SqlCommand("spGetSalesBy_DateRange", Program.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@STARTDATE", start);
                    cmd.Parameters.AddWithValue("@ENDDATE", end);


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sales.Add(new SaleDto
                            {
                                ProductCode = reader["PRODUCTCODE"].ToString(),
                                ProductName = reader["PRODUCTNAME"].ToString(),
                                Quantity = Convert.ToInt32(reader["QUANTITY"]),
                                UnitPrice = Convert.ToDouble(reader["UNITPRICE"]),
                                Total = Convert.ToDouble(reader["Total"]),
                                SaleDate = Convert.ToDateTime(reader["SALEDATE"])
                            });
                        }
                    }
                }
                if(sales.Count ==0)
                {
                    MessageBox.Show("Report","Do not have Sale", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SaleReport report = new SaleReport();
                report.DataSource = sales;
                report.ShowPreviewDialog(); // shows 
                Program.Connection.Close();
            }
            catch (Exception ex)
            {
                if (Program.Connection.State == ConnectionState.Open)
                    Program.Connection.Close();

                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
