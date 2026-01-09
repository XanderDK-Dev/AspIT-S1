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
                TimeSpan difference = value.endDate - value.startDate;
                if (!((difference.Days == 14 && startDate.DayOfWeek == DayOfWeek.Monday) || (startDate.Day == 1 && endDate.Day == DateTime.DaysInMonth(endDate.Year, endDate.Month) && startDate.Month == endDate.Month && startDate.Year == endDate.Year)))
                {
                    throw new ArgumentException("Work time has to be either 14 days starting monday or a full month from start to end");
                }
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
                TimeSpan difference = payPeriod.endDate - payPeriod.startDate;
                decimal maxHours = difference.Days * 12;

                if (value < 0.00m || value > maxHours) 
                {
                    throw new ArgumentException($"Hourly worked must be between 0.0 and {maxHours}");
                }

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
                if (value < 0.00m || value > 10000m)
                {
                    throw new ArgumentException("Hourly salary must be between 0.0 and 10.000");
                }
                hourSalary = value;
            }
        }

        public PayCalculator((DateTime startDate, DateTime endDate) payPeriod, double taxPercent, decimal hoursWorked, decimal hourSalary)
        {
            // Assign each parameter to its Property (this triggers validation!)
            PayPeriod = payPeriod;
            TaxPercent = taxPercent;
            HoursWorked = hoursWorked;
            HourSalary = hourSalary;
        }

        public PayCalculator(int id, (DateTime startDate, DateTime endDate) payPeriod, double taxPercent, decimal hoursWorked, decimal hourSalary)
    : this(payPeriod, taxPercent, hoursWorked, hourSalary)  // Calls the other constructor first!
        {
            // Then do the extra stuff
            Id = id;
        }

        public decimal GrossPay()
        {
            decimal result = hoursWorked * hourSalary;
            return result;
        }

        public decimal TaxAmount()
        {
            decimal result = GrossPay() * (decimal)taxPercent;
            return result;
        }

        public decimal NetPay()
        {
            decimal result = GrossPay() - TaxAmount();
            return result;
        }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
