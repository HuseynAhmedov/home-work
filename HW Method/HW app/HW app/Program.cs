using System;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //<-------------------------------------------------------------------------------->
            //[ 1 ]  Verilmis string deyerinde verilmis charin hansi indexde yerlesdiyini tapib qaytaran metod.Misalcun metodu call edib "salam" ve 'l' deyerleri gondersek geriye 2 qaytarmalidir amma char hemin stringde olmasa -1 qaytarmalidir.

            //string str_input = "salam";
            //char wanted_char = 'l';
            //int char_index = CharIndexFinder(str_input, wanted_char);
            //if (char_index >= 0)
            //    Console.WriteLine($"given char is in index : {char_index}");
            //else
            //    Console.WriteLine("given char was not found ");

            //<-------------------------------------------------------------------------------->
            //[ 2 ] Verilmis ededin en yaxin asagi kokaltisini tapib qaytaran

            //int input= 25;
            //int input_sqrt = SqrtOf(input);
            //Console.WriteLine($" input nummbers closest sqrt : {input_sqrt}");

            //<-------------------------------------------------------------------------------->
            //[ 3 ] Verilmis ededin reqemleri cemini tapib qaytaran metod.

            //int input = 123;
            //int total = NumTotal(input);
            //Console.WriteLine($"Inside num total : {total}");

            //<-------------------------------------------------------------------------------->
            //[ 4 ] Verilmis indeger arrayinin icindeki en boyuk deyeri tapan metod

            //int[] num_arr = new int[10]{ 210,23,45,11,-34,200,67,10,78,340};
            //int arr_max = MaxNum(num_arr);
            //Console.WriteLine($"Biggest nummber inside the array : {arr_max}");

            //<-------------------------------------------------------------------------------->
            //[ 5 ] Verilmis integer arrayindeki butun elementleri musbet sekilder qaytaran metod.Misalcun parametr olaraq {1,-4,9,-8} deyerleri olan array daxil edilse arqument kimi metod bize {1,4,9,8} deyerleri olan array qaytarmalidir

            //int[] num_arr = new int[10] { 22, 1, -45, 23, -1, -99, -43, 23, 89, -11 };
            //int[] fixed_arr = PostiveNum(num_arr);
            //foreach (var item in fixed_arr)
            //{
            //    Console.WriteLine(item);
            //}

            //<-------------------------------------------------------------------------------->
        }

        static int CharIndexFinder(string str_input , char wanted_char) // [ 1 ]
        {
            for (int i = 0; i < str_input.Length; i++)
            {
                if (str_input[i] == wanted_char)
                {
                    return i;
                }
            }
            return -1;
        }

        static int SqrtOf(int input ) // [ 2 ]
        {
            int i = 1;
            while (i * i <= input) i++;
            return i - 1;
        }

        static int NumTotal(int input ) // [ 3 ]
        {
            int digit1 = 0;
            int total = 0;
            while (input > 0 )
            {
                digit1 = input % 10;
                total += digit1;
                input = (input - digit1) / 10;
            }
            return total;
        }

        static int MaxNum (int [] input) // [ 4 ]
        {
            int max = input[0];
            foreach (var item in input)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        static int [] PostiveNum(int [] input ) // [ 5 ]
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < 0)
                {
                    input[i] *= -1;
                }
            }
            return input;
        }
    }
}
