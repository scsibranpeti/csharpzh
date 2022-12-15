using csharpzh;

List<NGC> list = new List<NGC>();
int listSize = 10000000;

for(int i = 0; i<listSize; i++)
{
    list.Add(new NGC());
}

float sum = 0;
int opt = 0;
int atl = 0;
int pessz = 0;
foreach(NGC ngiszi in list)
{
    sum += ngiszi.happines;
    switch (ngiszi.type)
    {
        case 1: atl++;
            break;
        case 2: opt++;
            break;
        case 3: pessz++;
            break;

    }
}
Console.WriteLine("összboldogság: " + sum + " optimista: " + ((float)opt/listSize)*100 + "% , pesszimista: " + ((float)pessz/listSize)*100 + "% , átlagos: " + ((float)atl/listSize)*100 + "%");