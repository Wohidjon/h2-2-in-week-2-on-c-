// task 1
// Rectangle rectangle1 = new Rectangle()
// {
//     Width = 15,
//     Height = 12,
//     Color = "Blue",
// };
// Console.WriteLine(rectangle1.GetArea());
// Console.WriteLine(rectangle1.GetPerimeter());

// task 2
// Login login1 = new Login()
// {
//     FirstName = "Abdullo",
//     LastName = "Abdulloev",
//     UserName = "Abdu",
//     Password = "1234",
// };
// login1.UserLoginSystem("Abdu", "1234");
// Console.WriteLine(login1.GetFullInfo());

// Task 3
        Author author1 = new Author();
        Author author2 = new Author("Толстой", 50);
        Author author3 = new Author("Пушкин", 37, "Россия");

        author3.Introduce();
        author3.CelebrateBirthday();
        Console.WriteLine($"Новый возраст: {author3.GetAge()}");


// Task 4
Country tajikistan = new Country("Tajikistan", "Dushanbe", 9537645, "Tajik");
tajikistan.PrintInfo();

