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

        private void buttonCalulate_Click(object sender, EventArgs e)
        {
            
            bool isLegal;   // Юридическое лицо?
            int age = 0;    // Возраст автомобиля
            int enginePower = 0;    // Мощность двигателя
            int engineCapacity = 0; // Объём двигателя
            int priceRUB = 0;       // Стоимость автомобиля в рублях

            //Задаём isLegal. Проверка на юридическое лицо:
            if (comboBoxPerson.Text == "Юридическое лицо")
                isLegal = true;
            else isLegal = false;

            //Задаём возраст автомобиля (age):
            if (comboBoxAge.Text == "До 3 лет")
                age = 0;
            else if (comboBoxAge.Text == "От 3 до 5 лет")
                age = 3;
            else if (comboBoxAge.Text == "От 5 до 7 лет")
                age = 5;

            //Устанавливаем остальные параметры:
            enginePower = Convert.ToInt32(textBoxEnginePower.Text);
            engineCapacity = Convert.ToInt32(textBoxEngineCapacity.Text);

            //Считываем цену в рублях:
            priceRUB = Convert.ToInt32(textBoxPrice.Text);

            int secondary = Calc_SecondaryFee(priceRUB);
            int recycle = Calc_FeeRecycle(isLegal, age, engineCapacity);

            labelSecondaryFeeResult.Text = secondary.ToString();
            labelFeeRecycleResult.Text = recycle.ToString();

            Calc_FeeRecycle(false, 0, 0);

            PrintResults();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxPerson.SelectedIndex = 0;
            comboBoxAge.SelectedIndex = 0;
            comboBoxEngineType.SelectedIndex = 0;
        }

        private void PrintResults()
        {

        }

        //Сбор за таможенное оформление:
        private int Calc_SecondaryFee(int priceRUB)
        {
            int fee = 0;

            if (priceRUB <= 200000) //200k
                fee = 500;
            else if (priceRUB <= 450000)  //450k
                fee = 1000;
            else if (priceRUB <= 1200000) //1 mil 
                fee = 2000;
            else if (priceRUB <= 2500000) //2.5 mil
                fee = 5500;
            else if (priceRUB <= 5000000) //5 mil
                fee = 7500;
            else if (priceRUB <= 10000000)//10 mil
                fee = 20000;
            else if (priceRUB <= 30000000)//30 mil
                fee = 50000;
            else if (priceRUB > 30000000) //more
                fee = 100000;

            return fee;
        }

        //Утилизационный сбор:
        private int Calc_FeeRecycle(bool isLegal, int age, int engine)
        {
            //Сбор (fee) = Базовая ставка * коэффициент:
            double fee = 0;

            //1. Базовая ставка:
            const int person = 20000; //Физ. лицо
            const int legal = 150000; //Юр. лицо
            //2. Коэффициент:
            double koef = 0;

            //___Физическое лицо:
            if (!isLegal)
            {
                if (age <= 3)
                    koef = 0.17;
                else
                    koef = 0.26;
            }
            else

            //___Юридическое лицо:
            if (isLegal)
            {
                //До 3х лет:
                if (age <= 3)
                {
                    if (engine <= 1000)
                        koef = 1.65;
                    else if (engine <= 2000)
                        koef = 4.2;
                    else if (engine <= 3000)
                        koef = 6.3;
                    else if (engine <= 3500)
                        koef = 5.73;
                    else if (engine > 3500)
                        koef = 9.08;
                }
                else
                //Больше 3х лет:
                if (age > 3)
                {
                    if (engine <= 1000)
                        koef = 6.15;
                    else if (engine <= 2000)
                        koef = 15.69;
                    else if (engine <= 3000)
                        koef = 24.01;
                    else if (engine <= 3500)
                        koef = 28.5;
                    else if (engine > 3500)
                        koef = 35.01;
                }
            }

            //Вычисляем сбор (Сбор = базовая ставка * коэффициент):
            fee = person * koef;

            //Возвращаем fee в виде целого числа:
            return Convert.ToInt32(fee);
        }

       
    }
}
