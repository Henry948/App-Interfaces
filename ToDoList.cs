using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable
  {
    string HeaderSymbol = "----------";
    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
    }

     public void Display(){
      int count = 1;
      Console.WriteLine("\nTodos");
      Console.WriteLine(HeaderSymbol);
      
        foreach(string Todo in Todos){
          if(String.IsNullOrEmpty(Todo)){
             Console.WriteLine($"{count}: []");
          } else{
            Console.WriteLine($"{count}: {Todo}");
          }        
        count++;
      }
    }
  }
}