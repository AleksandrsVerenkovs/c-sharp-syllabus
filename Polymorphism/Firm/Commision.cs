using System;

namespace Firm
{
    class Commision : Hourly
    {
        private double _totalSales;
        private double _commisionRate;

        public Commision(string eName, string eAddress, string ePhone, string socSecNumber, double rate, decimal commRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commisionRate = decimal.ToDouble(commRate);
            _totalSales = 0;
        }
        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var ts = _totalSales * _commisionRate;
            var payment = Math.Round(base.Pay() + ts,2);
            _totalSales = 0;
            return payment;
        }
        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal Sales: " + _totalSales;
            return result;
        }
    }
}
