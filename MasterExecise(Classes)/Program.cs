using MasterExecise_Classes_;

List<string> _list = new List<string>();
_list.Add("Abdul");
_list.Add("Micheal");
foreach (var name in _list)
{
  System.Console.WriteLine(name);
}
Person getData = new Person(name: "John", age: 30);
getData.Greet();

