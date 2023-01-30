public class Kit
{
    public int KitId { get; set; }
    public string? Name { get; set;}
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }


    public int? CisternId { get; set; }
    public Cistern? Cistern { get; set; }
    public List<Cistern> Cisterns { get; set; } = new();
}
