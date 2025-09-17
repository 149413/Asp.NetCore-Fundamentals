namespace Assiagn01.Models
{
    internal struct Person
    {
        private string name;
        private int age;


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
