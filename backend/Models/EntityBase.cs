public abstract class EntityBase
{
    
    public Guid Id {get; private init; } = Guid.NewGuid();
}