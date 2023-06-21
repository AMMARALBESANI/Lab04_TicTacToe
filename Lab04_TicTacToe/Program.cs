using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello players !");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
           
            //Here we take an inatane from player and we give it name ,marker and we give him the turn status
            Player palyer1 = new Player();
            Player palyer2 = new Player();
            palyer1.Name = "ammar";
            palyer2.Name = "abd";
            palyer1.Marker = "X";
            palyer2.Marker = "O";
            palyer1.IsTurn = true;
            palyer2.IsTurn = false;
            //we take an instance from the game and send the palyers as parameter

            Game Tictac= new Game(palyer1 , palyer2);

            Player theWinner = Tictac.Play();

            // here we make a if condition it null to print draw situation else there is a winner

            if (theWinner == null ) {
                Console.WriteLine("this is a draw");
            }else {
                
                Console.WriteLine($"\nthe winner is {theWinner.Name}");
            }
            

        }


    }
}
