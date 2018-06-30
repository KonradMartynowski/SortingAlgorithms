using System;
using System.Collections.Generic;
using System.Data;
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
using System.Diagnostics;

namespace AlgorytmyIStrukturyDanych
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreateArray_Click(object sender, RoutedEventArgs e)
        {
            int arraySize = GetArrayParameters.GetArrayLenght(CmbArraySize.Text);

            int maxRange = GetArrayParameters.GetMaxRange(CmbElementSize.Text);

            int minRange = GetArrayParameters.GetMinRange(CmbElementSize.Text);

            try
            {
                new FileManager().FillFile(arraySize, maxRange, minRange);
                MessageBox.Show("Utworzono " + arraySize + " elementową tablicę.", "Komunikat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Quo Vadis?");
            }

            OutputArray.Array = new FileManager().GetIntArrayFromFile();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e) => Process.Start(@".\Wejscie.dat");

        private void BtnOutput_Click(object sender, RoutedEventArgs e) => Process.Start(@".\Wyjscie.dat");

        private void BtnHeapSort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HeapSort();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Trzeba wygenerować nową tablicę.","Komunikat");
            }
        }

        private void HeapSort()
        {
            Stopwatch sw = Stopwatch.StartNew();
            SortAlgorithms.HeapSort(OutputArray.Array);
            sw.Stop();

            new FileManager().SetIntArrayToFile(OutputArray.Array);
            HeapGridBinding(new HeapAlgorithmMeasurement(
                OutputArray.Array.Length, sw.Elapsed.TotalSeconds));

            MessageBox.Show("Sortowanie zakończone", "Komunikat");
        }

        private void BtnBubleSort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BubleSort();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Trzeba wygenerować nową tablicę", "Komunikat");
            }
        }

        private void BubleSort()
        {
            Stopwatch sw = Stopwatch.StartNew();
            SortAlgorithms.BubbleSort(OutputArray.Array);
            sw.Stop();

            new FileManager().SetIntArrayToFile(OutputArray.Array);
            BubbleGridBinding(new BubbleAlgorithmMeasurement(
                OutputArray.Array.Length, sw.Elapsed.TotalSeconds));

            MessageBox.Show("Sortowanie zakończone", "Komunikat");
        }

        private void HeapGridBinding(HeapAlgorithmMeasurement item)
        {
            HeapSortView.Items.Add(item);
        }

        private void BubbleGridBinding(BubbleAlgorithmMeasurement item)
        {
            BubbleSortView.Items.Add(item);
        }

        private void btnManual_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@".\Manual.pdf");
        }
    }
}
