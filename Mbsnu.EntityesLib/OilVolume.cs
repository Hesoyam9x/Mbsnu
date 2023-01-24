public class OilVolume
{
    public int OilVolumeId { get; set; }
    public string? Name { get; set; }
    public double Value { get; set; }
    public int MaxValue { get; set; }
    public int Temperature { get; set; }
    private int num;

    public int UserInput()
    {        
        while(true)
        {
            string? inp = Console.ReadLine();
            if(int.TryParse(inp, out num))
            {
                if (num <= MaxValue & num > 0) break;
                else Console.WriteLine("Error: MaxValue;");
            }
            else Console.WriteLine("Error: NAN;");
        }
        return num;
    }
    public double ResultVolumeOil(int i) => Value = Calibration.OilVolume[i][num];

    public int ResultTemperature() => Temperature = num;

    
    
}