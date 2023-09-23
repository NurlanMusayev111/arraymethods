
//static string UpperFirstChar(string str)
//{
//    string name = char.ToUpper(str[0]) + str.Substring(1);
//    return name;
//}

//Console.WriteLine(UpperFirstChar("nurlan"));




//-------------------------------------




//static string FirstElemetToUpper(string str)
//{
//    char[] charArray = str.ToCharArray();

//    string firstChar = charArray[0].ToString().ToUpper();

//    charArray[0] = Convert.ToChar(firstChar);


//    foreach (char item in charArray)
//    {
//        Console.WriteLine(item);
//    }



//    return "";
//}


//-----------------------------------



//using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Azer");

//stringBuilder.Append("baycan");

//Console.WriteLine(stringBuilder);






//-------------------------------------


//int[] nums = { 1, 2, 3 };

//int[] newArr = { 32, 22, 56, 43, 64, 7 };

//int arrayCount = newArr.Length;

//Array.Resize(ref newArr, nums.Length + newArr.Length);


//nums.CopyTo(newArr, arrayCount);    


//foreach (var item in newArr)
//{
//    Console.WriteLine(item);
//}



//---------------------------------


//static int[] CopyToArray(int[] destination, int[] source)
//{
//    int destinationLength = destination.Length;
//    Array.Resize(ref destination,source.Length + destination.Length);

//    source.CopyTo(destination,destinationLength);

//    return destination;
//}



//int[] arr1 = { 1, 2, 3, 4, 5 };

//int[] arr2 = { 100, 200, 300 };

//var result = CopyToArray(arr1,arr2);


//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}




//--------------------------------



//int[] numbers = { 2, 3, 4, 5, 6 };

//var result = Array.Exists(numbers , x => x == 1);

//var result = Array.Find(numbers, x => x == 1);

//var result = Array.FindAll(numbers, x => x == 1);

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}


//Console.WriteLine(result);