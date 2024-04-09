using Rating.Models;

namespace Rating
{
    public interface IPersonsRepository
    {
        void Add(Person person);
        void Update(Person person);
        List<Person> GetAll();
        Person TryGetById(int id);
    }
}
