//------------------------guids------------------------

var id = Guid.NewGuid();
id.ToString();
id = new Guid("ce76155a-7d90-47b7-989b-c39f9b80693c");
//Console.WriteLine(id.ToString().Substring(0,8));

//---------------interpolação de strings---------------

var price = 10.50;
//var texto = string.Format("O preço do produto é {0} apenas na promoção", price);
var texto = $@"O preço do produto é {price} apenas na promoção";
//Console.WriteLine(texto);

//-----------------Comparação de strings-----------------

