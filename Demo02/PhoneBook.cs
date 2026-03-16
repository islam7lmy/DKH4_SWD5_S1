using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP
{

    //List 
    struct PhoneBook
    {
        long[] Numbers;
        string[] Names;
        int count; // count of curent elements
        public int Count { get { return count; } }

        private int size; // capacity
        public int Size
        {
            get { return size; }
            private set{ Resize(value); }
        }

        public PhoneBook(int _size)
        {
            Size = _size;
            count = 0;
            //Numbers = new long[Size];
            //Names = new string[Size];
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
            for (int i = 0; i < count; i++)
            {
                sb.Append($"[{Names[i]} , {Numbers[i]}]\n");
            }
            return sb.ToString();
        }

        public void AddNumber(string _name, long _number)
        {
            //Names[count - 1] last elment has data 

            //int _position = Array.IndexOf(Names, null); => count
            if (count == Size)
                Resize(size + 1); //list 

            Names[count] = _name;
            Numbers[count] = _number;
            count++;
        }

        /// method to remove contact

        ///write object memeber method GetNumber take name and return number
        public long GetNumber(string _name)
        {
            int index = Array.IndexOf(Names, _name);
            if (index >= 0)
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

        public string this[int index]
        {
            get
            {
                try
                {
                    return $"the {index + 1} elmenet of phone book is : [{Names[index]} => {Numbers[index]}]";
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void Resize(int value)
        {
            if (size == 0)
            {
                size = value > 0 ? value : 10;
                Numbers = new long[size];
                Names = new string[size];
            }
            else if (value > size)
            {
                long[] newnumbers = new long[value];
                string[] newnames = new string[value];

                Numbers?.CopyTo(newnumbers, 0);
                Names?.CopyTo(newnames, 0);

                Numbers = newnumbers;
                Names = newnames;

                size = value > 0 ? value : 10;
            }
            else if (value < size)   //value == size || value < size
            {
                //int maxindexhasdata = Array.IndexOf(Names, null); // -1 if all elements has data
                if (value >= count)  // 3
                {
                    long[] newnumbers = new long[value];
                    string[] newnames = new string[value];

                    for (int i = 0; i < value; i++) // 3
                    {
                        newnumbers[i] = Numbers[i];
                        newnames[i] = Names[i];
                    }
                    Numbers = newnumbers;
                    Names = newnames;

                    size = value > 0 ? value : 10;
                }
                else
                {
                    Console.WriteLine("can not modify size");
                }
            }
        }
    }
}
