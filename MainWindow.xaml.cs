using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

/*
 * Author: Adam Poper
 * Date: 3-19-2021
 * File: MainWindow.xaml.cs
 * Description: This is the entry point to the program and where all 
 * the program operations are invoked
 */

namespace EmployeeHoursCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        private Excel excel;
        private List<Associate> associates;  // a list of associates that represents all the assocoates in the excel sheet
        private string fileName = "";  // filename for the excel file being read from
        public MainWindow()
        {
            InitializeComponent();
            //AllocConsole();            

            // add the calcAllData method the rendering target so it calculates when a new file is opened
            CompositionTarget.Rendering += this.calcAllData;
        }
        
        // open the excel file and create the excel object
        private void fileButt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                fileName = openFileDialog.FileName;
                excel = new Excel(fileName, 1);
            }
        }
        public void calcAllData(object sender, EventArgs e)
        {
            if (fileName != "")
            {                
                associates = new List<Associate>();
                // excel sheets start at 1, not 0 and 2 is the first entry
                for (int i = 2; excel.ReadCell(i, 1) != ""; i++)
                {
                    // create the associates
                    associates.Add(new Associate(excel.ReadCell(i, 1), excel.ReadCell(i, 2),
                        excel.convertToTimeStamp(excel.ReadCell(i, 5)), excel.convertToTimeStamp(excel.ReadCell(i, 6)),
                        excel.convertToTimeStamp(excel.ReadCell(i, 7)), excel.convertToTimeStamp(excel.ReadCell(i, 8))));                    
                }
                // calculate all the hours and associate counts
                int row = 0;
                float totalHoursLostAfter1st = 0.0f;
                float totalHoursLostAfter2nd = 0.0f;
                int associatesLeftFirst = 0;
                int associatesLeftSecond = 0;
                float totalHoursLost = 0.0f;
                foreach (var ass in associates)
                {
                    Associate.HoursData hoursData = new Associate.HoursData();
                    hoursData = ass.calcHoursLost();
                    totalHoursLost += hoursData.hoursLost;
                    switch (hoursData.shiftLeftNum)
                    {
                        case 1:
                            totalHoursLostAfter1st += hoursData.hoursLost;
                            associatesLeftFirst++;
                            break;
                        case 2:
                            totalHoursLostAfter2nd += hoursData.hoursLost;
                            associatesLeftSecond++;
                            break;
                    }
                    row++;
                }
                // update the UI
                associatesLeftFirstValueLabel.Text = associatesLeftFirst.ToString();
                associatesLeftSecondValueLabel.Text = associatesLeftSecond.ToString();
                hoursLostFirstValueLabel.Text = totalHoursLostAfter1st.ToString();
                hoursLostSecondValueLabel.Text = totalHoursLostAfter2nd.ToString();
                totalHoursLostValueLabel.Text = totalHoursLost.ToString();
                fileName = "";  // stops the looping
            }
        }        
    }    
}
