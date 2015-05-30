using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

class PhoneNumbers
{
    static void Main()
    {
        string namePattern = @"([A-Z]\w*)";
        Regex nameRegex = new Regex(namePattern);

        string phonePattern = @"(\d|\+)+[\d/\\.\-() ,\d]{1,}";
    }
}

