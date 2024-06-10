using CourseERP.Business.Services.Implementations;
using CourseERP.Business.Services.Interfaces;
using CourseERP.Core.Models;

namespace CourseERP.CA
{
    internal class Program
    {
        public static IStudentService studentService = new StudentService();
        public static IGroupService groupService = new GroupService();
        static void Main(string[] args)
        {
            StartApp();
        }

        private static void StartApp()
        {
            //Console.Clear();
            Console.WriteLine("1. Group Operations: \n 2. Student Operations: \n 3. Add student to group");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GroupOperationMenu();
                    break;
                case "2":
                    StudentOperationMenu();
                    break;

                default:
                    break;

            }
            StartApp();
        }

        private static void StudentOperationMenu()
        {
            Console.WriteLine("1. Create Student \n  2. Get() Student \n   3. GetAll Student \n  4. Remove() Student\n  5. Exit");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateStudentFromUser();
                    break;
                case "2":

                    GetStudentDataById();

                    break;
                case "3":
                    GetAllStudentDataFromUser();
                    break;
                case "4":
                    RemoveStudentByData();

                    break;
                case "0":
                    break;
                default:
                    break;
            }

        }

        private static void RemoveStudentByData()
        {
            Console.WriteLine("Silinecek student id daxil edin: ");
            int.TryParse(Console.ReadLine(), out int studentid);
            studentService.Remove(studentid);

            Console.WriteLine("Student ugurla silindi");
        }

        private static void GetAllStudentDataFromUser()
        {
            var students = studentService.GetAll();
            foreach (var item in students)
            {
                Console.WriteLine(item.Fullname);
            }
        }
    



        private static void GetStudentDataById()
        {

            Console.WriteLine("student id daxil edin: ");
            int.TryParse(Console.ReadLine(), out int studentid);
            var student = studentService.GetStudent(studentid);
            Console.WriteLine(student.Fullname);
        }

        private static void CreateStudentFromUser()
        {
            Console.WriteLine("Student name daxil edin: ");
            string? FullName = Console.ReadLine();
            Student student = new Student();
            student.Fullname = FullName;
            studentService.Create(student);

            Console.WriteLine("Student ugurla elave edildi");

        }

        private static void GroupOperationMenu()
        {
            Console.WriteLine("1. Create Group \n  2. Get() Group \n   3. GetAll Groups \n  4. Remove() Group\n  5. Exit");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGorupDataFromUser();
                    break;
                case "2":

                    GetGroupDataById();
                    break;
                case "3":
                    GetAllGroupDataFromUser();
                    break;
                case "4":
                    RemoveGroupByData();

                    break;
                case "0":
                    break;
                default:
                    break;
            }
        }

        private static void CreateGorupDataFromUser()
        {
            Console.WriteLine("Group name daxil edin: ");
            string? groupName = Console.ReadLine();
            Group group = new Group(groupName);
            groupService.Create(group);

            Console.WriteLine("Group ugurla elave edildi");
        }

        private static void RemoveGroupByData()
        {
            Console.WriteLine("Silinecek group id daxil edin: ");
            int.TryParse(Console.ReadLine(), out int deletedid);
            groupService.Remove(deletedid);
        }

        private static void GetAllGroupDataFromUser()
        {
            var groups = groupService.GetAll();
            foreach (var item in groups)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void GetGroupDataById()
        {
            Console.WriteLine("Group id daxil edin: ");
            int.TryParse(Console.ReadLine(), out int groupid);
            var group = groupService.GetGroup(groupid);
            Console.WriteLine(group.Name);

        }
    }
}
