using ConsoleApp1.src.DesignPatterns.Behavioral.Iterator.GoodExample;

ShoppingList<string> shoppingList = new ShoppingList<string>();
shoppingList.Push("Milk");
shoppingList.Push("Eggs");
shoppingList.Push("Bread"); 

IIterator<string> iterator = shoppingList.CreateIterator();
while (iterator.HasNext())
{    Console.WriteLine(iterator.Current());
    iterator.Next();
}       
