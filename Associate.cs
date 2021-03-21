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
        private static float onTimeLimit = 4.91667f;
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
        public Associate(float clockIn1, float clockOut1, float clockIn2, float clockOut2)
        {
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
            public float breakLeftNum;  // the shift they left after, 1 is after 1st break and 2 is after 2nd break. -1 is they left on time
        }
        
        public HoursData calcHoursLost()
        {
            HoursData hoursLostData = new HoursData();
            hoursLostData.hoursLost = normalShiftLength - shiftLength;
            if (clockOut2 > break2Start + breakLength && clockOut2 <= onTimeLimit)
                hoursLostData.breakLeftNum = 2;
            if (clockOut2 < 24.0f && clockOut2 > clockIn2)
                hoursLostData.breakLeftNum = 1;
            if (clockOut2 >= 0.0f && clockOut2 < break2Start)
                hoursLostData.breakLeftNum = 1;
            if (clockIn1 < clockOut2 && clockOut2 > clockIn2)
                hoursLostData.breakLeftNum = 1;            
            if (clockOut2 >= onTimeLimit && clockOut2 < clockIn1)
                hoursLostData.breakLeftNum = -1;
            return hoursLostData;
        }
        
        public float getShiftLength() { return this.shiftLength; }        
        public string getFirstName()  { return this.firstName;   }
        public string getLastName()   { return this.lastName;    }
    }
}
