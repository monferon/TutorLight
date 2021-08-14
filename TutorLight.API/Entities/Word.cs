namespace Tutor.Domain.Entities
{
    public class Word
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public string Name { get; set; }
        public int Picture { get; set; }
    }
}