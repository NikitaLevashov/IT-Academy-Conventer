using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    class Converter:IConverter
    {
        public double USD { get; }
        public double EUR { get; }
       
        public Converter(double _usd, double _eur)
        {
            USD = _usd;
            EUR = _eur;
        }

        public double Value ()
        {
            Console.Write("Введите количество валюты, которое вы хотите конвентировать:  ");
            double.TryParse(Console.ReadLine(), out double _value);
            return _value;
        }
        public double ConvertToUsd(double _value)
        {
            return _value / USD;
        }

        public double ConvertToEur(double _value)
        {
            return _value / EUR;
        }

        public double ConvertFromUsd(double _value)
        {
            return USD * _value;
        }

        public double ConvertFromEur(double _value)
        {
            return EUR * _value;
        }

    
    }

} 

