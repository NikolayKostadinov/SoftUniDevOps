/// <summary>
/// Тестов клас за упражнение за разрешаване на конфликти
/// </summary>
public class User
{
    // Свойства на класа
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    // Конструктори
    public User() { }

    public User(int id, string firstName, string lastName, string email, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    // Методи
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public bool ValidatePassword(string inputPassword)
    {
        // Проста проверка, може да се разшири с хеширане/шифриране
        return Password == inputPassword;
    }

    public override string ToString()
    {
        return $"User [Id={Id}, FullName={GetFullName()}, Email={Email}]";
    }
}