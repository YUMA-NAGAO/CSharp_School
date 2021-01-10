using System;
using System.IO;
using System.Collections.Generic;

namespace _09SelfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file1 = new StreamReader(@"C:\Users\yuma\source\repos\StudyClass\08Class\08Class\Hello.txt");

            //Console.WriteLine(file1.ReadLine());

            //while (!file1.EndOfStream)
            //{
            //    string seiseki=file1.ReadLine();
            //    char[] kugiru = { ',', ' ', '\t' };
            //    Console.WriteLine(SubjectAverage(seiseki, kugiru));

            //}

            string fis = file1.ReadLine();
            char[] kugiru = { ',', ' ', '\t' };
            //空の値をどのように処理をするのかについての記述、今回は、,,というふうな値があるときは、空白を入れ込むというものになっている
            string[] Subject = fis.Split(kugiru, StringSplitOptions.RemoveEmptyEntries);
            List<string> SubjectName = new List<string>();

            for (int i = 1; i < Subject.Length; i++)
            {
                SubjectName.Add(Subject[i]);
            }

            //for (int i = 0; i < SubjectName.Count; i++)
            //{
            //    Console.WriteLine(SubjectName[i]);
            //}

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


            List<double> Kamokuheikin = new List<double>();
            foreach (string kamoku in SubjectName)
            {
                double average = 0.0;
                double avern = 0.0;
                foreach (string KojinMei in StuGrades.Keys)
                {
                    Dictionary<string, int> Kojinseiseki = StuGrades[KojinMei];
                    foreach (string kamokumei in Kojinseiseki.Keys)
                    {
                        if (kamokumei == kamoku)
                        {

                            average += Kojinseiseki[kamokumei];

                        }
                    }
                    avern += 1;


                }
                average /= avern;
                Kamokuheikin.Add(average);
            }

            for (int i = 0; i < Kamokuheikin.Count; i++)
            {
                Console.WriteLine("{0}:{1}", SubjectName[i], Kamokuheikin[i]);
            }

            Console.WriteLine("hello");



        }
        public static double SubjectAverage(string student, char[] kugiru)
        {

            string[] StData = student.Split(kugiru, StringSplitOptions.RemoveEmptyEntries);
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
