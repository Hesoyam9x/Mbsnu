using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OilVolume
{
    public int OilVolumeId { get; set; }
    public string? Name { get; set; }
    public double Value { get; set; } // Требуемое свойство
    public int MaxValue { get; set; }
    public DateTime CreatedAt { get; set; }

    public double ResultVolumeOil(int i)
    {
        int num;
        while (true)
        {
            string? inp = Console.ReadLine();
            if (int.TryParse(inp, out num))
            {
                if (num <= MaxValue & num > 0) break;
                else Console.WriteLine("Error: MaxValue;");
            }
            else Console.WriteLine("Error: NAN;");
        }
        return Value = Calibration.OilVolume[i][num];
    }
}

