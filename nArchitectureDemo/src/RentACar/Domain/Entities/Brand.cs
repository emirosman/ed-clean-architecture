using Core.Persistence.Repositories;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public string Name { get; set; }

	public Brand()
	{

	}

	public Brand(Guid id, string name)
	{
		Name= name;
	}
}
