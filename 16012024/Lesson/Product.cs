using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Product
    {
        public Product(double costPrice)
        {
            _costPrice= costPrice;
        }
        private string Name;
        private double _price;
        private double _costPrice;
        private double _totalProfit;
        public double TotalProfit
        {
            get
            {
                return _totalProfit;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value >= _costPrice)
                {
                    _price = value;
                }
            }
        }
        public void Sell()
        {
            _totalProfit += _price - _costPrice;
        }

        public double GetTotalProfit()
        {
            return _totalProfit;
        }

        //public void SetPrice(double value)
        //{
        //    if (value >= CostPrice)
        //    {
        //        _price = value;
        //    }
        //}

        //public double GetPrice()
        //{
        //    return _price;
        //}

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            if (value != null)
            {
                Name = value;
            }
        }
    }
}
