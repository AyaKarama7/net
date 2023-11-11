using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct phoneBook
    {
        //attributes
        string[] Names;
        long[] Numbers;
        int size;
        //proberty
        public int Size { get { return size; } }
        //constructor
        public phoneBook(int _size)
        {
            size = _size;
            Names = new string[size];
            Numbers = new long[size];
        }
        //functions
        public void SetEntry(int index,string Name,long Number)
        {
            if(index>=0&&index<=size)
            {
                Names[index] = Name;
                Numbers[index] = Number;
            }
        }
        public long GetNumber(string Name)
        {
            for(int i=0;i<size;i++)
            {
                if (Names[i] == Name) return Numbers[i];
            }
            return -1;
        }
        //indexer
        public long this[string Name]
        {
            get 
            {
                for (int i = 0; i < Names?.Length; i++)
                    if (Names[i] == Name) return Numbers[i];
                return -1;
            }
            set 
            {
                for (int i = 0; i < Names?.Length; i++)
                    if (Names[i] == Name) Numbers[i] = value;
            }
        }
        //overload
        public string this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < size) return ($"{Names[idx]}::{Numbers[idx]}");
                return "NA";
            }
        }
        public long this[int idx,string Name]
        {
            set
            {
                if(idx>=0&&idx<=size)
                {
                    Names[idx] = Name;
                    Numbers[idx] = value;
                }
            }
        }
    }
}
