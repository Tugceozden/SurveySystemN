
namespace Core.Entities
{
	public interface IEntity<TId>
	{
		DateTime CreatedAt { get; set; }
		DateTime DeletedAt { get; set; }
		TId Id { get; set; }
		DateTime? UpdateAt { get; set; }
	}
}