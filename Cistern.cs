using System.ComponentModel.DataAnnotations;

public class Cistern
{
    public int CisternId { get; set; }
    public string? Name { get; set; }
    public double WaterVolume { get; set; }
    public int Temperature { get; set; }
    public double Pressure { get; set; }
    public DateTime CreatedAt { get; set; }


    public int? OilVolumeId { get; set; } // внешний ключ
    public OilVolume? OilVolume { get; set; } // навигационное свойство
    /*public double OilVolumeValue { get; set; }*/
}
