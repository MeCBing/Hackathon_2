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
    public partial class AddOilForm : Form
    {
        public AddOilForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OilTable oilTable = new OilTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter_ = double.Parse(numericUpDown1.Value.ToString()),
                Kilometer = double.Parse(numericUpDown2.Value.ToString())
            };
            OilModel oilModel = new OilModel();
            oilModel.OilTable.Add(oilTable);
            oilModel.SaveChanges();
            Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 0.00M;
            numericUpDown2.Value = 0.00M;
        }
    }
}
