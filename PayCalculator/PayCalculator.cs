using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Linq;

namespace PayCheck
{
    internal class PayCalculator
    {

        private (DateTime startDate, DateTime endDate) payPeriod;
        public (DateTime startDate, DateTime endDate) PayPeriod
        {
            get 
            { 
                return payPeriod; 
            }
            set
            {
                // Your validation goes here
                // Check if dates are valid
                // Check if it's 14 days starting Monday OR 1 calendar month

                payPeriod = value;
            }
        }

        private DateTime startDate;
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        private DateTime endDate;
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
            }
        }

        private double taxPercent;
        public double TaxPercent
        {
            get
            {
                return taxPercent;
            }
            set
            {
                if (value < 0.0 || value > 1.0)
                {
                    throw new ArgumentException("Tax percent must be between 0.0 and 1.0");
                }
                taxPercent = value;
            }
        }

        private decimal hoursWorked;
        public decimal HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                hoursWorked = value;
            }
        }

        private decimal hourSalary;
        public decimal HourSalary
        {
            get
            {
                return hourSalary;
            }
            set
            {
                if (value < 0.00m || value > 10.000m)
                {
                    throw new ArgumentException("Hourly salary must be between 0.0 and 10.000");
                }
                hourSalary = value;
            }
        }

        
    }
}
