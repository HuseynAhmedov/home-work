using System;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------
            //[ 1 ] Verilmis string variable-in deyerini icerisinde her soz arasinda bir bosluq gelecek vezyete salan metod
            //string textMain = "  this   isnt  how you   write    ";
            //FixString(textMain);
            //--------------------------------------------------------------------
            //[ 2 ]  Gonderilmis string deyerinin asagidaki sertleri odeyib odemediyini qaytaran metod

            //string textMain = " Panzerkampfwagen 6 Tiger Ausf. E  ";
            //Console.WriteLine(CheakStringFormat(textMain));

            //--------------------------------------------------------------------
            //[ 3 ]  Parameter olaraq integer array variable-i (reference) ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod.

            //int[] arrInt = new int[10] { 4, 6, 3, 5, 3, 2, 5, 6, 1, 2 };
            //AddNum(ref arrInt , 10);

            //--------------------------------------------------------------------
            //[ 4 ] Gonderilmis string deyerinideki sözlərdən ibaret array qaytaran metod 

            //string textMain = " Art of war ";
            //string[] str = GetWordsArr(textMain);

            //--------------------------------------------------------------------
            //[ 5 ] Göndərilmiş string arrayindəki string dəyərlərin son sözlərdən ibarrət array qaytaran metod

            //string[] strArr = new string[4] {"Huseyn Ahmedov  " , "Ferid Resedov" , " Mahir Abbasov" , "Elnur Resedov Resid " };
            //var strtest = GetLastWord(strArr);

            //--------------------------------------------------------------------

        }
        static void FixString (string textInput)
        {
            textInput = textInput.Trim();
            for (int i = 0; i < textInput.Length;)
            {
                if (textInput[i] == ' ' && textInput[i+1] == ' ')
                  textInput = textInput.Remove(i,1);
                else
                  i++;
                
            }
            Console.WriteLine(textInput);
        }

        static bool CheakStringFormat (string textInput)
        {
            
            bool checkDigit = false;
            bool checkLower = false;
            bool cheakUpper = false;
            bool checkMain  = false;

            textInput = textInput.Trim();

            for (int i = 0; i < textInput.Length; i++)
            {
                
                if ( checkDigit == false && Char.IsDigit(textInput[i])) checkDigit = true;
                
                if ( checkLower == false && Char.IsLower(textInput[i])) checkLower = true;
                
                if ( cheakUpper == false && Char.IsUpper(textInput[i])) cheakUpper = true;

                if (cheakUpper == true && checkDigit == true && checkLower == true)
                {
                    checkMain = true;
                    break;
                }

            }
            return checkMain;
        }

        static void AddNum (ref int [] arrInput , int newNum)
        {
            Array.Resize(ref arrInput, arrInput.Length + 1);
            arrInput[arrInput.Length - 1] = newNum;
        }

        static string [] GetWordsArr (string textMain)
        {
            string[] wordsArr = new string[1];
            int j = 0;

            textMain = textMain.Trim();

            for (int i = 0; i < textMain.Length; i++)
            {
                if (!Char.IsWhiteSpace(textMain[i]))
                {
                    wordsArr[j] += textMain[i];
                }
                else if (Char.IsWhiteSpace(textMain[i]) == true && Char.IsWhiteSpace(textMain[i+1]) == false)
                {
                    Array.Resize(ref wordsArr, wordsArr.Length + 1);
                    j++;
                }
                
            }
            return wordsArr;
        }

        static string [] GetLastWord (string [] strArrInput)
        {
            string[] wantedWords = new string[strArrInput.Length];
            string tempStr = "";
            int maxIndex = 0;
            
            for (int i = 0; i <  strArrInput.Length; i++)
            {
                tempStr = strArrInput[i].Trim();
                for (int j = 0; j < tempStr.Length; j++)
                {
                    if (Char.IsWhiteSpace(tempStr[j]))
                    {
                        maxIndex = j;
                    }
                    
                }
                wantedWords[i] = tempStr.Remove(0,maxIndex+1);
            }
            return wantedWords;
        }
    }
}
