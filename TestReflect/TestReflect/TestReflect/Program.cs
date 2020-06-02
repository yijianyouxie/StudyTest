using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestReflect
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Student stu1 = new Student() { Name = "张三" };
            Student stu2 = new Student() { Name = "李四" };
            user.student = new List<Student>();
            user.student.Add(stu1);
            user.student.Add(stu2);
            user.Username = "admin";
            user.Password = "123456";

            User user1 = new User();
            Student stu3 = new Student() { Name = "二蛋" };
            Student stu4 = new Student() { Name = "王二麻子" };
            user1.student = new List<Student>();
            user1.student.Add(stu3);
            user1.student.Add(stu4);
            user1.Username = "root";
            user1.Password = "123";

            IList<User> userList = new List<User>();
            userList.Add(user);
            userList.Add(user1);
            //调用方法
            //PrintPropertyValue(userList);

            TestA ra = new TestA();
            ra.proA = 30;
            PrintPro(ra);

            Console.ReadKey();
        }
        private static void PrintPro(object ra)
        {
            //获取所有属性名称和属性类型         
            PropertyInfo[] infos = typeof(TestA).GetProperties();
            foreach (PropertyInfo item in infos)
            {
                Console.WriteLine(string.Format("PropertyName:{0},type:{1}", item.Name, item.PropertyType.Name));
            }
            Type type = typeof(TestA);
            PropertyInfo pi = type.GetProperty("proA");
            object o = pi.GetValue(ra, null);
            Console.WriteLine("====name:" + o.ToString());
            System.Reflection.PropertyInfo[] ps = type.GetProperties();
            foreach (PropertyInfo i in ps)
            {
                if (i.PropertyType == typeof(string) || i.PropertyType == typeof(float) || i.PropertyType == typeof(int))
                {
                    object obj = i.GetValue(ra, null);
                    string name = i.Name;
                    Console.WriteLine("====name:" + name + "value:" + (int)obj);
                }

            }
        }

        //private static void PrintPropertyValue<T>(IList<T> list)
        private static void PrintPropertyValue<T>(IList<T> list)
        {

            //获取所有属性名称和属性类型         
            PropertyInfo[] infos = typeof(T).GetProperties();
            foreach (PropertyInfo item in infos)
            {
                Console.WriteLine(string.Format("PropertyName:{0},type:{1}", item.Name, item.PropertyType.Name));
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].GetType().GetProperty("Username").GetValue(list[i], null));
                Console.WriteLine(list[i].GetType().GetProperty("Password").GetValue(list[i], null));
                object obj = list[i].GetType().GetProperty("student").GetValue(list[i], null);
                IList ll = obj as IList;

                foreach (var item in ll)
                {
                    Console.WriteLine(string.Format("Name:{0},Age:{1}", item.GetType().GetProperty("Name").GetValue(item, null), item.GetType().GetProperty("Age").GetValue(item, null)));
                }
            }
        }
    }
    public class TestA
    {
        public int proA { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public IList<Student> student
        {
            get;
            set;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
}
