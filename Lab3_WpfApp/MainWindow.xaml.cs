using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace Lab3_WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)        // гарнитура
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
                textBox.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)        // кегль
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            double size = Convert.ToDouble(fontSize);
            if (textBox != null)
                textBox.FontSize = size;
        }

        private void Button_Click(object sender, RoutedEventArgs e)                //жирное начертание
        {
            if (textBox != null)
            {
                if (textBox.FontWeight == FontWeights.Normal)
                {
                    textBox.FontWeight = FontWeights.UltraBold;
                }
                else
                { textBox.FontWeight = FontWeights.Normal; }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)        // курсивное начертание
        {

            if (textBox != null)
            {
                if (textBox.FontStyle == FontStyles.Normal)
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
                else
                { textBox.FontStyle = FontStyles.Normal; }

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)                      // подчеркнутое начертание (пыталась сделать, чтобы отключалось, но не получилось)
        {
            if (textBox != null)
            {
                if (textBox.TextDecorations == TextDecorations.OverLine)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else
                { textBox.TextDecorations = TextDecorations.OverLine; }

            }
        }


        private void RadioButton_Checked(object sender, RoutedEventArgs e)          // черный цвет текста
        {
            if (textBox != null)
            {
                Color colorBlack = new Color();
                colorBlack = Color.FromRgb(0, 0, 0);
                textBox.Foreground = new SolidColorBrush(colorBlack);
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)            // красный цвет текста
        {
            if (textBox != null)
            {
                Color colorRed = new Color();
                colorRed = Color.FromRgb(255, 0, 0);
                textBox.Foreground = new SolidColorBrush(colorRed);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)           // очистка и сброс настроек, но в элементах управления ComboBox не поменяны активные параметры
        {
            if (textBox != null)
            {
                textBox.Text = "";
                textBox.TextDecorations = TextDecorations.OverLine;
                textBox.FontStyle = FontStyles.Normal;
                textBox.FontWeight = FontWeights.Normal;
                Color colorBlack = new Color();
                colorBlack = Color.FromRgb(0, 0, 0);
                textBox.Foreground = new SolidColorBrush(colorBlack);
                textBox.FontFamily = new FontFamily("Arial");
                textBox.FontSize = 12;
                MessageBox.Show("Выполнено удаление введенного текста");
            }

        }
    }
}
