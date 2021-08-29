using System.Collections.Generic;

namespace Tutor.Domain.Entities
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public List<Word> Words { get; set; } // Добавить лист для слов
        // public int SettingId { get; set; } 
    }
}