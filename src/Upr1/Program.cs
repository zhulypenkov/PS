using Upr1.Model;
using Upr1.Others;
using Upr1.View;
using Upr1.ViewModel;

class Program
{
    public static void Main()
    {
        User user = new User()
        {
            Name = "Angel",
            FakNum = "121221062",
            Mail = "angel@abv.bg",
            Password = "1234",
            Role = UserRolesEnum.STUDENT
        };

        UserViewModel uvm = new UserViewModel(user);
        UserView uv = new UserView(uvm);

        uv.Display();
        uv.DisplayColor();

        Console.ReadKey();
    }
}