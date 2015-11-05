using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildPattern.Stuctural
{
    /// <summary>
    /// 为创建一个Product对象的各个部件指定抽象接口
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();

        public abstract Product GetResult();
    }
}
