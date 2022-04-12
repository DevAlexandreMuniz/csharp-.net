//guids
var id = Guid.NewGuid();
id.ToString();

id = new Guid("ce76155a-7d90-47b7-989b-c39f9b80693c");
Console.WriteLine(id.ToString().Substring(0,8));
//