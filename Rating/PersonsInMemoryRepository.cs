using Rating.Models;

namespace Rating
{
    public class PersonsInMemoryRepository
    {
        private List<Person> persons = new List<Person>()
            {
                new Person("Bob",19,"KIA",2000),
                new Person("Anna", 23,"POW", 8000)
            };

        public void Add(Person person)
        {
            persons.Add(person);
        }

        public List<Person> GetPerson() { return persons; }

        public Person TryGetById(int id)
        {
            return persons.FirstOrDefault(persons => persons.Id == id);
        }

        public void Update(Person person)
        {
            var existingPerson = persons.FirstOrDefault(x => x.Id == person.Id);
            if (existingPerson == null) return;

            existingPerson.Name = person.Name;
            existingPerson.Age = person.Age;
            existingPerson.Type = person.Type;
            existingPerson.MonthlyPay = person.MonthlyPay;
        }
    }
}
