
#region task1
Console.WriteLine("Arrayin uzunlugunu daxil edin: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int[] array = new int[n];
Console.WriteLine("Arrayin elementlerini daxil edin: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] % 2 == 0)
    {
        sum += array[i];
    }

}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine(sum);
#endregion


//#region task2
//Console.WriteLine("Enter some text: ");
//string text = Console.ReadLine();
//Console.WriteLine("Enter some subtext: ");
//string subText = Console.ReadLine();
//bool isMatch=false;
//for (int i = 0; i < text.Length; i++)
//{
//    for (int j = 0; j < subText.Length; j++)
//    {
//        if (text[i] == subText[j])
//        {
//            isMatch = true;
//        }

//    }
//}
//if (isMatch == true)
//{
//    Console.WriteLine("It exists");
//    }
//else
//{
//    Console.WriteLine("It doesn't exist");
//}

//#endregion