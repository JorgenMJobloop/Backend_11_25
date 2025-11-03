namespace Week1;

class Program
{
    static void Main(string[] args)
    {
        // We can initalize our object from a class, with this syntax
        Person person = new Person();
        DataTypeExamples examples = new DataTypeExamples();

        string name = "John Doe";
        int age = 32;

        person.Name = name;
        person.Age = age;

        Console.WriteLine($"The persons name is {person.Name} and they are {person.Age} years old.");

        // fill in values in our example object
        string text = "Hello World!";
        examples.StringValue = text;
        char a = 'a';
        char b = '$';
        examples.CharacterValue = a;
        Console.WriteLine(examples.CharacterValue + b);
        Console.WriteLine(examples.BooleanValue);
    }
}