using SQLite;
using System;
using System.IO;

namespace TodoiOS
{
    public class Database
    {
        private static SQLiteConnection _db;
        public static SQLiteConnection GetConnection()
        {
            if (_db != null) return _db;

            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var library = Path.Combine(documents, "..", "Library");
            var path = Path.Combine(library, "todos.db3");
            var conn = new SQLiteConnection(path);

            conn.CreateTable<TodoItem>();

            _db = conn;

            return _db;
        }
    }
}