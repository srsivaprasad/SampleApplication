// See https://aka.ms/new-console-template for more information
using IRISTest;

#region Task1
int[] a = { 1, 5, 10, 20, 30 };
int[] b = { 30, 5, 13, 15, 20 };

var result = Task1.FindCommonElements(a, b);
foreach (int i in result)
{
    Console.WriteLine(i);
}
#endregion

#region Task2
string[] testExpressions =
{
            "(a + b) * [c / {d - e}]",
            "{[a + (b * c) / d] - e}",
            "((a + b))",
            "{[a + b] * (c / d}",
            "(a + b] * [c / d"
        };
foreach (string expression in testExpressions)
{
    bool result2 = Task2.AreParenthesesBalanced(expression);
    Console.WriteLine($"Expression: {expression} is balanced: {result2}");
}
#endregion

#region Task3
List<Contact> dummyContacts = new List<Contact>
        {
            new Contact { id = 1, Data = "John Doe, johndoe@example.com", CreatedDate = new DateTime(2024, 1, 15) },
            new Contact { id = 2, Data = "Jane Smith, janesmith@example.com", CreatedDate = new DateTime(2024, 2, 20) },
            new Contact { id = 3, Data = "Emily Johnson, emilyjohnson@example.com", CreatedDate = new DateTime(2024, 3, 5) },
            new Contact { id = 4, Data = "Michael Brown, michaelbrown@example.com", CreatedDate = new DateTime(2024, 4, 10) },
            new Contact { id = 5, Data = "Sarah Davis, sarahdavis@example.com", CreatedDate = new DateTime(2024, 5, 25) }
        };

Task3.SerializeContactsToJson(dummyContacts, "d:\\testfile.txt"); 
#endregion

#region Task4
Task4.GetSoftwareProducts("url"); 
#endregion

Console.ReadLine();

 