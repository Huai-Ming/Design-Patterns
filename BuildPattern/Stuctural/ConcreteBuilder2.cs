using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern.Stuctural
{
    /// <summary>
    /// 实现Builder的接口以构造和装配该产品的各个部件

　　/// 定义并明确它所创建的表示

　　/// 提供一个检索Product的接口
    /// </summary>
    public class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Build Part X");
        }

        public override void BuildPartB()
        {
            product.Add("Build Part Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
