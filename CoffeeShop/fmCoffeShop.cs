using CoffeeShop.decorator;
using CoffeeShop.drinks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class fmCoffeShop : MetroFramework.Forms.MetroForm
    {
        DrinksBase drinksWater = new water();
        DrinksBase drinksEspresso = new espresso();
        DrinksBase espressoSugar = new addSugarPrice(new espresso());
            
        public fmCoffeShop()
        {
            InitializeComponent();
            Board();
        }

        private void Board()
        {
            lbCostWater.Text = drinksWater.GetCost().ToString();
            lbCostEspresso.Text = drinksEspresso.GetCost().ToString();
        }
        
        private void btnWater_Click(object sender, EventArgs e)
        {
            lbTotal.Text = drinksWater.GetDesctiption() + " : " + drinksWater.GetCost().ToString() + " руб "; 
        }

        private void btnCoffe_Click(object sender, EventArgs e)
        {
            lbTotal.Text = drinksEspresso.GetDesctiption() + " : " + drinksEspresso.GetCost().ToString() + " руб ";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbTotal.Text);
        }

        private void chSugar_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show(espressoSugar.GetDesctiption() + " : " + espressoSugar.GetCost().ToString() + " руб ");
            lbTotal.Text = espressoSugar.GetDesctiption() + " : " + espressoSugar.GetCost().ToString() + " руб ";
        }

    }
}
