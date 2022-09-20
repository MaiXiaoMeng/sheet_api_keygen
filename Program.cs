using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace sheet_api_keygen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Class111 @class = new Class111();
            var machine_code = @class.method_2("KhenLaw");
            Console.WriteLine("请输入 Sheet API 的机器码，本机的机器码为：" + machine_code);            
            machine_code = Console.ReadLine();
            var activation_code = Conversions.ToString(Class152.smethod_5(machine_code+ ";VIP;2022-08-01"));
            Console.WriteLine("机器码: " + machine_code);
            Console.WriteLine("激活码: " + activation_code);
            Console.ReadLine();
        }
    }
}