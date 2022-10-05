using ConsoleApp;
using Data.Entities;
using Data.Repositories;
using Data.Services;

var userManager = ContainerManager.Instance.GetInstance<IUserManager>();
if (userManager is null)
    throw new ArgumentNullException();

var userRepository = ContainerManager.Instance.GetInstance<IUserRepository>();
if (userRepository is null)
    throw new ArgumentNullException();

User? user = null;

if (userManager.UserId is not null)
    user = userRepository.GetById(userManager.UserId.Value);

if (user is null)
{
    user = DoLoginOrRegister();
    userManager.SignIn(user);
}


if (user is null)
    throw new ArgumentException();

Console.WriteLine($"user is authorized: {user.Name}");

User DoLoginOrRegister()
{
    do
    {
        Console.WriteLine("SignIn (s) or Register (r)?");
        var answer = Console.ReadLine();
        switch (answer)
        {
            case "s":
                return DoLogin();
            case "r":
                return DoRegister();
            default:
                Console.WriteLine("Incorrect input");
                break;
        }
    } while (true);
}

User DoLogin()
{
    User? user = null;
    do
    {
        string? login;
        do
        {
            Console.WriteLine("Enter login");
            login = Console.ReadLine();
        } while (login is null);

        string? password;
        do
        {
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
        } while (password is null);

        if (login is null || password is null)
            throw new ArgumentNullException();

        user = userRepository.GetByLoginAndPassword(login, password);
        if (user is not null)
            break;

        Console.WriteLine("User is not found");
    }
    while (true);

    return user;
}

User DoRegister()
{
    string? login;
    do
    {
        Console.WriteLine("Enter login");
        login = Console.ReadLine();
    } while (login is null);
    
    string? password;
    do
    {
        Console.WriteLine("Enter password");
        password = Console.ReadLine();
    } while (password is null);
    
    string? name;
    do
    {
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
    } while (name is null);

    if (login is null || password is null)
        throw new ArgumentNullException();

    var user = new User()
    {
        Login = login,
        Password = password,
        Name = name,
    };
    
    userRepository.Add(user);

    return user;
}