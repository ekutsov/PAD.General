namespace PAD.General.Infrastructure.Models;

public abstract class Translation<T> where T : Translation<T>, new()
{
    public Guid Id { get; set; }

    public string CultureName { get; set; }

    protected Translation()
    {
        Id = Guid.NewGuid();
    }
}