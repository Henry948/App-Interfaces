using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {

    string HeaderSymbol = "----------";


    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    public PasswordManager(string password, bool hidden)
    {
      Password = password;
      Hidden = hidden;
    }

    public void Display()
    {
      Console.WriteLine("\nPassword");
      Console.WriteLine(HeaderSymbol);
      if (!Hidden)
      {
        Console.WriteLine(Password);
      } else {
        Console.WriteLine("******");
      }
    }
  }
}