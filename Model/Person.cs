

namespace HashTable.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}; Age: {Age}; Gender: {Gender}.";
        }
        public override int GetHashCode()
        {
            return Name.Length + Age + Gender + (int)Name[0];
        }
        public override bool Equals(object obj)
        {
            return (obj as Person).Name == Name && (obj as Person).Age == Age && (obj as Person).Gender == Gender;
        }
    }
}
