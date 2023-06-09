using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1._1
{
    public partial class MainPage : ContentPage
    {
        Entry number1Entry, number2Entry;
        Button sumButton, subtractButton, multiplyButton, divideButton;
        Label resultLabel;
        public MainPage()
        {
            InitializeComponent();

            // Crear los controles
            number1Entry = new Entry();
            number2Entry = new Entry();

            sumButton = new Button
            {
                Text = "Sumar"
            };
            sumButton.Clicked += SumButton_Clicked;

            subtractButton = new Button
            {
                Text = "Restar"
            };
            subtractButton.Clicked += SubtractButton_Clicked;

            multiplyButton = new Button
            {
                Text = "Multiplicar"
            };
            multiplyButton.Clicked += MultiplyButton_Clicked;

            divideButton = new Button
            {
                Text = "Dividir"
            };
            divideButton.Clicked += DivideButton_Clicked;

            resultLabel = new Label();

            // Crear el diseño de la página
            StackLayout layout = new StackLayout();
            layout.Children.Add(new Label { Text = "Número 1" });
            layout.Children.Add(number1Entry);
            layout.Children.Add(new Label { Text = "Número 2" });
            layout.Children.Add(number2Entry);
            layout.Children.Add(sumButton);
            layout.Children.Add(subtractButton);
            layout.Children.Add(multiplyButton);
            layout.Children.Add(divideButton);
            layout.Children.Add(new Label { Text = "Resultado" });
            layout.Children.Add(resultLabel);

            Content = layout;
        }

        private void SumButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(number1Entry.Text, out double number1) && double.TryParse(number2Entry.Text, out double number2))
            {
                double result = number1 + number2;
                resultLabel.Text = result.ToString();
            }
        }

        private void SubtractButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(number1Entry.Text, out double number1) && double.TryParse(number2Entry.Text, out double number2))
            {
                double result = number1 - number2;
                resultLabel.Text = result.ToString();
            }
        }

        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(number1Entry.Text, out double number1) && double.TryParse(number2Entry.Text, out double number2))
            {
                double result = number1 * number2;
                resultLabel.Text = result.ToString();
            }
        }

        private void DivideButton_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(number1Entry.Text, out double number1) && double.TryParse(number2Entry.Text, out double number2))
            {
                if (number2 != 0)
                {
                    double result = number1 / number2;
                    resultLabel.Text = result.ToString();
                }
                else
                {
                    resultLabel.Text = "Error: División entre cero";
                }
            }
        }
    }
}
