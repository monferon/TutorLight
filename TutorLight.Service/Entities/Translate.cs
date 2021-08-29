namespace Tutor.Domain.Entities
{
    public class Translate
    {
        public int Id { get; set; }
        public int WordId { get; set; }
        public int LanguageId { get; set; }
        public string Trans { get; set; }
        public string Trascription { get; set; }
        public string Audio { get; set; }
    }
}