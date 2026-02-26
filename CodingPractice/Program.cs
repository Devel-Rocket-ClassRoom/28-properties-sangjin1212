using System;
using System.Xml.Linq;
//1
Player player = new Player();
player.Health = 100;
player.Health = -999;
//2
Player1 player1 = new Player1();
player1.SetHealth(100);
Console.WriteLine(player1.GetHealth());
//3
Person person = new Person();
person.Name = "홍길동";
Console.WriteLine(person.Name);
//4
Developer developer = new Developer();
developer.Name = "김개발";
developer.Age = 25;
Console.WriteLine($"{developer.Name}, {developer.Age}세");
//5
Player2 player2 = new Player2();
Console.WriteLine($"이름: {player2.Name}");
Console.WriteLine($"레벨: {player2.Level}");
Console.WriteLine($"최대 체력: {player2.MaxHealth}");
//6
Car car = new Car();
car.Name = "소나타";
car.Color = "검정";
Console.WriteLine($"{car.Name}, {car.Color}");
//7
Product product = new Product();
Console.WriteLine(product.Manufacturer);
//8
Page page = new Page();
Console.WriteLine(page.Message);
page.UpdateMessage("업데이트된 메시지");
Console.WriteLine(page.Message);
//9
SecureDate secureDate = new SecureDate();
secureDate.PassWard = "secret 1234";
Console.WriteLine(secureDate.Valladate("secret 1234"));
//10
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}");
Console.WriteLine($"넓이: {circle.Area}");
Console.WriteLine($"둘레: {circle.Circumference}");
//11
Counter counter = new Counter();
counter._count = 10;
counter.Increase();
Console.WriteLine($"카운트: {counter.Count}");
//12
Player3 player3 = new Player3();
player3.Health = 150;
Console.WriteLine($"체력: {player3.Health}");
player3.Health = -50;
Console.WriteLine($"체력: {player3.Health}");
//13
Person1 person1 = new Person1();
person1.Name = "홍길동";
person1.BirthYear = 2000;
Console.WriteLine($"{person1.Name}님의 나이: {person1.age}");
//14
Course course = new Course();
course.id = 1;
course.Title = "C# 기초";
Console.WriteLine($"{course.id} - {course.Title}");
//16
Customer customer = new Customer
{
    Id = 1,
    Name = "김철수",
    Email = "kim@example.com",
    City = "서울"
};
Console.WriteLine($"고객 #{customer.Id}");
Console.WriteLine($"이름: {customer.Name}");
Console.WriteLine($"이메일: {customer.Email}");
Console.WriteLine($"도시: {customer.City}");
//17
Console.WriteLine($"게임: {GameSettings.GameTitle}");
Console.WriteLine($"최대 플레이어: {GameSettings.MaxPlayers}");
Console.WriteLine($"사운드: {GameSettings.IsSound}");
GameSettings.MaxPlayers = 8;
Console.WriteLine($"변경된 최대 플레이어: {GameSettings.MaxPlayers}");

//18
Monster monster = new Monster("고블린");
monster.Level = 5;
monster.Attack = 15;
Console.WriteLine($"이름: {monster.Name}");
Console.WriteLine($"레벨: {monster.Level}");
Console.WriteLine($"체력: {monster.Health}");
Console.WriteLine($"공격력: {monster.Attack}");
Console.WriteLine($"방어력: {monster.Defense}");
Console.WriteLine($"생존: {monster.IsAlive}");
monster.TakeDamage(50);
Console.WriteLine($"50의 대미지 후 체력: {monster.Health}");




//1
class Player
{
    public int Health;
}
//2
class Player1
{
    private int _health;

    public void SetHealth(int value)
    {
        if (value >= 0 && value <= 100)
        {
            _health = value;
        }
    }

    public int GetHealth()
    {
        return _health;
    }
}
//3
class Person
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }

    }

}
//4
class Developer
{ 
    public string Name { get; set; }
    public int Age { get; set; }
}

//5
class Player2
{
    public string Name { get; set; } = "플레이어";
    public int Level { get; set; } = 1;
    public int MaxHealth { get; set; } = 100;

}

class Car
{
    private string _name;
    public string Name
    {
        get { return _name;}
        set { _name = value; }
    }
    public string Color { get; set; }
}

//7
class Product
{ 
    public string Manufacturer
    {
        get { return "한국전자"; }
    }
}

//8
class Page
{
    public string Message { get; private set; } = "읽기 전용 메시지";
    public void UpdateMessage(string message)
    {
        Message = message;
    }
}
//0
class SecureDate
{
    private string _password;
    public string PassWard
    {
        set { _password = value; }
    }

    public bool Valladate(string input)
    {
        return _password == input;
    }
}

//10
class Circle
{ 
    public double Radius { get; set; }
    public double Area => 3.14159 * Radius * Radius;
    public double Circumference => 2 * 3.14159 * Radius;
}
//11
class Counter
{
    public int _count;

    public int Count
    {
        get => _count;
        set => _count = value;
    }

    public void Increase() => _count++;
}
//12
class Player3
{
    private int _health;

    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }

            else if (value > 100)
            {
                _health = 100;
            }
            else
            {
                _health = value;
            }
        }
    }
}
//13
class Person1
{
    private int _birhyear;
    public string Name { get; set; }
    public int BirthYear
    {
        set 
        {
            if (value >= 1900)
            {
                _birhyear = value;
            }
        }
    }
    public int age
    {
        get { return DateTime.Now.Year - _birhyear; }
    }
}
//14
class Course
{ 
    public int id { get; set; }
    public string Title { get; set; }
}

//15
class Course1
{
    public int Id { get; set; }
    public string Title { get; set; }
}

//16

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}
//17

class GameSettings
{
    public static string GameTitle { get; set; } = "My Game";
    public static int MaxPlayers { get; set; } = 4;
    public static bool IsSound { get; set; } = true;

}

class Monster
{
    private int _health;

    private const int k_MaxHealth = 200;


    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > k_MaxHealth)
            {
                _health = k_MaxHealth;
            }
            else
            {
                _health = value;
            }
        }
    }
    public int Level { get; set; } = 1;
    public int Attack { get; set; } = 10;
    public string Name { get; private set; }
    public bool IsAlive => Health > 0;
    public int Defense => Level * 2;

    public Monster(string name)
    {
        Name = name;
        Health = 100;
    }
    public void TakeDamage(int damage)
    {
        int actualDamage = damage - Defense;
        if (actualDamage > 0)
        {
            Health -= actualDamage;
        }
    }
}