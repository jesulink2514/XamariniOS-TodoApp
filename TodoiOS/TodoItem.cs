using System;

namespace TodoiOS
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Tarea { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Completado { get; set; }
    }
}