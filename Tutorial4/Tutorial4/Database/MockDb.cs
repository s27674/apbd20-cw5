using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDb
{
    public static List<Animal> Animals { get; set; } = new List<Animal>();
    public static List<Visit> Visits { get; set; } = new List<Visit>();

    public MockDb()
    {
        if (Animals.Count == 0)
        {
            Animals.Add(new Animal { Id = 1, Name = "Żyrafa", Category = "Afrykańska", Weight = 300, Color = "Żółta" });
            Animals.Add(new Animal { Id = 2, Name = "Żółw", Category = "Stepowy", Weight = 150, Color = "Brązowy" });
            Animals.Add(
                new Animal { Id = 3, Name = "Hipopotam", Category = "Błotnisty", Weight = 800, Color = "Szary" });
        }

        if (Visits.Count == 0)
        {
            Visits.Add(new Visit()
                { Date = Convert.ToDateTime("2024-01-01 14:00"), Description = "good", IdAnimal = 1, Price = 300 });
            Visits.Add(new Visit()
                { Date = Convert.ToDateTime("2024-01-01 15:00"), Description = "good", IdAnimal = 2, Price = 700 });
            Visits.Add(new Visit()
                { Date = Convert.ToDateTime("2024-01-01 16:00"), Description = "good", IdAnimal = 3, Price = 800 });
            Visits.Add(new Visit()
                { Date = Convert.ToDateTime("2023-02-01 17:00"), Description = "good", IdAnimal = 1, Price = 400 });
            Visits.Add(new Visit()
                { Date = Convert.ToDateTime("2025-01-01 18:00"), Description = "good", IdAnimal = 1, Price = 590 });
        }
    }

    public Animal getAnimalById(int id)
    {
        Animal animal = new Animal();
        foreach (Animal a in Animals)
        {
            if (a.Id == id)
            {
                animal = a;
            }
        }

        return animal;
    }

    public void addAnimal(int id, string name, string category, double weight, string color)
    {
        Animal a = new Animal() {Id = id,Name = name,Category = category,Weight = weight,Color = color};
        Animals.Add(a);
        
    }

    public List<Animal> getListAnimals()
    {
        return Animals;
    }

    public void editAnimal(int id, string name, string category, double weight, string color)
    {
         Animal a = getAnimalById(id);
         a.Name = name;
         a.Category = category;
         a.Weight = weight;
         a.Color = color;
    }
    public void deleteAnimal(int id)
    {
        Animal a = getAnimalById(id);
        Animals.Remove(a);
    }

    public List<Visit> getListOfVisits(int idAnimal)
    {
        List<Visit> visitsA = new List<Visit>();
        
        foreach (Visit a in Visits)
        {
            if (a.IdAnimal == idAnimal)
            {
                visitsA.Add(a);
            }
        }

        return visitsA;
    }

    public void addVisit(DateTime date, int idAnimal, string description, double price)
    {
        Visit a = new Visit() { Date = date, IdAnimal = idAnimal, Description = description, Price = price};
        Visits.Add(a);
    }
}