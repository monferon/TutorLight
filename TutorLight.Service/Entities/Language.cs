using System.Collections.Generic;

namespace Tutor.Domain.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Translate> Translates { get; set; } // Добавить лист для переводов
        // public int SettingId { get; set; }
    }
}