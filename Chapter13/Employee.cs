using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    //従業員クラス(Personクラスを継承)
    class Employee : Person
    {
        //従業員番号
        public int Number { get; set; }
        //入社年月日
        public DateTime HireDate { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{Number}：{FullName}({Email})誕生日：{Birthday} {HireDate.Year}年入社");
        }

        public override string ToString()
        {
            return $"{Number}：{FullName}({Email})誕生日：{Birthday} {HireDate.Year}年入社";
        }
    }
}
