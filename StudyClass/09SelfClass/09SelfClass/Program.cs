using System;
using System.IO;
using System.Collections.Generic;

namespace _09SelfClass
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public class Seiseki
        {

            public Seiseki(string filename)
            {
                 StreamReader file1 = new StreamReader(filename);


            string fis = file1.ReadLine();
            char[] kugiru = { ',', ' ', '\t' };
            //空の値をどのように処理をするのかについての記述、今回は、,,というふうな値があるときは、空白を入れ込むというものになっている
            string[] Subject = fis.Split(kugiru, StringSplitOptions.RemoveEmptyEntries);
            List<string> SubjectName = new List<string>();


            for (int i = 1; i < Subject.Length; i++)
            {
                SubjectName.Add(Subject[i]);
            }


            Dictionary<string, Dictionary<string, int>> StuGrades = new Dictionary<string, Dictionary<string, int>>();

            while (!file1.EndOfStream)
            {
                string StuNamSub = file1.ReadLine();
                string[] Student = StuNamSub.Split(kugiru);
                string StudentName = Student[0];
                //Console.WriteLine(StudentName);
                Dictionary<string, int> SubNum = new Dictionary<string, int>();

                for (int i = 1; i < SubjectName.Count + 1; i++)
                {
                    SubNum.Add(SubjectName[i - 1], Int32.Parse(Student[i]));
                }

                StuGrades.Add(StudentName, SubNum);

            }

            public void Hyoji()
                {
                    foreach(string a in)
                }

           
        }

        public static double SubjectAverage(string StudentNum, char[] kugiru)
        {

            string[] StData = StudentNum.Split(kugiru, StringSplitOptions.RemoveEmptyEntries);
            double StudentAverage = 0.0;
            int SubjectNum = 0;
            for (int i = 1; i < StData.Length; i++)
            {
                SubjectNum = Int32.Parse(StData[i]);
                StudentAverage += SubjectNum;
            }
            StudentAverage /= StData.Length;

            return StudentAverage;

        }
    }
}
