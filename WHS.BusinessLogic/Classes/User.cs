

namespace WHS.BusinessLogic.Classes
{
    class User
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int Id { get; set; }

        public string Login { get; set; }

        public int Password { get; set; }
    }
}
