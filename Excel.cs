using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

/*
 * Author: Adam Poper
 * Date: 3-19-2021
 * File: Excel.cs
 * Description: This class is used for providing the functionality to interact with the excel sheet
 */

namespace EmployeeHoursCalculator
{
    class Excel
    {
        private string path;
        Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(this.path);   // open the excel workbook
            ws = wb.Worksheets[sheet];          // add the worksheet to the workbook
        }
        public string ReadCell(int row, int col)
        {
            // excel rows and colums start at 1            
            if (ws.Cells[row, col].Value2 != null)
                return ws.Cells[row, col].Value.ToString();
            else
                return "";
        }
        /*
         * All times are expressed as a float value out of 24
         * 18:30 (6:30) is expressed as 18.5 and 22:20 is expressed as 22.333, and so on
         */
        public float convertToTimeStamp(string time)
        {
            // times from excel are initially expressed as a value from 0 to 1 to 
            // indicate an hour out of 24. This method converts that to the 24 decimal time stamp used by this program


            // the parse method for float wasn't working so I used double
            float time24 = (float)Double.Parse(time);            
            // multiply by 24 to get the hour
            return (time24 * 24.0f);
        }
    }
}
