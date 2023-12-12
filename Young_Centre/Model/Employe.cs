using LinqToDB.Mapping;

namespace Young_Centre.Model
{
    public class Employe
    {
        [Identity]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTimeOffset DataOfBrith { get; set; }

    }
}
