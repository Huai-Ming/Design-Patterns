using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern.Structure
{

    [Serializable]
    class ConcretePrototypeB : Prototype
    {
        public MemberB Member { set; get; }

        public override Prototype Clone()
        {
            ConcretePrototypeB clone = null;
            FileStream fs = new FileStream("Temp.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);  //序列化  
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            FileStream fs1 = new FileStream("Temp.dat", FileMode.Open);
            BinaryFormatter formatter1 = new BinaryFormatter();
            try
            {
                clone = (ConcretePrototypeB)formatter1.Deserialize(fs1);  //反序列化  
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs1.Close();
            }
            return clone;
        }

    }

    [Serializable]
    class MemberB
    {
        public MemberB(string value)
        {
            this.Value = value;
        }
        public string Value { get; set; }

    }
}
