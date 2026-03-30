string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] streamArray = orderStream.Split(',');

Array.Sort(streamArray);
foreach (var stream in streamArray)
{
    if (stream.Length == 4)
        Console.WriteLine(stream);
    else
        Console.WriteLine(stream + "\t - Error");
}