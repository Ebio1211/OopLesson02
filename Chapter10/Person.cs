using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    class Person
    {
        public string FirstName { get; set; } = "綿内"; //プロパティの初期化可
        public string LastName { get; set; } = "鰈";


        public string FullName
        {
            get { return LastName + FirstName; }
        }

        //public string GetFullName()
        //{
        //    return LastName + FirstName;
        //}


        public string AddTitle(string title = "様")
        {
            return $"{ LastName}{FirstName }{title}";
        }
    }
}
