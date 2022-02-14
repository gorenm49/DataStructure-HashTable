using System;

namespace DataStructureHashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            MyMapNode<string, string> hashTable = new MyMapNode<string,string>(5);
            
            hashTable.Add("0", "To");
            hashTable.Add("1", "be");
            hashTable.Add("2", "or");
            hashTable.Add("3", "not");
            hashTable.Add("4", "to");
            hashTable.Add("5", "be");

            string strHold = hashTable.GetElement("4");
            System.Console.WriteLine("4th index value is : "+strHold);
        }

    }
}