using System.Collections.Generic;

namespace CourseApp.Models
{
    public static class Repository
    {

        private static List<Student> Students = new List<Student>();

        //Repository.Students
        public static List<Student> students {
            get{
                return Students;
            }
        }

        public static void AddStudent(Student student){
            Students.Add(student);
        }
    }
}