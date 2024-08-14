namespace Habitr.src.Models
{
	public class Activity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public GeoLocation Location { get; set; }
		public ICollection<Remark> Remarks { get; set; }
	}
}
