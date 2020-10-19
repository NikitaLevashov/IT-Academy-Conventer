using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    interface IConverter
    {
        public double Value();
        public double ConvertToUsd(double value);
        public double ConvertToEur(double value);
        public double ConvertFromUsd(double value);
        public double ConvertFromEur(double value);
       
    }
}
