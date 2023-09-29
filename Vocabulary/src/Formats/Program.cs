int numOfBagels = 6;
decimal pricePerBagel = 35.2M;


Console.WriteLine(format:"{0} bagels cost {1:C}",arg0:numOfBagels,arg1:pricePerBagel*numOfBagels);


string formatted = string.Format(format: "{0} bagels cost {1:C}", arg0: numOfBagels, arg1: pricePerBagel * numOfBagels);
// WriteToFile(formatted); <- writes the formatted variable to a file


// { index[,alignment][:formatString] }