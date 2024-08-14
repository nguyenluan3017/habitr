namespace Habitr.src.Models
{
	public class Activity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }

		// Foreign key properties
		public int? GeoLocationId { get; set; }

		// Navigation properties
		public GeoLocation? GeoLocation { get; set; }
		public ICollection<Remark>? Remarks { get; set; }
	}
}
