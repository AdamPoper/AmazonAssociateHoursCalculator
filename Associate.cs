using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Adam Poper
 * Date: 3-19-2021
 * File: Associate.cs
 * Description: This is the associate class used to encapsulate all the data 
 * for a specific associate and provide the functionality to calculate all
 * the values for this particular associate
 */

namespace EmployeeHoursCalculator
{
    class Associate
    {
        private string firstName;
        private string lastName;
        public float clockIn1  { get; }   // start of the shift
        public float clockOut1 { get; }  // start first break
        public float clockIn2  { get; }   // end of first break
        public float clockOut2 { get; }  // end of shift;
        private float shiftLength;
        private static float normalShiftLength = 10.0f;
        private static float breakLength = 0.5f;
        private static float break2Start = 0.8333f;
        public Associate(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Associate(string firstName, string lastName,
            float clockIn1, float clockOut1,
            float clockIn2, float clockOut2)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.clockIn1 = clockIn1;
            this.clockOut1 = clockOut1;
            this.clockIn2 = clockIn2;
            this.clockOut2 = clockOut2;
            this.shiftLength = calcShiftLength();
        }
        private float calcShiftLength()
        {
            float totalHours = 0.0f;
            if(clockIn1 > clockOut2)
            {
                totalHours += (24.0f - clockIn1);
                totalHours += clockOut2;
                totalHours -= breakLength;
            }
            else if(clockIn1 < clockOut2)
            {
                totalHours = clockOut2 - clockIn1 - breakLength;
            }

            return totalHours;
        }        
        
        public struct HoursData
        {
            public float hoursLost;  // the hours lost
            public float shiftLeftNum;  // the shift they left after
        }

        // clockOut2 0:45
        public HoursData calcHoursLost()
        {
            HoursData hoursLostData = new HoursData();
            hoursLostData.hoursLost = normalShiftLength - shiftLength;
            if (clockOut2 > break2Start + breakLength && clockOut2 < clockIn1)
                hoursLostData.shiftLeftNum = 2;
            else if (clockOut2 > clockIn1 && clockOut2 > break2Start + breakLength)
                hoursLostData.shiftLeftNum = 1;
            else if (clockOut2 >= 0.0f && clockOut2 <= break2Start && clockOut2 > clockIn1)
                hoursLostData.shiftLeftNum = 2;
            else if (clockOut2 < clockIn1 && clockOut2 < break2Start)
                hoursLostData.shiftLeftNum = 1;
            return hoursLostData;
        }
        
        public float getShiftLength() { return this.shiftLength; }        
        public string getFirstName()  { return this.firstName;   }
        public string getLastName()   { return this.lastName;    }
    }
}
