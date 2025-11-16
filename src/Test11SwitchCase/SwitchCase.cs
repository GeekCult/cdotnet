string fruit = "banana";

switch (fruit)
{
  case "apple":
    Console.WriteLine($"App will display information for apple.");
    break;

  case "banana":
    Console.WriteLine($"App will display information for banana.");
    break;

  case "cherry":
    Console.WriteLine($"App will display information for cherry.");
    break;
}


int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

title = employeeLevel switch
{
  100 => "Junior Associate",
  200 => "Senior Associate",
  300 => "Manager",
  400 => "Senior Manager",
  _ => "Associate",
};

Console.WriteLine($"{employeeName}, {title}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
  type = "Sweat shirt";
}
else if (product[0] == "02")
{
  type = "T-Shirt";
}
else if (product[0] == "03")
{
  type = "Sweat pants";
}
else
{
  type = "Other";
}

if (product[1] == "BL")
{
  color = "Black";
}
else if (product[1] == "MN")
{
  color = "Maroon";
}
else
{
  color = "White";
}

if (product[2] == "S")
{
  size = "Small";
}
else if (product[2] == "M")
{
  size = "Medium";
}
else if (product[2] == "L")
{
  size = "Large";
}
else
{
  size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");


string sku2 = "01-MN-L";

string[] product2 = sku2.Split('-');
string productType = "";
string productColor = "";
string productSize = "";

for (int i = 0; i < product2.Length; i++)
{
  string item = product2[i];
  switch (i)
  {
    case 0:
      switch (item)
      {
        case "01":
          productType = "Sweat shirt";
          break;
        case "02":
          productType = "T-Shirt";
          break;
        case "03":
          productType = "Sweat pants";
          break;
        default:
          productType = "Other";
          break;
      }
      break;
    case 1:
      switch (item)
      {
        case "BL":
          productColor = "Black";
          break;
        case "MN":
          productColor = "Maroon";
          break;
        default:
          productColor = "White";
          break;
      }
      break;
    case 2:
      switch (item)
      {
        case "S":
          productSize = "Small";
          break;
        case "M":
          productSize = "Regular";
          break;
        case "L":
          productSize = "Large";
          break;
        default:
          productSize = "One Size Fits All";
          break;
      }
      break;
  }

}


Console.WriteLine($"ProductNew: {productSize} {productColor} {productType}");