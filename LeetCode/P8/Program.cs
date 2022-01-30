

 

// System.Console.WriteLine(myAtoi("92332"));
// System.Console.WriteLine(myAtoi("  +  413"));

// System.Console.WriteLine(myAtoi("+-12"));
// System.Console.WriteLine(myAtoi("00000-42a1234"));
// System.Console.WriteLine(myAtoi("-91283472332"));
System.Console.WriteLine(myAtoi("-2147483647"));

 
 

int myAtoi(string s)
{
    bool positive = true;
    bool signFound = false;
    bool firstDigit = true;
    double output = 0;
    foreach (char c in s)
    {
        if (!signFound && firstDigit && (c == '+' || c == '-'))
        {
            positive = c == '+' ? true : false;
            signFound = true;
        }
        else if (c == ' ' && (!firstDigit || signFound))
        {
            break;
        }
        else if (c == ' ' && firstDigit)
        {
            continue;
        }
        else if ((int)c >= 48 && (int)c <= 57)
        {
            if (firstDigit) firstDigit = false;

            if (double.IsInfinity(output * 10))
                return positive ? Int32.MaxValue : Int32.MinValue;

            output = (output * 10) + ((int)c - 48);

            if (output > Int32.MaxValue || output < Int32.MinValue)
                return positive ? Int32.MaxValue : Int32.MinValue;



        }
        else
            break;

    }


    return positive ? (int)output : -((int)output);
}


