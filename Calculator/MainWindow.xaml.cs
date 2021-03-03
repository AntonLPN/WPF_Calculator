using System;
using System.Data;//для математической операции стринг 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string text_calculation;//для вывода операции того что производм слаживаем умножаем и т.д
        private string result;

        public MainWindow()
        {
            InitializeComponent();
            text_calculation = string.Empty;
            result = string.Empty;
        }

        void Plus_press()
        {
            string buf = this.text_calculation;
            buf = buf.Substring(0, buf.Length - 1);



        }



        /// <summary>
        /// Метод отлавливание что нажато по клавищам 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            string pressed_key = e.Key.ToString();
            this.mainWindow.Title = pressed_key;//для дебага декодировки какая кнопка нажата выводим титул определение нажатой кнопки
            //цифра 1
            if (e.Key==Key.NumPad1 || e.Key==Key.D1 )
            {

                this.buttonNum1.Background = Brushes.Blue;
                this.text_calculation += "1";
                this.TexBlocCalculation.Text = text_calculation;

               
            }
            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                this.buttonNum2.Background = Brushes.Blue;
                this.text_calculation += "2";
                this.TexBlocCalculation.Text = text_calculation;
            }

            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                this.buttonNum3.Background = Brushes.Blue;
                this.text_calculation += "3";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                this.buttonName4.Background = Brushes.Blue;
                this.text_calculation += "4";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                this.buttonName5.Background = Brushes.Blue;
                this.text_calculation += "5";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                this.buttonNum6.Background = Brushes.Blue;
                this.text_calculation += "6";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                this.buttonNum7.Background = Brushes.Blue;
                this.text_calculation += "7";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                this.buttonNum8.Background = Brushes.Blue;
                this.text_calculation += "8";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                this.buttonNum9.Background = Brushes.Blue;
                this.text_calculation += "9";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                this.buttonNumZero.Background = Brushes.Blue;
                this.text_calculation += "0";
                this.TexBlocCalculation.Text = text_calculation;
            }
            //---------------------------------------------------------------------
            //backspace
            if (e.Key == Key.Back)
            {
                this.buttonBackspace.Background = Brushes.Blue;
        
                if (text_calculation.Length!=0)
                {
                    this.text_calculation = text_calculation.Remove(text_calculation.Length - 1);
                    this.TexBlocCalculation.Text = text_calculation;
                }
              
            }
            //точка
            if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                this.buttonPoint.Background = Brushes.Blue;
                this.text_calculation += ".";
                this.TexBlocCalculation.Text = text_calculation;
            }
            //равно по нажатию Enter
            //главное событие в программе 
            //**************************************************
            if (e.Key == Key.Return)
            {
                this.buttonEqual.Background = Brushes.Blue;
                try
                {
                    this.result = new DataTable().Compute(this.text_calculation, null).ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
                if (result.Length!=0)
                {
                    this.TextBoxResult.Text = result;
                    this.result = string.Empty;
                }
             

            }
            //***********************************************************




            if (e.Key == Key.OemPlus || e.Key == Key.Add)
            {
                this.buttonPlus.Background = Brushes.Blue;
                this.text_calculation += "+";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                this.buttonMinus.Background = Brushes.Blue;
                this.text_calculation += "-";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.Multiply)
            {
                this.buttonMultiply.Background = Brushes.Blue;
                this.text_calculation += "*";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.Divide)
            {
                this.buttonMultiply.Background = Brushes.Blue;
                this.text_calculation += "/";
                this.TexBlocCalculation.Text = text_calculation;
            }
            if (e.Key == Key.C)
            {
                this.ButtonC.Background = Brushes.Blue;
                this.text_calculation=string.Empty;
                this.result = string.Empty;
                this.TexBlocCalculation.Text = "0";
                this.TextBoxResult.Text = "Result";
            }

        }

        private void mainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
       
                this.buttonNum1.Background=Brushes.DarkGray;              
            }
            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                this.buttonNum2.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                this.buttonNum3.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                this.buttonName4.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                this.buttonName5.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                this.buttonNum6.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                this.buttonNum7.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                this.buttonNum8.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                this.buttonNum9.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                this.buttonNumZero.Background = Brushes.DarkGray;
            }

            ///-----------------------------------------------------------
            if (e.Key==Key.Back)
            {
                this.buttonBackspace.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.OemPeriod || e.Key==Key.Decimal)
            {
                this.buttonPoint.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.Return)
            {
                this.buttonEqual.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.OemPlus || e.Key == Key.Add)
            {
                this.buttonPlus.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.OemMinus || e.Key == Key.Subtract)
            {
                this.buttonMinus.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.Multiply)
            {
                this.buttonMultiply.Background = Brushes.DarkGray;
            }
            if (e.Key == Key.Divide)
            {
                this.buttonMultiply.Background = Brushes.DarkGray;
               
            }
            if (e.Key == Key.C)
            {
                this.ButtonC.Background = Brushes.DarkGray;
              
            }

        }

    
        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            this.text_calculation = string.Empty;
            this.result = string.Empty;
            this.TexBlocCalculation.Text = "0";
            this.TextBoxResult.Text = "Result";
        }
        //НЕ ЗНАЮ ПОЧЕМУ НО ПРИ НАЖАТИИ МЫШКОЙ БАТОНА ЦИФРА ДОБАВЛЯЛАСЬ В СТРОКУ А ЗАТЕМ ПО НАЖАТИЮ ENTER СНОВА
        //ДОБАВЛЯЛАСЬ ЭТА ЦЫФРА НЕ СРАБАТЫВАЛО СОБЫТИЕ ENTER К КОТОРОМУ ПРИВЯЗАНО РАВЕНСТВО
        //ТОЕСТЬ 1+1111111111111 ПО НАЖАТИЮ ENTER
        //ЕСЛИ МОЖНО ДАЙТЕ ПОДСКАЗКУ В КОМЕНТАРИИ В МАЙ СТАТ
        //я понимаю что Enter тут  это return поэтому и происходит возврат на батон но как от этого избавиться

     

        private void buttonNum1_Click_1(object sender, RoutedEventArgs e)
        {
            this.text_calculation += "1";
            this.TexBlocCalculation.Text = text_calculation;
        }
    }
}
