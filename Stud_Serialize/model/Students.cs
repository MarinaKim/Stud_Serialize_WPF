using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stud_Serialize.model
{

    [Serializable]
    public class Group
    {
        public int groupId { get; set; }
        public string groupName { get; set; }
        public List<Students> Students;
        public int countOfStud { get; set; }
        public Group() { }
        public Group(int id, string name,List<Students> lStud, int count)
        {
            groupId = id;
            groupName = name;
            Students = lStud;
            countOfStud = count;
        }
    }


    [Serializable]
    public class Students
    {
        public Students() { }
        public Students(int id, string name, int gr)
        {
            studId = id;
            studName = name;
            groupId = gr;
        }
        public int studId { get; set; }
        public string studName { get; set; }
        public int groupId { get; set; }
    }
}
