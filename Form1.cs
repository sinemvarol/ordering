using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            combosize.Items.Add("small");
            combosize.Items.Add("medium");
            combosize.Items.Add("large");

            combodrink.Items.Add("2,5 lt Coca Cola");
            combodrink.Items.Add("1 lt Coca Cola");
            combodrink.Items.Add("1 lt Sprite");

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            string extra = "";

            if (checkketch.Checked == true)
            {
                extra += "Ketchup";
                price = 1;
            }
            else if (checkmayon.Checked == true)
            {
                extra += "" + "Mayonnaise";
                price = 1;
            }
            else if (checkpep.Checked == true)
            {
                extra += "" + "Pepper Pickle";
                price = 1;
            }
            else if (checkpot.Checked == true)
            {
                extra += "" + "Potato";
                price = 1;
            }
            else if (checktom.Checked == true)
            {
                extra += "" + "Tomato";
                price = 1;
            }
            else if (checkcucum.Checked == true)
            {
                extra += "" + "Cucumber Pickle";
                price = 1;
            }

            // extra if block for pricing according to size of döner

            if (combosize.Text == "small")
            {
                price += textdonernum.Value * 15;
            }
            else if (combosize.Text == "medium")
            {
                price += textdonernum.Value * 20;
            }
            else if (combosize.Text == "large")
            {
                price += textdonernum.Value * 25;
            }

            // extra if block for pricing according to drink options.
            if (combodrink.Text == "2,5 lt Coca Cola")
            {
                price += numberdrink.Value * 5;
            }
            else if (combodrink.Text=="1 lt Coca Cola")
            {
                price += numberdrink.Value * 3;
            }
            else if(combodrink.Text=="1 lt Sprite")
            {
                price += numberdrink.Value * 4;
            }

            ////
            listname.Items.Add(textname.Text);
            listtelno.Items.Add(texttel.Text);
            listadd.Items.Add(textadd.Text);
            listdoner.Items.Add("Number: " + textdonernum.Value +" "+ "Size: " + combosize.Text);
            listextra.Items.Add(extra);
            listdrink.Items.Add("Number: " + numberdrink.Value +" "+ "Drinks: " + combodrink.Text);
            listprice.Items.Add(price+"TL");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // clear textboxes
            textname.Clear();
            texttel.Clear();
            textBox3.Clear();
            // clear combobox
            combosize.Text = "";
            combodrink.Text = "";

            textdonernum.Value = 0;
            numberdrink.Value = 0;

            // clear checkboxes
            checkcucum.Checked = false;
            checkketch.Checked = false;
            checkmayon.Checked = false;
            checkpep.Checked = false;
            checkpot.Checked = false;
            checktom.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear textboxes
            textname.Clear();
            texttel.Clear();
            textBox3.Clear();
            // clear combobox
            combosize.Text = "";
            combodrink.Text = "";

            textdonernum.Value = 0;
            numberdrink.Value = 0;

            // clear checkboxes
            checkcucum.Checked = false;
            checkketch.Checked = false;
            checkmayon.Checked = false;
            checkpep.Checked = false;
            checkpot.Checked = false;
            checktom.Checked = false;

            //clear listbox

            listname.Items.Clear();
            listdoner.Items.Clear();
            listdrink.Items.Clear();
            listextra.Items.Clear();
            listadd.Items.Clear();
            listtelno.Items.Clear();
            listprice.Items.Clear();
        }

        private void listdrink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
