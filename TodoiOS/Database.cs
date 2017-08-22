using SQLite;
using System;
using System.IO;

namespace TodoiOS
{
    public class Database
    {
        public static SQLiteConnection GetConnection()
        {
            var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var library = Path.Combine(documents, "..", "Library");
            var path = Path.Combine(library, "todos.db3");
            var conn = new SQLiteConnection(path);

            conn.CreateTable<TodoItem>();

            return conn;
        }
    }
}