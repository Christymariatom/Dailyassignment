namespace Razordemo.Models
{
    public class Person
    {
        string name;
        int age;

        public string Name { get; set; }
        public int Age { get; set; } 
        public Person() { }
        public Person(string name,int age) 
        {
            Name = name;
            Age = age;
        }
      
            
    }
}
