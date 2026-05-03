class Student
{
    public string Name;
    public int Age;

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Name = "Alice";
        s1.Age = 20; 
        Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");
        s1.Study();           
    }
}