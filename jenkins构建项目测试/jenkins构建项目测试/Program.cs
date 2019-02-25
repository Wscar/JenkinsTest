using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Jenkins构建项目测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            JsonConvert.SerializeObject("哈哈哈哈");
            Console.ReadKey();
        }
    }
}
