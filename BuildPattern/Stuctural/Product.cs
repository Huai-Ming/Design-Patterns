using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuildPattern.Stuctural
{
    /// <summary>
    /// 表示被构造的复杂对象。ConcreteBuilder创建该产品的内部表示并定义它的装配过程

　　/// 包含定义组成部件的类，包括将这些部件装配成最终产品的接口
    /// </summary>
    public class Product
    {
        private List<string> paras = new List<string>();

        public void Add(string part)
        {
            paras.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Products Parts");
            foreach(var part in paras)
            {
                Console.WriteLine(part);
            }
        }
    }
}
