using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    [Serializable]
    internal class Manager
    {
        public  int EID;
        public  String Name;
        public float Salary;
        static void Main(string[] args)
        {
            Manager mobj = new Manager();
            mobj.EID= 1;
            mobj.Name = "john";
            mobj.Salary = 25000;

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\Sample2.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, mobj);
            stream.Close();

            stream = new FileStream(@"E:\Sample2.txt", FileMode.Open, FileAccess.Read);
            Manager objnew = (Manager)formatter.Deserialize(stream);

            Console.WriteLine(objnew.EID);
            Console.WriteLine(objnew.Name);
            Console.WriteLine(objnew.Salary);


            Console.ReadKey();
        }
    }
}