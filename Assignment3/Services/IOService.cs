using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3.Utility;
using System.Xml.Linq;

namespace Assignment3.Services
{
    internal class IOService
    {
        private static string relativePath = @"C:\cprg211\SLL_&_Serialization\Assignment3Skeleton\Assignment3\Resources\users.bin";
        private static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);


        public static void SaveToFile(SLL sll)
        {
            if (sll == null || string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("Single linked list or file path is null.");
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                Node n = sll.Head;

                while (n != null)
                {
                    User usr = n.Data;
                    writer.Write(usr.Id);
                    writer.Write(usr.Name);
                    writer.Write(usr.Email);
                    writer.Write(usr.Password);

                    n = n.Next;
                }
            }
        }


        public static SLL LoadFile()
        {
            SLL sll = new SLL();

            if (!File.Exists(filePath))
            {
                return sll;
            }
            else
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        User usr = Deserialize(reader);
                        sll.AddLast(usr);
                    }
                }
            }

            return sll; 
        }

        public static User Deserialize(BinaryReader reader)
        {
            int id = reader.ReadInt32();
            string name = reader.ReadString();
            string email = reader.ReadString();
            string password = reader.ReadString();

            return new User(id, name, email, password);         
        }

    }
}
