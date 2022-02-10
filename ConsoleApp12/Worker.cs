using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp12
{
    struct Worker
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        private string High { get; set; }
        public string DataBirthsday { get; set; }
        public string Place { get; set; }
        string Data = DateTime.Now.ToShortTimeString();
        public Worker(string ID, string FullName, string Age, string High, string DataBirthsday, string Place)
        {
            this.ID = ID;
            this.FullName = FullName;
            this.Age = Age;
            this.High = High;
            this.DataBirthsday = DataBirthsday;
            this.Place = Place;
        }
        public static void ReadFileMy(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {

                Console.Write(lines[i]);
            }
        }

        public string PrintID()
        {
            string liness = File.ReadAllText(@"d:\data3.txt");//создание масива для вывода без #
            string[] sss = liness.Split('#');
            
            return $"{sss[0]}";
        }
        public void Save()
        {
            
            string info1 = $"{ ID }#";
            string info2 = $"{ FullName }#";
            string info3 = $"{ Data }#";
            string info4 = $"{ Age }#";
            string info5 = $"{ High }#";
            string info6 = $"{ DataBirthsday }#";
            string info7 = $"{ Place }#";

            string[] sss = new string[] {info1, info2, info3, info4, info5, info6, info7 };
            

            File.WriteAllLines(@"d:\data3.txt", sss);
            

        }
        public void NewSave(string ID, string FullName, string Age, string High, string DataBirthsday, string Place)
        {
            string info1 = $"{ ID }#";
            string info2 = $"{ FullName }#";
            string info3 = $"{ Data }#";
            string info4 = $"{ Age }#";
            string info5 = $"{ High }#";
            string info6 = $"{ DataBirthsday }#";
            string info7 = $"{ Place }#";

            string[] sss = new string[] { info1, info2, info3, info4, info5, info6, info7 };
 

            File.AppendAllLines(@"d:\data3.txt", sss);
        }

        public void NewID(string ID)
        {
            this.ID = ID;
        }
        public void NewName(string FullName)
        {
            this.FullName = FullName ;
        }
        public void NewAge(string Age)
        {
            this.Age = Age;
        }
        public void NewHigh(string High)
        {
            this.High = High;
        }
        public void newDatabir(string DataBirthsday)
        { this.DataBirthsday = DataBirthsday;}

        public void NewPlace(string Place)
        {
            this.Place = Place;
        }
        public void Delete()
        {
            File.Delete(@"d:\data3.txt");
        }
        public void RedactorData()
        { 
               
        }
    }
}
