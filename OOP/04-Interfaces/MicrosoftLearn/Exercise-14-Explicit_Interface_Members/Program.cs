using Exercise_14_Explicit_Interface_Members;

Box box = new Box();
IEnglishDimensions eDimensions = box;
IMetricDimensions mDimensions = box;

Console.WriteLine($"Length in inches: {eDimensions.Length()}");
Console.WriteLine($"Width in inches: {eDimensions.Width()}");
Console.WriteLine($"Length in centimeters: {mDimensions.Length()}");
Console.WriteLine($"Width in centimeters: {mDimensions.Width()}");