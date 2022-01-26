Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine(
format: "{0,-10} {1,6} {2,19} {3,30}",
"Type", "Byte(s) of memory", "Min", "Max");

Console.WriteLine("-------------------------------------------------------------------------------");

Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "short", sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "int", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "long", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "float", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,35} {3,30}",
    "double", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine(
format: "{0,-10} {1,0} {2,34} {3,30}",
    "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);

Console.WriteLine("-------------------------------------------------------------------------------");

