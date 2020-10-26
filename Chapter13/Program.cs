using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] persons = new Person[3];
            var persons = new List<Person>();

            persons.Add( new Employee
            {
                Number = 352,                   //従業員クラス（子クラス）のメンバ
                FirstName = "涼太",             //親クラスのメンバ
                LastName = "田中",              //親クラスのメンバ
                Email = "rtanaka@example.com",  //親クラスのメンバ
                HireDate = new DateTime(2015, 10, 1),
                Birthday = new DateTime(2000, 10, 1)
            });

            persons.Add(new Customer
            {
                Id = "2001",                    //従業員クラス（子クラス）のメンバ
                FirstName = "太郎",             //親クラスのメンバ
                LastName = "池田",              //親クラスのメンバ
                CreditCardNumber = "15245845245", //従業員クラス（子クラス）のメンバ
                Birthday = new DateTime(2000, 10, 1),
                Rank = 3                        //従業員クラス（子クラス）のメンバ
            });

            persons.Add(new Customer
            {
                Id = "2002",                    //従業員クラス（子クラス）のメンバ
                FirstName = "次郎",             //親クラスのメンバ
                LastName = "高田",              //親クラスのメンバ
                CreditCardNumber = "15241215245", //従業員クラス（子クラス）のメンバ
                Birthday = new DateTime(2000, 10, 1),
                Rank = 3                        //従業員クラス（子クラス）のメンバ
            });

            foreach (var person in persons)
            {
                //person.Print();
                Console.WriteLine(person.ToString());
            }
        }
    }
}
