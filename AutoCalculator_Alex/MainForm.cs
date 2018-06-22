using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCalculator_Alex
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Сбор за таможенное оформление:
        private int Calc_SecondaryFee(int priceRUB)
        {
            int fee = 0;

            if (priceRUB < 200000) //200k
                fee = 500;
            else if (priceRUB < 450000)  //450k
                fee = 1000;
            else if (priceRUB < 1200000) //1 mil 
                fee = 2000;
            else if (priceRUB < 2500000) //2.5 mil
                fee = 5500;
            else if (priceRUB < 5000000) //5 mil
                fee = 7500;
            else if (priceRUB < 10000000)//10 mil
                fee = 20000;
            else if (priceRUB < 30000000)//30 mil
                fee = 50000;
            else if (priceRUB > 30000000)//more
                fee = 100000;

            return fee;
        }

        //Утилизационный сбор:
        private int Calc_FeeRecycle()
        {
            int fee = 0;



            return fee;
        }
    }
}
