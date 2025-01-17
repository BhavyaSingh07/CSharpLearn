//  SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0]){
    case "01":
        type="Sweat shirt";
        break;

     case "02":
          type = "T - Shirt";
          break;

     case "03":
          type = "Sweat Pants";
          break;
     default:
         type = "Other";
         break;
 }

 if (product[1] == "BL")
 {
     color = "Black";
 } else if (product[1] == "MN")
 {
     color = "Maroon";
 } else
 {
     color = "White";
 }

 if (product[2] == "S")
 {
     size = "Small";
 } else if (product[2] == "M")
 {
     size = "Medium";
 } else if (product[2] == "L")
 {
     size = "Large";
 } else
 {
     size = "One Size Fits All";
 }

Console.WriteLine($"Product: {size} {color} {type}");

