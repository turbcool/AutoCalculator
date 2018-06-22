using System;
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
            //0. Если пользователь забыл ввести данные:
            if (textBoxEngineCapacity.Text == "" || textBoxEnginePower.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Введите значения в поля"); //Выводим ошибку
                return; //Останавливаем работу функции
            }

            bool isLegal;   // Юридическое лицо?
            int age = 0;    // Возраст автомобиля
            int enginePower = 0;    // Мощность двигателя
            int engineCapacity = 0; // Объём двигателя
            int priceRUB = 0;       // Стоимость автомобиля в рублях

            //_____1. Считывание данных с формы:

            // Задаём isLegal. Проверка на юридическое лицо:
            if (comboBoxPerson.Text == "Юридическое лицо")
                isLegal = true;
            else isLegal = false;

            // Задаём возраст автомобиля (age):
            if (comboBoxAge.Text == "До 3 лет")
                age = 0;
            else if (comboBoxAge.Text == "От 3 до 5 лет")
                age = 4;
            else if (comboBoxAge.Text == "От 5 до 7 лет")
                age = 6;

            // Устанавливаем остальные параметры:
            enginePower = Convert.ToInt32(textBoxEnginePower.Text);
            engineCapacity = Convert.ToInt32(textBoxEngineCapacity.Text);

            // Считываем цену в рублях:
            priceRUB = Convert.ToInt32(textBoxPrice.Text);

            //______2. Расчёт данных:
            int mainTax = Calc_MainTax(isLegal, age, engineCapacity, priceRUB); // Таможенная пошлина
            int secondary = Calc_SecondaryFee(priceRUB);                        // Сбор за таможенное оформление
            int recycle = Calc_FeeRecycle(isLegal, age, engineCapacity);        // Утилизационный сбор

            //______3. Вывод результатов:
            labelTaxResult.Text = mainTax.ToString();
            labelSecondaryFeeResult.Text = secondary.ToString();
            labelFeeRecycleResult.Text = recycle.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxPerson.SelectedIndex = 0;
            comboBoxAge.SelectedIndex = 0;
            comboBoxEngineType.SelectedIndex = 0;
        }

        //Вычисление основной пошлины:
        private int Calc_MainTax(bool isLegal, int age, int engine, int priceRUB)
        {
            double fee = 0;
            double minimumFee;

            int priceEUR = priceRUB / 73;

            double percent = 0;
            double minCoef = 0;

            //Физические лица:
            if (!isLegal)
            {
                //Меньше 3 лет:
                if (age <= 3)
                {
                    if (priceEUR <= 8500)
                    {
                        percent = 0.54;
                        minCoef = 2.5;
                    }
                    else if (priceEUR <= 16700)
                    {
                        percent = 0.48;
                        minCoef = 3.5;
                    }
                    else if (priceEUR <= 42300)
                    {
                        percent = 0.48;
                        minCoef = 5.5;
                    }
                    else if (priceEUR <= 84500)
                    {
                        percent = 0.48;
                        minCoef = 7.5;
                    }
                    else if (priceEUR <= 169000)
                    {
                        percent = 0.48;
                        minCoef = 15;
                    }
                    else if (priceEUR > 169000)
                    {
                        percent = 0.48;
                        minCoef = 20;
                    }
                }
                //От 3 до 5 лет:
                else if (age > 3 && age <= 5)
                {
                    if (engine <= 1000)
                        minCoef = 1.5;
                    else if (engine <= 1500)
                        minCoef = 1.7;
                    else if (engine <= 1800)
                        minCoef = 2.5;
                    else if (engine <= 2300)
                        minCoef = 2.7;
                    else if (engine <= 3000)
                        minCoef = 3;
                    else if (engine > 3000)
                        minCoef = 3.6;
                }
                //Больше 5 лет:
                else if (age > 5)
                {
                    if (engine <= 1000)
                        minCoef = 3;
                    else if (engine <= 1500)
                        minCoef = 3.2;
                    else if (engine <= 1800)
                        minCoef = 3.5;
                    else if (engine <= 2300)
                        minCoef = 4.8;
                    else if (engine <= 3000)
                        minCoef = 5;
                    else if (engine > 3000)
                        minCoef = 5.7;
                }
            }
            else

            if (isLegal)
            {
            }

            fee = priceEUR * percent;
            minimumFee = engine * minCoef;

            if (fee < minimumFee)
                fee = minimumFee;

            fee = fee * 73;

            return Convert.ToInt32(fee);
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

        #region Проверка_вводимых_символов

        //Функция, проверяющая напечатанный символ:
        private void HandleKey_Number(KeyPressEventArgs e)
        {
            //Если клавиша - это цифра или backspace:
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                ; // Разрешаем напечатать символ

            //Если мы нажали не цифру, то запрещаем печатать символ:
            else e.Handled = true;
        }

        //Функции, ловящие событие "печать символа" (KeyPress):
        private void textBoxEnginePower_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey_Number(e);
        }
        private void textBoxEngineCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey_Number(e);
        }
        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleKey_Number(e);
        }

        #endregion Проверка_вводимых_символов

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelAutoPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelEngineSize_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEngineCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnginePower_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEnginePower_Click(object sender, EventArgs e)
        {

        }
    }
}