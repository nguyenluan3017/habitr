namespace Habitr.src.Models
{
    public class Remark
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
    }
}