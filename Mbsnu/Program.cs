OilVolume C1 = new(){Name ="C1", MaxValue = 200};
OilVolume C2 = new(){Name ="C2", MaxValue = 200};
OilVolume BE1 = new(){Name ="BE1", MaxValue = 240};
OilVolume BE2 = new(){Name ="BE2", MaxValue = 240};
OilVolume RGS1 = new(){Name ="RGS1", MaxValue = 314};
OilVolume RGS2 = new(){Name ="RGS2", MaxValue = 314};
OilVolume EN1 = new(){Name ="EN1", MaxValue = 240};
OilVolume EN2 = new(){Name ="EN2", MaxValue = 240};

List<OilVolume> names = new() {C1, C2, BE1, BE2, RGS1, RGS2, EN1, EN2};
for (int i = 0; i < names.Count; i++)
{
    Console.Write($"{names[i].Name}: ");
    names[i].UserInput();
    names[i].ResultVolumeOil(i);
    Console.WriteLine($"Объем в {names[i].Name}: {names[i].Value}");
}
for (int i = 0; i < names.Count; i++)
{
    Console.Write($"{names[i].Name}: ");
    names[i].UserInput();
    names[i].ResultTemperature();
}



Console.WriteLine( $"Сумма С-1 и С-2 = {C1.Value+C2.Value}  В С-1 - {C1.Value} А в РГС-1 - {RGS1.Value}");
Console.WriteLine($"Температура: {C1.Temperature}, {EN2.Temperature}");

