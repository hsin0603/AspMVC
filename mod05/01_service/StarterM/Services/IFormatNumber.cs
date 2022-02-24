using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Services
{
   public interface IFormatNumber
    {
        string GetFormattedNumber(double number);
    }
    public class FormatNumber : IFormatNumber
    {
        public string GetFormattedNumber(double number)
        {
            return $"{number:n2}";
        }
    }
    public class FormatNumber2 : IFormatNumber
    {
        public string GetFormattedNumber(double number)
        {
            return $"{number:n0}";
        }
    }
}
