using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CustomQuiz.Methods
{
    public class BinaryFileIO
    {
        public static void WriteToBinaryFile<ObjectType>(String pathVar, ObjectType objectVar)
        {
            try
            {
                using (Stream streamVar = File.Open(pathVar, FileMode.Create))
                {
                    BinaryFormatter binaryFormatterVar = new BinaryFormatter();
                    binaryFormatterVar.Serialize(streamVar, objectVar);
                    streamVar.Close();
                }
                return;
            }
            catch
            {
                return;
            }
        }
        public static ObjectType ReadFromBinaryFile<ObjectType>(String pathVar)
        {
            try
            {
                using (Stream streamVar = File.Open(pathVar, FileMode.Open))
                {
                    BinaryFormatter binaryFormatterVar = new BinaryFormatter();
                    return (ObjectType)binaryFormatterVar.Deserialize(streamVar);
                }
            }
            catch
            {
                return default;
            }
        }
    }
}
