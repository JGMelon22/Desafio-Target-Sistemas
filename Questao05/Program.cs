string originalString = "Linux User 123";

string reversedString = ReverseString(originalString);

Console.WriteLine("String original: " + originalString);
Console.WriteLine("String invertida: " + reversedString);


string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();

    int leftIndex = 0;
    int rightIndex = charArray.Length - 1;

    while (leftIndex < rightIndex)
    {
        char temp = charArray[leftIndex];
        charArray[leftIndex] = charArray[rightIndex];
        charArray[rightIndex] = temp;

        leftIndex++;
        rightIndex--;
    }

    return new string(charArray);
}
