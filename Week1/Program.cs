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

        // Collections and data structure examples
        // in this case, the variable holds a collection of string values, rather than a single value.
        string[] elementsInArray = ["Milk", "Honey", "Coffee", "Soda", "Chicken", "Steak"]; // we have added values to our array, and can now loop through it
        examples.ShoppingListAsArray = elementsInArray;

        for (int i = 0; i < examples.ShoppingListAsArray.Length; i++)
        {
            Console.WriteLine($"Element at index: {i} in our array: {examples.ShoppingListAsArray[i]}\nValue of our iterator(i): {i}");
        }

        List<string> shoppingListItems = examples.ShoppingListAsArray.ToList(); // we copy our array to the list, and can then add more values to it.
        examples.ShoppingListAsList = shoppingListItems;
        examples.ShoppingListAsList.Add("Pulled pork"); // List<string> element[-1] --> last index in our collection [0..7] where 7 is the last entry
        Console.WriteLine(examples.ShoppingListAsList.LastIndexOf("")); // should be 7
        examples.ShoppingListAsList.Add("Candy");
        examples.ShoppingListAsList.Add("Lemonade");

        foreach (var element in examples.ShoppingListAsList)
        {
            Console.WriteLine(element);
        }
    }
}