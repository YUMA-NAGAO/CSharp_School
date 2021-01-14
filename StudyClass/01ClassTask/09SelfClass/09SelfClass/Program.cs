using System;
using System.IO;
using System.Collections.Generic;

namespace _09SelfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"09SelfClass/Hello.txt";
            Seiseki test = new Seiseki(filename);
            List<double> SubAve = test.SubjectAverage();
            for (int i = 0; i < SubAve.Count; i++)
            {
                Console.WriteLine(SubAve[i]);
            }
        }

        public class Seiseki
        {
            private Dictionary<string, Dictionary<string, int>> StuGrades = new Dictionary<string, Dictionary<string, int>>();
            private char[] kugiru = { ',', ' ', '\t' ,'　','\n','\r'};
            List<string> SubjectName = new List<string>();

            public Seiseki(string filename)
            {
                StreamReader file1 = new StreamReader(filename);


                string fis = file1.ReadLine();
                //空の値をどのように処理をするのかについての記述、今回は、,,というふうな値があるときは、空白を入れ込むというものになっている
                string[] Subject = fis.Split(kugiru, StringSplitOptions.RemoveEmptyEntries);



                for (int i = 2; i < Subject.Length; i++)
                {
                    SubjectName.Add(Subject[i]);
                }



                    while (!file1.EndOfStream)
                {
                    string StuNamSub = file1.ReadLine();
                    string[] Student = StuNamSub.Split(kugiru,StringSplitOptions.RemoveEmptyEntries);
                    string StudentName = Student[1];
              
                    
                    //Console.WriteLine(StudentName);
                    Dictionary<string, int> SubNum = new Dictionary<string, int>();



                    for (int i = 0; i < SubjectName.Count; i++)
                    {
                        SubNum.Add(SubjectName[i], Int32.Parse(Student[i+2]));
                    }

                    StuGrades.Add(StudentName, SubNum);

                }




            }

            public List<double> SubjectAverage()
            {

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
                return Kamokuheikin;
           }
        }
    }
}
