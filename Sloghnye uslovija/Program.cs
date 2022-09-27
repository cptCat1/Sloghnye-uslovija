//Home_work_(Sloghnue_uslovija)_3

//a. 43 < 4 || 34 >= 32                                      true
//b. “red” == “red” && “blue” == “blue”                      true
//c. 23 > 23 ^ 23 == 23                                      true
//d. 2 > 2 || 34 == 2 ^ 23 <= 23                             true
//e. !(3 == 4) || 4 > 2 && 2 > 5                             true
//f. !((3 > 5 || 7 > 4) && !(9 <= 9 || 39 < 98 ^ 23 == 23))  false




//Home_work_(Sloghnue_uslovija)_4

//a
/*int GetRange(int min, int max, int[] data)
{
    int num = 0;    
    foreach ( int i in data)
    {
        if (!(i > min && i < max)) continue;
        num++;
    }
    return num;
}
*///b
/*int GetRange(int min, int max, int[] data)
{
    int num = 0;
    foreach (int i in data)
    {
        if (!(i > min && i < max && i % 2 == 0)) continue;
        num++;
    }
    return num;
}
*/




//Home_work_(Sloghnue_uslovija)_5

string[] products = GetDataProducts();
float[] prices_float = GetDataPricesFloat();
float[] sizes_float = GetDataSizesFloat();
string[] prices_string = GetDataPricesString();
string[] sizes_string = GetDataSizesString();

Console.WriteLine("Enter min price:");
float min_price = float.Parse(Console.ReadLine());
Console.WriteLine("Enter max price:");
float max_price = float.Parse(Console.ReadLine());
Console.WriteLine("Enter min size:");
float min_size = float.Parse(Console.ReadLine());
Console.WriteLine("Enter max size:");
float max_size = float.Parse(Console.ReadLine());

string[] filtered_array = Filter(min_price, max_price, min_size, max_size);

foreach (string item in filtered_array)
    Console.WriteLine(item);



string[] Filter(float min_price, float max_price, float min_size, float max_size)
{
    string[] array_lines = GetData();

    string[] array_Products = new string[Num(array_lines)];
    int j = 0;

    for (int i = 1; i < array_lines.Length; i++)
    {
        string[] array_fields = array_lines[i].Split(';');
        if (array_fields.Length != 3) continue;
        if (!(float.Parse(array_fields[1]) >= min_price && float.Parse(array_fields[1]) <= max_price &&
            float.Parse(array_fields[2]) >= min_size && float.Parse(array_fields[2]) <= max_size)) continue;
        array_Products[j++] = array_fields[0];

    }
    return array_Products;
}


string[] GetDataSizesString()
{
    string[] array_lines = GetData();

    string[] array_Sizes = new string[Num(array_lines)];
    int j = 0;

    for (int i = 1; i < array_lines.Length; i++)
    {
        string[] array_fields = array_lines[i].Split(';');
        if (array_fields.Length != 3) continue;
        array_Sizes[j++] = array_fields[2];
    }
    return array_Sizes;
}


string[] GetDataPricesString()
{
    string[] array_lines = GetData();

    string[] array_Prices = new string[Num(array_lines)];
    int j = 0;

    for (int i = 1; i < array_lines.Length; i++)
    {
        string[] array_fields = array_lines[i].Split(';');
        if (array_fields.Length != 3) continue;
        array_Prices[j++] = array_fields[1];
    }
    return array_Prices;
}


float[] GetDataSizesFloat()
{
    string[] array_lines = GetData();

    float[] array_Sizes = new float[Num(array_lines)];
    int j = 0;

    for (int i = 1; i < array_lines.Length; i++)
    {
        string[] array_fields = array_lines[i].Split(';');
        if (array_fields.Length != 3) continue;
        array_Sizes[j++] = float.Parse(array_fields[2]);
    }
    return array_Sizes;
}


float[] GetDataPricesFloat()
{
    string[] array_lines = GetData();

    float[] array_Prices = new float[Num(array_lines)];
    int j = 0;

    for (int i = 1; i < array_lines.Length; i++)
    {
        string[] array_fields = array_lines[i].Split(';');
        if (array_fields.Length != 3) continue;
        array_Prices[j++] = float.Parse(array_fields[1]);
    }
    return array_Prices;
}


string[] GetDataProducts()
{
    string[] array_lines = GetData();

    string[] array_Products = new string[Num(array_lines)];
    int j = 0;

    for (int i = 1; i < array_lines.Length; i++)
    {
        string[] array_fields = array_lines[i].Split(';');
        if (array_fields.Length != 3) continue;
        array_Products[j++] = array_fields[0];
    }
    return array_Products;
}


int Num(string[] array)
{
    int lines = 0;
    for (int i = 1; i < array.Length; i++)
    {
        string[] array_fields = array[i].Split(';');
        if (array_fields.Length != 3) continue;
        lines++;
    }
    return lines;
}

string[] GetData()
{
    string file = File.ReadAllText("D://Products.csv");
    string[] array_lines = file.Split('\n');
    return array_lines;
}

