using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    struct PhoneBook  
    {
        long[] Numbers;
        string[] Names;
        private int size;

        public int Size
        {
            get { return size; }
            private set { size = value > 0 ? value : 10; }
        }

        public PhoneBook(int _size)
        { 
            Size = _size;
            Numbers = new long[Size];
            Names = new string[Size];
        }

        /// constructor chaning
        public PhoneBook() : this(0)
        {
            //Size = 0;
            //Numbers = new long[Size];
            //Names = new string[Size];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Size; i++)
            {
                sb.Append($"[{Names[i]} , {Numbers[i]}]\n");
            }
            return sb.ToString();
        }

        public void AddNumber(string _name, long _number, int _position)
        {
            if (_position >= 0 && _position < Size)
            {
                Names[_position] = _name;
                Numbers[_position] = _number;
            }
            else
            {
                Console.WriteLine("the position is out of range");
            }
        }

        ///write object memeber method GetNumber take name and return number
        public long GetNumber(string _name)
        {
            int index = Array.IndexOf(Names, _name);
            if(index >= 0)
                return Numbers[index];
            return -1;
        }
        ///write object memeber method SetNumber take name and number then update number of that name
        public void SetNumber(string _name, long _number)
        {
            int index = Array.IndexOf(Names, _name);
            if (index >= 0)
                Numbers[index] = _number;
        }

        // Indexer : Special Property
        public string this[int index]
        {
            get { return $"{index} :: {Names[index]} :: {Numbers[index]}"; }
        }

        public long this[string _name]
        {
            get
            {
                int index = Array.IndexOf(Names, _name);
                if (index >= 0)
                    return Numbers[index];
                return -1;
            }
            set
            {
                int index = Array.IndexOf(Names, _name);
                if (index >= 0)
                    Numbers[index] = value;
            }
        }

    }
}
