using Stud_Serialize.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Stud_Serialize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Students> ListStud = new List<Students>();
            ListStud.Add(new Students(1, "Student1", 1));
            ListStud.Add(new Students(2, "Student1", 1));
            ListStud.Add(new Students(11, "Student10", 1));
            ListStud.Add(new Students(13, "Student12", 1));
            ListStud.Add(new Students(15, "Student14", 1));
            ListStud.Add(new Students(17, "Student16", 1));
            ListStud.Add(new Students(19, "Student18", 1));
            ListStud.Add(new Students(4, "Student3", 1));
            ListStud.Add(new Students(6, "Student5", 1));
            ListStud.Add(new Students(7, "Student6",1));

            List<Students> ListStud2 = new List<Students>();
            ListStud2.Add(new Students(9, "Student8",2));
            ListStud2.Add(new Students(10, "Student9", 2));
            ListStud2.Add(new Students(12, "Student11", 2));           
            ListStud2.Add(new Students(16, "Student15", 2));           
            ListStud2.Add(new Students(20, "Student19", 2));
            ListStud2.Add(new Students(21, "Student20", 2));

            List<Students> ListStud3 = new List<Students>();
            ListStud3.Add(new Students(3, "Student2", 3));
            ListStud3.Add(new Students(18, "Student17", 3));
            ListStud3.Add(new Students(14, "Student13", 3));
            ListStud3.Add(new Students(8, "Student7", 3));
            ListStud3.Add(new Students(5, "Student4", 3));          
         

            List<Group> listGroup_ = new List<Group>();
            listGroup_.Add((new Group(1, "group 1", ListStud, ListStud.Count())));
            listGroup_.Add((new Group(2, "group 2", ListStud2, ListStud2.Count())));
            listGroup_.Add((new Group(3, "group 3", ListStud3, ListStud3.Count())));

            BinaryFormatter formater = new BinaryFormatter();
            using (FileStream fs = new FileStream("ListSerialGroup.dat", FileMode.OpenOrCreate))
            {
                formater.Serialize(fs, listGroup_);
                Console.WriteLine("Объект сериализован");
            }            
        }
    }
}
