using System; 
using System.Collections.Generic; 

namespace ProgrammingPractice.Arrays
{
    public class Atoi 
    {
        private bool hasSign;

        public int ConvertAtoi(string input)
        {
            string trimInput = input.Trim(); 

            if(string.IsNullOrEmpty(trimInput)){
                return 0; 
            }

            int multiplier = 1; 
            int index = 0; 

            if(Char.IsDigit(trimInput[0]) || trimInput[0] == '+' || trimInput[0] == '-') {
                multiplier = 1;
                index++;                  
            } else {
                return 0; 
            }
            

            if(trimInput[0] == '-'){
                multiplier = -1;
                index++;                  
            }

            while(index < trimInput.Length)
            {
                

                index++; 
            }





            for(int i = 0; i < input.Trim().Length; i++)
            {   
                if(input[i] == '+')
                {

                }         

                if(Char.IsDigit(input[i]) || input[i] == '+' || input[i] == '-')
                {
                    hasSign = true;                    
                } 
                else
                {
                    break; 
                }
            }

            return 0; 
        }
    }
}