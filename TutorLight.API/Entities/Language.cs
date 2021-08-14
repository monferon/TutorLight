namespace Tutor.Domain.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TranslateId { get; set; } // Добавить лист для переводов
        public int SettingId { get; set; }
    }
}