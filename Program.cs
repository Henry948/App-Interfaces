using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      TodoList td = new TodoList();
      td.Add("Invite friends");
      td.Add("Buy decorations");
      td.Add("Party");

      PasswordManager pm = new PasswordManager("iluvpie", true);

      td.Display();
      pm.Display();
    }
  }
}