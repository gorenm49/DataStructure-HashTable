using System;

namespace DataStructureHashTable
{
    public class Program
    {
       public static void Main(string[] args)
       {
            
            MyMapNode<string, string> hashTable = new MyMapNode<string,string>(18);
            
            hashTable.Add("f0", "“Paranoids");
            hashTable.Add("f1", "are");
            hashTable.Add("f2", "but");
            hashTable.Add("f3", "paranoid");
            hashTable.Add("f4", "because");
            hashTable.Add("f5", "they");
            hashTable.Add("f6", "are");
            hashTable.Add("f7", "paranoid");
            hashTable.Add("f8", "but");
            hashTable.Add("f9", "because");
            hashTable.Add("f10", "they");
            hashTable.Add("f11", "keep");
            hashTable.Add("f12", "putting");
            hashTable.Add("f13", "themselves");
            hashTable.Add("f14", "deliberately");
            hashTable.Add("f15", "into");
            hashTable.Add("f16", "paranoid");
            hashTable.Add("f17", "avoidable");
            hashTable.Add("f18", "situations”");
            
            string strHold = hashTable.GetElement("f8");
            System.Console.WriteLine("8th index word in the paragraph is  :"+strHold);
       }

    }
}