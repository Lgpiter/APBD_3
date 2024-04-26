using WebApplication1.Model;

namespace WebApplication1.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals(String orderBy);
    int CreateAnimal(Animal animal);
    Animal GetAnimal(int idAnimal);
    int UpdateAnimal(Animal animal);
    int DeleteAnimal(int idAnimal);
}