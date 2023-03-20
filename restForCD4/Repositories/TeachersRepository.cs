using restForCD4.Models;

namespace restForCD4.Repositories
{
    public class TeachersRepository
    {
        private static List<Teacher> data = new List<Teacher>()
        {
            new Teacher() { Id = 1, Name = "John" },
             new Teacher() {Id = 2, Name = "Anders"}
        };

        public List<Teacher> GetAll()
        {
            return new List<Teacher>(data);
        }
    }
}
