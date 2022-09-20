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
    public partial class Form1 : Form
    {
            //List<string> cars = new List<string>
            //{
            //    "Ferrari",
            //    "Mercedes",
            //    "Audi"
            //};
        public Form1()
        {
            InitializeComponent();


            //listBox1.Items.AddRange(cars.ToArray());
            //listBox1.SelectedIndex = 0;
            //listBox1.DataSource = cars;


            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Model="E-200",
                    Vendor="Mercedes",
                    Engine=6.3
                },
                new Car
                {
                    Model="Malibu",
                    Vendor="Chevrolet",
                    Engine=2
                },
                new Car
                {
                    Model="Hyundai",
                    Vendor="Sonata",
                    Engine=2.4
                }
            };

            listBox1.DisplayMember = nameof(Car.Model);
            //listBox1.DataSource = cars;
            listBox1.Items.AddRange(cars.ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.DataSource = null;
            //cars.Add("Cadillac");
            //listBox1.DataSource=cars;

            //var car = textBox1.Text;
            //textBox1.Text=String.Empty;
            //listBox1.Items.Add(car);



            var cars = listBox1.SelectedItems;
            listBox2.DataSource = null;
            listBox2.DataSource = cars;


            Form2 form = new Form2();
            form.ShowDialog();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //var currentCar=listBox1.SelectedItem as string;
            //label1.Text=currentCar;

            //var car=listBox1.SelectedItem as Car;
            //label1.Text = car.ToString();
            
            var car = listBox1.SelectedItem as Car;
           


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var currentCar=listBox1.SelectedItem as Car;
            listBox1.Items.Remove(currentCar);
            listBox2.Items.Add(currentCar.Model);
           
        }
    }
}
