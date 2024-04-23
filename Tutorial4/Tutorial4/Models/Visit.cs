namespace Tutorial4.Models;

public class Visit : Animal
{
    public DateTime Date { get; set; }
    public int IdAnimal { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}