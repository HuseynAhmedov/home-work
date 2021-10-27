using System;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //<-------------------------------------------------------------------------------->
            //[ 1 ] Verilmis string deyerini ters sekilde qaytaran metod.

            //string input_str = "Hello world?";
            //Console.WriteLine(ReverseStr(input_str));

            //<-------------------------------------------------------------------------------->
            //[ 2 ] Verilmis string deyerinde olan sozlerin sayini qaytaran metod.

            //string input = "salam sag ol de ki getdim";
            //Console.WriteLine(WordCount(input));

            //<-------------------------------------------------------------------------------->
            //[ 3 ] Verilmis string deyerinde verilmis char-in indexlerinden ibaret array qaytaran metod.

            //int [] char_index = CharIndexFinder("Salam", 'a');

            //<-------------------------------------------------------------------------------->
        }

        static string ReverseStr (string input) // [ 1 ]
        {
            string rvs_str = "";

            for (int i = input.Length - 1; i >= 0; i--) rvs_str += input[i];
            
            return rvs_str;
        }
        
        static int WordCount (string input ) // [ 2 ] 
        {
            int word_count = 0;
            if (input[0] != ' ') word_count++;
         
            for (int i = 0; i < input.Length - 1; i++)
               if (input[i] == ' ' && input[i+1] != ' ' ) word_count++;
            
            return word_count;
        }

        static int [] CharIndexFinder (string input , char wanted_char) // [ 3 ] 
        {
            int[] temp_index = new int[input.Length];
            int char_count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == wanted_char)
                {
                    temp_index[char_count] = i;
                    char_count++;
                }
            }
            int[] char_index = new int[char_count];
            for (int i = 0; i < char_count; i++)  char_index[i] = temp_index[i];
            return temp_index;
        }
    }
}
