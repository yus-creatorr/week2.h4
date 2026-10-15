class Users
{
    public string FirstName;
    public string LastName;
    public string UserName;
    int Pasword;
    public Users(string first, string last, string user,int pas)
    {
        FirstName=first;
        LastName=last;
        UserName=user;
        Pasword=pas;
    }

    public void GetInfo()
    {
        System.Console.WriteLine(FirstName);
        System.Console.WriteLine(LastName);
        System.Console.WriteLine(UserName);
    }

    public void Login()
    {
        System.Console.WriteLine("Username: ");
        string username=Console.ReadLine();

        System.Console.WriteLine("Pasword: ");
        string pass=Console.ReadLine();    

    }

}