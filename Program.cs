// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ");
Console.WriteLine("Hello, World!");
Console.WriteLine(" ");

// Create an array with the integers 0 through 9 inside.
int[] numArray = {0,1,2,3,4,5,6,7,8,9};

Console.WriteLine("This is the numArray with ints 0 through 9");
foreach (int num in numArray)
{
    Console.WriteLine(num);
}
Console.WriteLine(" ");

// Create an array with the names "Tim", "Martin", "Nikki", and "Sara".
string[] namesArray = new string[] { "Tim", "Martin", "Nikki", "Sara"};

Console.WriteLine("This is the namesArray");
foreach (string name in namesArray)
{
    Console.WriteLine(name);
}
Console.WriteLine(" ");

// Create an array of length 10. Then fill it with alternating
//  true/false values, starting with true.
//  (Tip: do this using logic! Do not hard-code the values in!)
bool[] boolArray = new bool[10];

for (int idx = 0; idx < boolArray.Length; idx++)
{
    if (idx % 2 == 0) {
        boolArray[idx] = true;
    } else {
        boolArray[idx] = false;
    }
}

Console.WriteLine("This is the boolArray with alternating true/false");
foreach (bool val in boolArray)
{
    Console.WriteLine(val);
}
Console.WriteLine(" ");

// Create a List of ice cream flavors that holds at least 5 different flavors.
//  (Feel free to add more than 5!)
List<string> iceCream = new List<string>();

iceCream.Add("Vanilla Bean");
iceCream.Add("Cookies & Cream");
iceCream.Add("Chocolate Peanut Butter Cup");
iceCream.Add("Mint Chocolate Chip");
iceCream.Add("Peanut Butter Waffle Cone");
iceCream.Add("Strawberry Cheesecake");

// Output the length of the List after you added the flavors.
Console.WriteLine("How many ice cream flavors did I add?: " + iceCream.Count);
Console.WriteLine(" ");

// Output the third flavor in the List.
Console.WriteLine("Let's check to see what the third flavor in my list is: " + iceCream[2]);
Console.WriteLine(" ");

// Now remove the third flavor using its index location.
Console.WriteLine("Let's remove that flavor.");
iceCream.RemoveAt(2);
Console.WriteLine(" ");

// Output the length of the List again. It should now be one fewer.
Console.WriteLine("How many ice cream flavors do I have left?: " + iceCream.Count);
Console.WriteLine(" ");

// Create a dictionary that will store string keys and string values.
Dictionary<string,string> nameAndFlavor = new Dictionary<string,string>();

// Add key/value pairs to the dictionary where:
//  Each key is a name from your names array.
//  Each value is a randomly selected flavor from your flavors List
int i = 0;
Random rand = new Random();

while(i < namesArray.Length)
{
    nameAndFlavor.Add(namesArray[i],iceCream[rand.Next(0,iceCream.Count-1)]);
    i++;
}

// Loop through the dictionary and print out each user's name
//  and their associated ice cream flavor.
foreach(KeyValuePair<string,string> entry in nameAndFlavor)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}