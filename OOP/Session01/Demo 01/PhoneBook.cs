namespace Demo_01
{
    internal class PhoneBook
    {
        string[] names;
        long[] numbers;

        public PhoneBook(int size)
        {
            this.names = new string[size];
            this.numbers = new long[size];
        }

        #region Natural Methods
        public void AddPerson(string name, long number, int idx)
        {
            names[idx] = name;
            numbers[idx] = number;
        }

        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    return numbers[i];
                }
            }
            return -1;
        }

        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    numbers[i] = newNumber;
                    break;
                }
            }
        }
        public string GetName(long number)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return names[i];
                }
            }
            return "";
        }

        public void UpdateName(long number, string newName)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (numbers[i] == number)
                {
                    names[i] = newName;
                    break;
                }
            }
        }

        #endregion

        #region Indexer
        // Indxer

        public long this[string name]
        {
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        break;
                    }
                }
            }

            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
                return -1;
            }
        }


        public string this[long number]
        {
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        names[i] = value;
                        break;
                    }
                }
            }
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return names[i];
                    }
                }
                return "";
            }
        }
        #endregion



        //value type
        // stack
        // declare for object from type
        // no inhirit
        // can implement user-dif const without default construct exist 
        // Any constructor inside the calss not affect on defualt constructoe

        // response about initialize attri  -by cocstructor - is compiler

    }
}
