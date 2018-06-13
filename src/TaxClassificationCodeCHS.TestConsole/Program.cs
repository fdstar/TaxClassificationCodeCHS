using System;
using System.Linq;

namespace TaxClassificationCodeCHS.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxCode = "102";
            var code = TaxClassificationCodeHelper.GetCode(taxCode);
            if (code != null)
            {
                Console.WriteLine("名称：{0}  简称：{1} 完整编码：{2}", code.Name, code.AbbrName, code.Code);
            }
            else
            {
                Console.WriteLine("未能找到对应编码");
            }
            Console.WriteLine(TaxClassificationCodeHelper.GetChildren(taxCode).Count());
            Console.ReadLine();
        }
    }
}
