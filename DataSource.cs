using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3_Classway
{
    public class DataSource
    {

        public static List<Student> Students;


        public static void CreateData()
        {
            Students = new List<Student>()
            { new Student() { StudentId =1, FirstName="Brian", LastName="Russell", Address="123 Nottrue St."},
             new Student() { StudentId =2, FirstName="Joe", LastName="Joester", Address="124 Nottrue Ave." },
             new Student() { StudentId =1, FirstName="Jane", LastName="Janeison", Address="125 Nottrue Blvd." }
            };



        }
    }
}
