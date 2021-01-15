using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _09SelfClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"\\Mac\Home\Downloads\GitHub\CSharp_School\StudyClass\01ClassTask\09SelfClass\09SelfClass\Hello.txt";
            Seiseki test = new Seiseki(filename);
            //Dictionary<string,double> SubAve = test.AverageOfSubjects();
            //foreach (string result in SubAve.Keys)
            //{
            //    Console.WriteLine("{0}:{1}",result,SubAve[result]);
            //}

            //test.NumberOfStudents = 10;
            //Console.WriteLine(test.NumberOfStudents);

            Console.WriteLine(test.RankingInClass(1));
            Console.WriteLine(test.RankingInClass(2));
            Console.WriteLine(test.RankingInClass(3));

            //test.RankingInClass(1);
            //test.RankingInClass(2);
            //test.RankingInClass(3);


        }

        public class Seiseki
        {
            private Dictionary<string, Dictionary<string, int>> StuGrades = new Dictionary<string, Dictionary<string, int>>();
            private char[] kugiru = { ',', ' ', '\t' ,'　','\n','\r'};
            private List<string> SubjectName = new List<string>();
            private int NumOfStudents = 0;
            private List<Dictionary<string, Dictionary<string, int>>> AllData = new List<Dictionary<string, Dictionary<string, int>>>();
            private List<string> student = new List<string>();


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
                    int StudentNum = Int32.Parse(Student[0]);
                    string StudentName = Student[1];
              
                    
                    //Console.WriteLine(StudentName);
                    Dictionary<string, int> SubNum = new Dictionary<string, int>();



                    for (int i = 0; i < SubjectName.Count; i++)
                    {
                        SubNum.Add(SubjectName[i], Int32.Parse(Student[i+2]));
                    }

                    StuGrades.Add(StudentName, SubNum);
                    AllData.Add(StuGrades);
                }
                foreach (string StudentName in StuGrades.Keys)
                {
                    student.Add(StudentName);
                }




            }

            public int NumOfSubjects
            {
                get
                {
                    return SubjectName.Count;
                }
            }

            public int NumberOfStudents
            {

                set
                {
                    NumOfStudents = value;
                    if (NumOfStudents < StuGrades.Count)
                    {
                        NumOfStudents = StuGrades.Count;
                    }

                }

                get
                {
                    return NumOfStudents;
                }
            }

            public Dictionary<string,double> AverageOfSubjects()
            {
                Dictionary<string, double> AverageOfSubjectsAll = new Dictionary<string, double>();
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

                for (int i=0;i<SubjectName.Count;i++)
                {
                    AverageOfSubjectsAll.Add(SubjectName[i], Kamokuheikin[i]);
                }

                return AverageOfSubjectsAll;
           }

            public string GetStudentName(int num)
            {
                num = num - 1;
                return student[num];
            }

            public double AverageOfStudent(int num)
            {
                double AverageOfStudent = 0.0;
                int SubjectNum = 0;
                num -= 1;
                string StudentName = student[num];

                foreach (double sum in StuGrades[StudentName].Values)
                {
                    AverageOfStudent += sum;
                    SubjectNum += 1;
                }

                AverageOfStudent /= SubjectNum;

                return AverageOfStudent;
            }
            public int RankingInClass(int num)
            {
                Dictionary<string, double> studentData = new Dictionary<string, double>();
                List<double> studentJuni = new List<double>();
                int RankingInClass = 0;
                

                for (int i=0;i< student.Count; i++)
                {
                    studentData.Add(student[i], AverageOfStudent(i+1));
                }

                foreach (double seiseki in studentData.Values)
                {
                    studentJuni.Add(seiseki);
                }
                studentJuni.Sort();
                //for (int i = 0; i < studentJuni.Count; i++)
                //{
                //    Console.WriteLine(studentJuni[i]);
                //}

                //var studentSeiseki = studentData.Values.ToArray();

                double n = AverageOfStudent(num);

                RankingInClass = studentJuni.Count- studentJuni.BinarySearch(n);

                string aan = null;

                return RankingInClass;
            }
        }
    }
}
