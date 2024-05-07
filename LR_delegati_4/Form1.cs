using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_delegati_4
{
    public delegate double CalculateUsefulness(double calories);



    public partial class Form1 : Form
    {
        private List<FoodProduct> products = new List<FoodProduct>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("сок");
            comboBox1.Items.Add("торт");
            comboBox1.Items.Add("фрукт");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var product in products)
            {
                var usefulness = product.UsefulnessDelegate(product.Calories);
                listBox1.Items.Add($"{product.Type}: {product.Name}, Калории: {product.Calories}, Полезность: {usefulness}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new FoodProduct
            {
                Type = comboBox1.SelectedItem.ToString(),
                Name = textBox1.Text,
                Calories = double.Parse(textBox2.Text)
            };

            if (product.Type == "сок")
                product.UsefulnessDelegate = UsefulnessCalculator.Method1;
            else if (product.Type == "торт")
                product.UsefulnessDelegate = UsefulnessCalculator.Method2;
            else if (product.Type == "фрукт")
                product.UsefulnessDelegate = UsefulnessCalculator.Method3;

            products.Add(product);

            // Очистка полей ввода после добавления продукта
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
