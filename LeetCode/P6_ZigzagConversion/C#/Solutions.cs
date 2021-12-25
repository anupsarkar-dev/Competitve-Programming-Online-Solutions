public class Solution {
    public string Convert(string s, int numRows) {
        
           var len = s.Length;
            if (len <= 2 || numRows == 1 || numRows > len
                || numRows == len) return s;


            char[,] arr = new char[numRows, len - 1];

            int i = 0;
            int row = 0;
            int column = 0;

            var rowIncrementSwitchflag = false;
            var firstPass = false;


            foreach (var ch in s)
            {

                arr[row, column] = ch;
                i++;

                if (i % numRows == 0)
                {
                    if (rowIncrementSwitchflag)
                        rowIncrementSwitchflag = false;
                    else
                        rowIncrementSwitchflag = true;

                    if (!firstPass)
                    {
                        firstPass = true;
                        numRows = numRows - 1;
                    }

                    i = 0;
                }

                if (!rowIncrementSwitchflag)
                {
                    row++;

                }
                else
                {
                    column++;
                    row--;
                }

            }

            var result = new StringBuilder();

            
            for (int k = 0; k <= numRows; k++)
            {
                for (int j = 0; j < len - 1; j++)
                {
                    var c = arr[k, j];
                    if (c != '\0')
                        result.Append(c);
                }

            }
       return result.ToString();
        
    }
}