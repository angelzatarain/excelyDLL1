using System;
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
//Los siguientes 3 usings los necesitamos y se deben poner despues de poner la referencia
using Microsoft.Office.Interop;
using e = Microsoft.Office.Interop.Excel;
using System.IO;


namespace PruebaDLL2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Varaibles Globales
        e.Application excelApp;
        e.Workbook libro;
        e.Worksheet hoja;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String fileTest = @"c:\ana\pruebaDll2.xlsx";
            if (File.Exists(fileTest))
                File.Delete(fileTest);
            excelApp = new e.Application();
            libro = excelApp.Workbooks.Add();
            hoja = (e.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[1, 1] = textBox.Text;

            libro.SaveAs(fileTest);
            libro.Close();
            excelApp.Quit();
            MessageBox.Show("El libro fue creado");
        }

    }
}
