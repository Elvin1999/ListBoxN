using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form2 : Form
    {
        List<string> todos = new List<string> { "Write Code", "Sleep", "Drink Coffee" };
        public Form2()
        {
            InitializeComponent();

            List<string> students = new List<string> { "Elvin", "Tural", "Namiq" };
            checkedListBox1.Items.AddRange(todos.ToArray());

            comboBox1.DataSource = students;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current=comboBox1.SelectedItem as string;
            label1.Text = current;
        }

        public void ClearLabels()
        {
            foreach (var item in this.Controls)
            {
                if(item is Label lb)
                {
                    this.Controls.Remove(lb);   
                }
            }
        }

        public void SetLabel()
        {
            //StringBuilder sb = new StringBuilder();

            //foreach (var item in checkedListBox1.CheckedItems)
            //{
            //    sb.AppendLine(item.ToString());
            //}
            //label1.Text = sb.ToString();


            ClearLabels();

            int x = 500;
            int y = 100;
            foreach (var item in checkedListBox1.Items)
            {
              
            Label label = new Label();
                label.AutoSize = true;
                label.Font=new Font("Comic Sans MS",30,FontStyle.Bold);
                label.Location=new Point(x,y);
                y += 100;
                var index = checkedListBox1.CheckedItems.IndexOf(item);
                if(index!= -1)
                {
                    label.BackColor = Color.SpringGreen;
                }
                else
                {
                    label.BackColor = Color.DeepSkyBlue;
                }

                label.Text = item.ToString();
                this.Controls.Add(label);
            }



        }


        private void checkedListBox1_DoubleClick(object sender, EventArgs e)
        {

            SetLabel();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearLabels();
        }
    }
}
