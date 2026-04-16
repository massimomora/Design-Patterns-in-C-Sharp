
using ConsoleApp1.src.DesignPatterns.Behavioral.Command.UndoableCommandPattern;

HtmlDocument doc = new HtmlDocument { Content = "Hello World" };
History history = new History();
ItalicCommand italicCommand = new ItalicCommand(doc, history);
italicCommand.Execute();
Console.WriteLine(doc.Content); // <i>Hello World</i>
UndoCommand undoCommand = new UndoCommand(history);
undoCommand.Execute();
Console.WriteLine(doc.Content); // Hello World









//ITERATOR
// using ConsoleApp1.SOLID.S.BetterExample;
// using ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.GoodExample;

// ShoppingList<User> shoppingList = new ShoppingList<User>();
// shoppingList.Push(new User(Username: "john_doe", Email: "john_doe@example.com"));
// shoppingList.Push(new User(Username: "jane_doe", Email: "jane_doe@example.com"));
// shoppingList.Push(new User(Username: "admin", Email: "admin@example.com"));

// IIterator<User> iterator = shoppingList.CreateIterator();
// while (iterator.HasNext())
// {
//     Console.WriteLine($"User: {iterator.Current().Username}"  + $" Email: {iterator.Current().Email}");
//     iterator.Next();
// }




