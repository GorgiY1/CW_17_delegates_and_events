//using System;
//using System.Collections.Generic;
//using System.Linq;
//using static System.Console;

//namespace SimpleProject
//{
//    class Student
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public DateTime BirthDate { get; set; }

//        public override string ToString()
//        {
//            return $"{FirstName} {LastName} {BirthDate.Month}";
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Student> group = new List<Student> {
//                new Student {
//                    FirstName = "John",
//                    LastName = "Miller",
//                    BirthDate = new DateTime(2003,3,12)
//                },
//                new Student {
//                    FirstName = "Candice",
//                    LastName = "Leman",
//                    BirthDate = new DateTime(2004,7,22)
//                },
//                new Student {
//                    FirstName = "Joey",
//                    LastName = "Finch",
//                    BirthDate = new DateTime(2002,11,30)
//                },
//                new Student {
//                    FirstName = "Nicole",
//                    LastName = "Taylor",
//                    BirthDate = new DateTime(2002,5,10)
//                }
//            };

//            //=======================================================

//            //Action action = new Action(FullName);
//            //Action<Student> action = new Action(FullName);
//            //Action<Student> action = FullName;
//            //group.ForEach(action);
//            //group.ForEach(FullName);

//            //Func<Student, string> func = new Func<Student, string>(FirstLastName);
//            //group.Select(func);
//            //group.Select(FirstLastName);

//            //=======================================================

//            //IEnumerable<string> vs = group.Select(FirstLastName);

//            //foreach (string item in vs)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            //List<Student> students = group.FindAll(OnlySpring);

//            //foreach (Student item in students)
//            //{
//            //    Console.WriteLine(item);
//            //}

//            group.Sort(SortBirthDate);

//            foreach (Student item in group)
//            {
//                Console.WriteLine(item);
//            }


//            Console.ReadKey();
//        }

//        private static int SortBirthDate(Student x, Student y)
//        {
//            return x.BirthDate.CompareTo(y.BirthDate);
//        }

//        private static bool OnlySpring(Student obj)
//        {
//            return obj.BirthDate.Month > 2 && obj.BirthDate.Month < 6;
//        }

//        private static string FirstLastName(Student arg)
//        {
//            return $"{arg.FirstName} {arg.LastName}";
//        }

//        private static void FullName(Student obj)
//        {
//            Console.WriteLine($"{obj.FirstName} {obj.LastName}"); 
//        }
//    }
//}


//====================================================================================================

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using static System.Console;

//namespace SimpleProject
//{
//    public delegate void ExamDelegate(string t);

//    class Student
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public DateTime BirthDate { get; set; }
//        public void ExamStudent(string task)
//        {
//            WriteLine($"Student: {LastName} task: {task}");
//        }
//    }
//    class Teacher
//    {
//        public event ExamDelegate ExamEvent;


//        public void ExamTeacher(string task)
//        {
//            //if (examEvent != null)
//            //{
//            //    examEvent.Invoke(task);
//            //}
//            ExamEvent?.Invoke(task);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Student> group = new List<Student> {
//                new Student {
//                    FirstName = "John",
//                    LastName = "Miller",
//                    BirthDate = new DateTime(2003,3,12)
//                },
//                new Student {
//                    FirstName = "Candice",
//                    LastName = "Leman",
//                    BirthDate = new DateTime(2004,7,22)
//                },
//                new Student {
//                    FirstName = "Joey",
//                    LastName = "Finch",
//                    BirthDate = new DateTime(2002,11,30)
//                },
//                new Student {
//                    FirstName = "Nicole",
//                    LastName = "Taylor",
//                    BirthDate = new DateTime(2002,5,10)
//                }
//            };
//            Teacher teacher = new Teacher();

//            foreach (Student item in group)
//            {
//                teacher.ExamEvent += item.ExamStudent;
//            }

//            //teacher.ExamEvent.Invoke("%@*!&");

//            teacher.ExamTeacher($"Task: #1");

//            Console.ReadKey();
//        }
//    }
//}

//====================================================================================================

//using System;
//using System.Collections.Generic;
//using static System.Console;

//namespace SimpleProject
//{
//    public delegate void ExamDelegate(string t);

//    class Student
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public DateTime BirthDate { get; set; }

//        public void ExamStudent(string task)
//        {
//            WriteLine($"Студент {LastName} решил {task}");
//        }
//    }

//    class Teacher
//    {
//        private SortedList<int, ExamDelegate> _sortedEvents = new SortedList<int, ExamDelegate>();
//        private Random _rand = new Random();

//        public event ExamDelegate examEvent
//        {
//            add
//            {
//                for (int key; ;)
//                {
//                    key = _rand.Next();
//                    if (!_sortedEvents.ContainsKey(key))
//                    {
//                        _sortedEvents.Add(key, value);
//                        break;
//                    }
//                }
//            }
//            remove
//            {
//                try
//                {
//                    _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
//                }
//                catch { }
//            }
//        }

//        public void ExamTeacher(string task)
//        {
//            foreach (int item in _sortedEvents.Keys)
//            {
//                //if (sortedEvents[item] != null)
//                //{
//                //    sortedEvents[item](task);
//                //}

//                _sortedEvents[item]?.Invoke(task);
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Student> group = new List<Student> {
//                new Student {
//                    FirstName = "John",
//                    LastName = "Miller",
//                    BirthDate = new DateTime(2003,3,12)
//                },
//                new Student {
//                    FirstName = "Candice",
//                    LastName = "Leman",
//                    BirthDate = new DateTime(2004,7,22)
//                },
//                new Student {
//                    FirstName = "Joey",
//                    LastName = "Finch",
//                    BirthDate = new DateTime(2002,11,30)
//                },
//                new Student {
//                    FirstName = "Nicole",
//                    LastName = "Taylor",
//                    BirthDate = new DateTime(2002,5,10)
//                }
//            };

//            Teacher teacher = new Teacher();

//            foreach (Student item in group)
//            {
//                teacher.examEvent += item.ExamStudent;
//            }

//            Student student = new Student
//            {
//                FirstName = "John",
//                LastName = "Doe",
//                BirthDate = new DateTime(2004, 10, 12)
//            };

//            teacher.examEvent += student.ExamStudent;

//            teacher.ExamTeacher("Задача №1");

//            WriteLine();

//            teacher.examEvent -= student.ExamStudent;

//            teacher.ExamTeacher("Задача №2");

//            Student student1 = new Student
//            {
//                FirstName = "Bob",
//                LastName = "Dambler",
//                BirthDate = new DateTime(2003, 4, 1)
//            };
//            teacher.examEvent -= student1.ExamStudent;

//            WriteLine("\n--------------------------------\n");

//            teacher.ExamTeacher("Задача№3");
//        }
//    }
//}

//====================================================================================================

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp_L01
//{
//    delegate void VoidDel();
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            VoidDel del = delegate()
//            {
//                Console.WriteLine("Hello C#))");
//            };

//            del();

//            Console.ReadKey();
//        }
//    }
//}

//====================================================================================================











//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Xml.Serialization;

//namespace ConsoleApp
//{
//    [Serializable]
//    public class Person
//    {
//        [NonSerialized]
//        private const string Planet = "Earth";

//        private int _id;
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Person()
//        {
//            _id = new Random().Next(1000, 10000);
//        }

//        public override string ToString()
//        {
//            return $"{_id} {Name} {Age} {Planet}";
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Person person = new Person { Age = 37, Name = "Geena" };
//            Console.WriteLine(person);
//            /*
//            BinaryFormatter formatter = new BinaryFormatter();

//            try
//            {
//                using (FileStream stream = File.Create("Test.bin"))
//                {
//                    formatter.Serialize(stream, person);
//                }
//                Console.WriteLine("\nSerialize OK!\n");

//                Person p = null;
//                using (FileStream stream = File.OpenRead("Test.bin"))
//                {
//                    p = formatter.Deserialize(stream) as Person;
//                }
//                Console.WriteLine(p);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            */

//            /* Simple Object Access Protocol (SOAP)

//            SoapFormatter formatter = new SoapFormatter();

//            try
//            {
//                using (FileStream stream = File.Create("Test.soap"))
//                {
//                    formatter.Serialize(stream, person);
//                }
//                Console.WriteLine("\nSerialize OK!\n");

//                Person p = null;
//                using (FileStream stream = File.OpenRead("Test.soap"))
//                {
//                    p = formatter.Deserialize(stream) as Person;
//                }
//                Console.WriteLine(p);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            */

//            /* eXtensible Markup Language (XML)

//            XmlSerializer formatter = new XmlSerializer(person.GetType()); // typeof(Person)

//            try
//            {
//                using (FileStream stream = File.Create("Test.xml"))
//                {
//                    formatter.Serialize(stream, person);
//                }
//                Console.WriteLine("\nSerialize OK!\n");

//                Person p = null;
//                using (FileStream stream = File.OpenRead("Test.xml"))
//                {
//                    p = formatter.Deserialize(stream) as Person;
//                }
//                Console.WriteLine(p);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            */

//            List<Person> people = new List<Person>
//            {
//                new Person{ Name = "Jack", Age = 45 },
//                new Person{ Name = "Bob", Age = 18 },
//                new Person{ Name = "Nick", Age = 21 }
//            };

//            XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));

//            try
//            {
//                using (FileStream stream = File.Create("TestList.xml"))
//                {
//                    formatter.Serialize(stream, people);
//                }
//                Console.WriteLine("\nSerialize OK!\n");

//                List<Person> list = null;
//                using (FileStream stream = File.OpenRead("TestList.xml"))
//                {
//                    list = formatter.Deserialize(stream) as List<Person>;
//                }
//                foreach (Person p in list)
//                {
//                    Console.WriteLine(p);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            Console.ReadKey();
//        }
//    }
//}

//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Runtime.Serialization;
//using System.Runtime.Serialization.Json;

//namespace ConsoleApp
//{
//    [DataContract]
//    class Person
//    {
//        private const string Planet = "Earth";

//        [DataMember]
//        private int _id;

//        [DataMember]
//        public string Name { get; set; }

//        [DataMember]
//        public int Age { get; set; }

//        public Person()
//        {
//            _id = new Random().Next(1000, 10000);
//        }

//        public override string ToString()
//        {
//            return $"{_id} {Name} {Age} {Planet}";
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            Person person = new Person { Age = 37, Name = "Geena" };
//            Console.WriteLine(person);

//            /* JavaScript Object Notation (JSON)

//            DataContractJsonSerializer formatter = new DataContractJsonSerializer(person.GetType());

//            try
//            {
//                using (FileStream stream = File.Create("Test.json"))
//                {
//                    formatter.WriteObject(stream, person);
//                }
//                Console.WriteLine("\nSerialize OK!\n");

//                Person p = null;
//                using (FileStream stream = File.OpenRead("Test.json"))
//                {
//                    p = formatter.ReadObject(stream) as Person;
//                }
//                Console.WriteLine(p);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            */

//            List<Person> people = new List<Person>
//            {
//                new Person{ Name = "Jack", Age = 45 },
//                new Person{ Name = "Bob", Age = 18 },
//                new Person{ Name = "Nick", Age = 21 }
//            };

//            DataContractJsonSerializer formatter = new DataContractJsonSerializer(people.GetType());

//            try
//            {
//                using (FileStream stream = File.Create("Test1.json"))
//                {
//                    formatter.WriteObject(stream, people);
//                }
//                Console.WriteLine("\nSerialize OK!\n");

//                List<Person> list = null;
//                using (FileStream stream = File.OpenRead("Test1.json"))
//                {
//                    list = formatter.ReadObject(stream) as List<Person>;
//                }
//                foreach (Person p in list)
//                {
//                    Console.WriteLine(p);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//            Console.ReadKey();
//        }
//    }
//}