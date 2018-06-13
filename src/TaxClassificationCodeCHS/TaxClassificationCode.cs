using System;
using System.Text.RegularExpressions;

namespace TaxClassificationCodeCHS
{
    /// <summary>
    /// 税收分类编码
    /// </summary>
    public class TaxClassificationCode
    {
        /// <summary>
        /// octr
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="abbrName"></param>
        public TaxClassificationCode(string code, string name, string abbrName)
        {
            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(abbrName))
            {
                throw new ArgumentNullException();
            }
            if (!Regex.IsMatch(code, @"^\d{1,19}$"))
            {
                throw new ArgumentException("code is error");
            }
            this.Code = code.PadRight(19, '0');
            this.Name = name;
            this.AbbrName = abbrName;
        }
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; private set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 简称
        /// </summary>
        public string AbbrName { get; private set; }
        /// <summary>
        /// 获取编码数据构成，按顺序 篇	类	章	节	条	款	项	目	子目	细目
        /// </summary>
        /// <returns></returns>
        public string[] GetStruct()
        {
            var tmp = new string[10];
            tmp[0] = new string(new char[] { this.Code[0] });
            for (var i = 0; i < 9; i++)
            {
                tmp[i + 1] = new string(new char[] { this.Code[i * 2 + 1], this.Code[i * 2 + 2] });
            }
            return tmp;
        }
    }
}
