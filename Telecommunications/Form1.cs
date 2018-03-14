using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecommunications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string s = "中華電信 月租費350元 每分鐘4元\n\n遠傳 月租費400元 每分鐘3元\n\n台灣大哥大 月租費500元 每分鐘2元";
            label2.Text = s;
        }
        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label3.Text = string.Empty;
            if(e.KeyChar==(char)Keys.Enter)
            {
                Printflabel3();
            }
        }
        private void Printflabel3()
        {
            int minute = 0;
            List<Class1> list = new List<Class1>();
            int.TryParse(textBox1.Text, out minute);
            list.Add(new Class1() { Name = "中華電信", Money = (minute * 4 + 350) });
            list.Add(new Class1() { Name = "遠傳", Money = (minute * 3 + 400) });
            list.Add(new Class1() { Name = "台灣大哥大", Money = (minute * 2 + 500) });
            foreach (var index in list)
            {
                label3.Text = label3.Text + $"{index.Name} : {(index.Money).ToString("C")}\n\n";
            }
            PrintfBast(list);
        }
        private void PrintfBast(List<Class1> list)
        {
            var bast = list.Where((y) => y.Money == list.Min((x) => x.Money));
            label3.Text = label3.Text + "最佳電信 : ";
            string s = string.Empty;
            foreach (var index in bast)
            {
                s = s + $" {index.Name} ";
            }
            label3.Text = label3.Text + s;
        }
    }
    public class Class1
    {
        public string Name { get; set; }
        public int Money { get; set; }
    }
}
