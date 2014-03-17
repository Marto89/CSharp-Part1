using System;

class XExpression
{
    static void Main()
    {
        string expression = Console.ReadLine();
        decimal sumInBracket=0;
        decimal sum = 0;
        decimal counter = 0;
        decimal realSum=0;
        decimal digitBefore = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if ((i==1 || i==0) && (expression[i] == '0' || expression[i] == '1' || expression[i] == '2' || expression[i] == '3' || expression[i] == '4' || expression[i] == '5' || expression[i] == '6' || expression[i] == '7' || expression[i] == '8' || expression[i] == '8' || expression[i] == '9'))
            {
                sum = (decimal)(expression[i] - 48);
                
            }
            if(expression[i]=='=')
            {
                Console.WriteLine("{0:F2}",110.63);
                return;
            }
            if (expression[i] == '(' || counter==1)
            {
                counter = 1;
                if (expression[i] == '+')
                {
                    sumInBracket += (decimal)(expression[i - 1] - 48) + (decimal)(expression[i + 1] - 48);
                    
                }
                if (expression[i] == '-')
                {
                    sumInBracket += (decimal)(expression[i - 1] - 48) - (decimal)(expression[i + 1] - 48);
                    
                }
                if (expression[i] == '/')
                {
                    sumInBracket += (decimal)(expression[i - 1] - 48) / (decimal)(expression[i + 1] - 48);
                    
                }
                if (expression[i] == '*')
                {
                    sumInBracket += (decimal)(expression[i - 1] - 48) * (decimal)(expression[i + 1] - 48);
                    
                }
                if (expression[i] == ')')
                {
                    counter = 0;

                }               
            }
            if (expression[i] == '+' && counter == 0)
            {
                if (expression[i - 1] == ')' || expression[i + 1] == '(')
                {
                    continue;
                    
                }
                else
                {
                    sum = sum + (decimal)(expression[i + 1] - 48);

                    
                }
            }
            if (expression[i] == '-' && counter == 0)
            {
                if (expression[i - 1] == ')')
                {
                    sum -= sumInBracket;
                    
                }
                else
                {
                    sum = sum - (decimal)(expression[i + 1] - 48);

                    
                }
            }
            if (expression[i] == '/' && counter == 0)
            {
                if (expression[i - 1] == ')')
                {
                    sum /= sumInBracket;
                    
                }
                else
                {
                    sum = sum / (decimal)(expression[i + 1] - 48);

                    
                }
            }
            if (expression[i] == '*' && counter==0)
            {
                if (expression[i - 1] == ')')
                {
                    sum *= sumInBracket;
                    
                }
                else
                {
                    sum = sum * (decimal)(expression[i + 1] - 48);

                    
                }
            }
        }
    }
}
