namespace Tutor.Domain.Entities
{
    public class Theme
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WordId { get; set; } // Добавить лист для слов
        public int SettingId { get; set; } 
    }
}