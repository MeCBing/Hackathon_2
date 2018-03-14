using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oil.Models;

namespace Oil
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OilModel oilModel = new OilModel();
            var all = oilModel.OilTable.Where((x) => x.RefuelingDate > dateTimePicker1.Value && x.RefuelingDate < dateTimePicker2.Value).ToList();
            dataGridView1.DataSource = all;
            double kilometer = all.Max((x) => x.Kilometer);
            double liter_ = all.Max((x) => x.Liter_)-all.Min((y)=>y.Liter_);
            double total = kilometer / liter_;
            label3.Text = "每公升平均油耗 :  " + total.ToString();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
