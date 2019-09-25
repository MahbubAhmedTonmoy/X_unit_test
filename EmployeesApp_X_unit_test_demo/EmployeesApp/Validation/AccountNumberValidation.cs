using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Validation
{
    public class AccountNumberValidation
    {
        // 123-1234567890-12 ok
        private const int startingPartLength = 3;
        private const int middlePartLength = 10;
        private const int lastPartLength = 2;

        public bool IsValid(string accountNumber)
        {
            var firstDelimiter = accountNumber.IndexOf('-'); // return 3 or -1

            var secondDelimiter = accountNumber.LastIndexOf('-'); // return 14 or -1 

            if(firstDelimiter == -1 || (firstDelimiter == secondDelimiter))
            {
                throw new ArgumentException();
            }

            var firstPart = accountNumber.Substring(0, firstDelimiter); // (length of 123 )

            if(firstPart.Length != startingPartLength) return false;

            var tempPart = accountNumber.Remove(0, startingPartLength+1);

            var middlePart = tempPart.Substring(0, tempPart.IndexOf('-'));

            if(middlePart.Length != middlePartLength) return false;

            var lastPart = accountNumber.Substring(secondDelimiter+1);

            if(lastPart.Length != lastPartLength) return false;


            return true;
        }

    }
}