using System.Numerics;

public interface IUpdater<in T>
{
    void Update(T entity);
}
public class User
{
    public string Name { get; set; }
}

public class Account : User
{
    public int Id { get; set; }
}

public class Updater : IUpdater<User>
{
    public void Update(User entity)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Это начало основной программы
/// </summary>
internal class Program10
{
    private static void Main(string[] args)
    {
        var user = new User();
        var accout = new Account();

        IUpdater<Account> updater = new Updater();
        var userrrr = new Updater();
        userrrr.Update(user);
        
        Console.Read();
    }
}