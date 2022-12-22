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

            Console.WriteLine("请输入 Sheet API 的机器码:");
            var machine_code = Console.ReadLine();
            var activation_code = Conversions.ToString(Class31.smethod_5(machine_code + ";VIP;2999-1-1"));
            Console.WriteLine("机器码: " + machine_code);
            Console.WriteLine("激活码: " + activation_code);
            Console.ReadLine();
        }
    }
}