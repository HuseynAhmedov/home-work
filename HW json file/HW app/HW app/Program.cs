
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------
            //[ 1 ]

            //List<Student> students = new List<Student>();
            //students.Add(new Student("Huseyn", "Ahmedov", 10));
            //students.Add(new Student("Huseyn1", "Ahmedov1", 11));
            //students.Add(new Student("Huseyn2", "Ahmedov2", 12));
            //students.Add(new Student("Huseyn3", "Ahmedov3", 13));

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //if (!File.Exists(path + @"\Json.txt"))
            //{
            //    FileStream stream = new FileStream(path + @"\Json.txt", FileMode.CreateNew);
            //    stream.Close();
            //}
            //DirectoryInfo jsonDirInfo = new DirectoryInfo(path + @"\Json.txt");
            //SerializeJson(students , jsonDirInfo);
            //DeSerializeJson(jsonDirInfo);

            //------------------------------------------------------------
            //[ 2 ]

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Console.Write(" Enter file name : ");
            //path += @"\" + Console.ReadLine();

            //while (!Directory.Exists(path))
            //{
            //    path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    Console.Write("\n Given path does not exsist \n Enter file name : ");
            //    path += @"\" + Console.ReadLine().Trim();
            //}
            //GetDirectories(path);

            //------------------------------------------------------------
        }

        public static void SerializeJson (object toSerialize , DirectoryInfo jsonDirInfo)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            string txt = "";
            
            txt = json.Serialize(toSerialize);
            File.WriteAllText(jsonDirInfo.ToString(), txt);
        }

        public static List<Student> DeSerializeJson (DirectoryInfo jsonDirInfo)
        {
            List<Student> students = new List<Student>();
            JavaScriptSerializer js = new JavaScriptSerializer();
            using (StreamReader sr = new StreamReader(jsonDirInfo.ToString()))
            {
                students = js.Deserialize<List<Student>>(sr.ReadToEnd());
            }
            return students;
        }

        public static void GetDirectories(string path)
        {
            List<string> dirList =  new List<string>(Directory.GetDirectories(path));
            foreach (string subdirectory in dirList)
            {
                GetSubDirectories(subdirectory);
                Console.Write("\n");
            }
        }

        private static void GetSubDirectories(string dirStr)
        {
            Console.WriteLine(dirStr);
            List<string> dirList = new List<string>(Directory.GetDirectories(dirStr));
            foreach (string subdirectory in dirList)
            {
                Console.Write(" ");
                GetSubDirectories(subdirectory);
                Console.Write(" ");
            }
        }
    }
}