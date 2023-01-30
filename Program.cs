using Microsoft.EntityFrameworkCore;

using (AppContext db = new AppContext())
{
    
    OilVolume C1o = new() { Name = "C1", MaxValue = 200 };
    OilVolume C2o = new() { Name = "C2", MaxValue = 200 };
    OilVolume BE1o = new() { Name = "BE1", MaxValue = 240 };
    OilVolume BE2o = new() { Name = "BE2", MaxValue = 240 };
    OilVolume RGS1o = new() { Name = "RGS1", MaxValue = 314 };
    OilVolume RGS2o = new() { Name = "RGS2", MaxValue = 314 };
    OilVolume EN1o = new() { Name = "EN1", MaxValue = 240 };
    OilVolume EN2o = new() { Name = "EN2", MaxValue = 240 };
    db.OilVolumes.AddRange(C1o, C2o, BE1o, BE2o, RGS1o, RGS2o, EN1o, EN2o);

    Cistern C1 = new Cistern { OilVolume = C1o };
    Cistern C2 = new Cistern { OilVolume = C2o };
    Cistern BE1 = new Cistern { OilVolume = BE1o };
    Cistern BE2 = new Cistern { OilVolume = BE2o };
    Cistern RGS1 = new Cistern { OilVolume = RGS1o };
    Cistern RGS2 = new Cistern { OilVolume = RGS2o };
    Cistern EN1 = new Cistern { OilVolume = EN1o };
    Cistern EN2 = new Cistern { OilVolume = EN2o };
    db.Cisterns.AddRange(C1, C2, BE1, BE2, RGS1, RGS2, EN1, EN2);

    db.SaveChanges();



    Kit Kit1 = new() { Name = "1_Complect", Cisterns = db.Cisterns.ToList() };
    db.Kits.Add(Kit1);

    db.SaveChanges();



    var names = db.OilVolumes.ToList();

    for (int i = 0; i < 8; i++)
    {
        Console.Write($"{names[i].Name}: ");
        names[i].ResultVolumeOil(i);
        db.OilVolumes.Add(names[i]);
        Console.WriteLine($"Объем в {names[i].Name}: {names[i].Value}");
    }



    var namess = db.Cisterns.ToList();

    var nameKit = db.Kits
        .Include(c => c.Cisterns)
        .ToList();

    foreach (var item in nameKit) 
    {
        Console.WriteLine($"{item.Name} -- Cisterns : {item.Cisterns.Count}");
    }


    List<Cistern> k1 = Kit1.Cisterns;
    foreach (var c in k1)
    {
        Console.WriteLine($"{c.Name}-{c.OilVolume?.Value}-{c.CreatedAt}");
    }
}
