using System;
using System.Linq;

namespace TaxClassificationCodeCHS.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxCode = "304060399";
            var code = TaxClassificationCodeHelper.GetCode(taxCode);
            if (code != null)
            {
                Console.WriteLine("名称：{0}  简称：{1} 完整编码：{2}", code.Name, code.AbbrName, code.Code);
            }
            else
            {
                Console.WriteLine("未能找到对应编码");
            }
            Console.WriteLine("子分类数量：{0}",TaxClassificationCodeHelper.GetChildren(taxCode).Count());
            var directChildren = TaxClassificationCodeHelper.GetDirectChildren(taxCode).ToList();
            Console.WriteLine("直系分类数量：{0}", directChildren.Count());
            Console.ReadLine();
        }
    }
}
