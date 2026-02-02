using RestWithASPNET10Ed.Model;

namespace RestWithASPNET10Ed.Services.Impl
{
    public class PersonServicesImpl : IPersonServices
    {
        public Person Create(Person person)
        {
            person.Id = new Random().Next(1,1000);//Simulate Id asignment
            return person;
        }
        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            //Simulate deletion logic
        }
        public Person FindById(long id)
        {
            var person = mockPerson((int)id);

            return person;
        }


        public List<Person> FindAll()
        {
           List<Person> persons = new List<Person>();
            for(int i = 0; i < 8; i++)
            {
                persons.Add(mockPerson(i));
            }
            return persons;
        }

        private Person mockPerson(int i)
        {
            var person = new Person
            {
                Id = new Random().Next(1, 1000),
                FirstName = "John"+ i,
                LastName = "Doe"+i,
                Address = "123 Main Street"+i,
                Gender = "Male"
            };

            return person;
        }


    }
}
