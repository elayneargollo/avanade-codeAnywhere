using System;

namespace Start {

  class Twitter 
  {
    static void Main(string[] args) 
    {
        string postagem = "";
        
        postagem = Convert.ToString(Console.ReadLine());
        
        if(postagem.Length > 140)
        {
            Console.Write("MUTE");
        }
        else
        Console.Write("TWEET");
    }
  }

}