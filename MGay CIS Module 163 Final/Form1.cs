using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGay_CIS_Module_163_Final
{
    public partial class Form1 : Form
    {
        private double distance, fuel, fuelEconomy;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxUnits.Items.Add("English");
            comboBoxUnits.Items.Add("Metric");
            comboBoxUnits.SelectedIndex = 0;
           
            timerComplete.Start();
        }

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBoxUnits.Text == "English")
            {
                lblDistanceUnits.Text = "Miles";
                lblFuelUnits.Text = "Gallons";
                lblFuelEconomyUnits.Text = "Miles per Gallon";

                try
                {
                    distance = double.Parse(txtBoxDistance.Text);
                    distance = distance / 1.609;
                    txtBoxDistance.Text = distance.ToString("n2");

                    fuel = double.Parse(txtBoxFuel.Text);
                    fuel = fuel / 3.785;
                    txtBoxFuel.Text = fuel.ToString("n2");

                    fuelEconomy = distance / fuel;

                    lblCalculate.Text = fuelEconomy.ToString("n2");

                }
                catch
                {
                    //Do nothing
                }
            }

            else if (comboBoxUnits.Text == "Metric")
            {
                lblDistanceUnits.Text = "Kilometers";
                lblFuelUnits.Text = "Liters";
                lblFuelEconomyUnits.Text = "Kilometers per Liter";

                try
                {
                    distance = double.Parse(txtBoxDistance.Text);
                    distance = distance * 1.609;
                    txtBoxDistance.Text = distance.ToString("n2");

                    fuel = double.Parse(txtBoxFuel.Text);
                    fuel = fuel * 3.785;
                    txtBoxFuel.Text = fuel.ToString("n2");

                    fuelEconomy = distance / fuel;

                    lblCalculate.Text = fuelEconomy.ToString("n2");

                }
                catch 
                {
                    //Do nothing
                }
            }
          
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                distance = double.Parse(txtBoxDistance.Text);
                fuel = double.Parse(txtBoxFuel.Text);

                fuelEconomy = distance / fuel;

                lblCalculate.Text = fuelEconomy.ToString("n2");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxDistance.Text = "";
            txtBoxFuel.Text = "";
            lblCalculate.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.Green;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.Silver;
        }

        private void radioBtnDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            grpBoxTheme.ForeColor = Color.White;
            btnClear.BackColor = Color.Silver;
            btnClear.ForeColor = Color.Black;
            btnExit.BackColor = Color.Silver;
            btnExit.ForeColor = Color.Black;
            btnCalculate.BackColor = Color.Silver;
            btnCalculate.ForeColor = Color.Black;
            lblCalculate.BackColor = Color.White;
            lblCalculate.ForeColor = Color.Black;
        }

        private void radioBtnDefaultTheme_CheckedChanged(object sender, EventArgs e)
        {
           
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            grpBoxTheme.ForeColor = Color.Black;
            btnClear.BackColor = Color.Silver;
            btnClear.ForeColor = Color.Black;
            btnExit.BackColor = Color.Silver;
            btnExit.ForeColor = Color.Black;
            btnCalculate.BackColor = Color.Silver;
            btnCalculate.ForeColor = Color.Black;
        }

        private void radioBtnPurpleTheme_CheckedChanged(object sender, EventArgs e)
        {
            
            this.BackColor = Color.Purple;
            this.ForeColor = Color.White;
            grpBoxTheme.ForeColor = Color.White;
            btnClear.BackColor = Color.MediumPurple;
            btnClear.ForeColor = Color.Black;
            btnExit.BackColor = Color.MediumPurple;
            btnExit.ForeColor = Color.Black;
            btnCalculate.BackColor = Color.MediumPurple;
            btnCalculate.ForeColor = Color.Black;
            lblCalculate.BackColor = Color.White;
            lblCalculate.ForeColor = Color.Black; 
        }

        private void timerComplete_Tick(object sender, EventArgs e)
        {
            timerComplete.Stop();
            
            if(txtBoxDistance.Text.Length == 0 || txtBoxFuel.Text.Length == 0)
            {
                MessageBox.Show("Please complete the form.");
            }
        }
    }
}
