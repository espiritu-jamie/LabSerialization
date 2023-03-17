using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSerialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Event firstEvent = new Event()
            {
                EventNumber = 1,
                Location = "Calgary"
            };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("event.txt", FileMode.Create))
            {
                formatter.Serialize(fs, firstEvent);
                fs.Close();
            }


            //BinaryFormatter formatter = new BinaryFormatter();

            //using (FileStream fs = new FileStream("event.txt", FileMode.Open))
            //{
            //    Event firstEvent = (Event)formatter.Deserialize(fs);
            //    Console.WriteLine(firstEvent.EventNumber);
            //    Console.WriteLine(firstEvent.Location);
            //    fs.Close();
            //}

            //ReadFromFile();
        }

        //static void ReadFromFile()
        //{
        //    using (FileStream fileStream = new FileStream("event.txt", FileMode.Open))
        //    {
        //        StreamWriter writer = new StreamWriter(fileStream);
        //        writer.WriteLine("Hackathon");
        //        writer.Flush();

        //        StreamReader reader = new StreamReader(fileStream);
        //        string line = reader.ReadLine();

        //        Console.WriteLine("In Word: " + line);

        //        fileStream.Seek(0, SeekOrigin.Begin);
        //        Console.WriteLine("The First Character is: " + Convert.ToChar(fileStream.ReadByte()));

        //        fileStream.Seek((line.Length / 2), SeekOrigin.Begin);
        //        Console.WriteLine("The Middle Character is: " + Convert.ToChar(fileStream.ReadByte()));

        //        fileStream.Seek(line.Length - 1, SeekOrigin.Begin);
        //        Console.WriteLine("The Last Character is: " + Convert.ToChar(fileStream.ReadByte()));

        //        fileStream.Close();
        //    }
        //}
    }
}
