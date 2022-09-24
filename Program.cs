// See https://aka.ms/new-console-template for more information
/////////////////////////////
// Assignment 1: create a game of Tic-Tac-Toe
// Group Members: Emma Quackenbush, Nathan Marble, Justin Paystrup, Andre Regino, Madison Brown
////////////////////////////

// Console.WriteLine("Welcome to Tic-Tac-Toe!");

// //variables
// string first = "1";
// string second = "2";
// string third = "3";
// string fourth = "4";
// string fifth = "5";
// string sixth = "6";
// string seven = "7";
// string eight = "8";
// string nine = "9";
// //

// // interface start

//     Console.WriteLine($"{first}|{second}|{third}");
//     Console.WriteLine("-+-+-");
//     Console.WriteLine($"{fourth}|{fifth}|{sixth}");
//     Console.WriteLine("-+-+-");
//     Console.WriteLine($"{seven}|{eight}|{nine}");
    
// // interface end

// // user input start

// Console.WriteLine('Please choose "x" or "o"');
// string symbol = Console.ReadLine();
// Console.WriteLine('Choose a number from the grid');
// string userInput = Console.ReadLine();

// if (userInput == first)
// {
//     first = userInput;    
// }
// else if (userInput = second)
// {
//     second = userInput;
// }
// else if (userInput = third)
// {
//     third = userInput;
// }
// else if (userInput = fourth)
// {
//     fourth = userInput;
// }
// else if (userInput = fifth)
// {
//     fifth = userInput;
// }
// else if (userInput = sixth)
// {
//     sixth = userInput;
// }
// else if (userInput = seven)
// {
//     seven = userInput;
// }
// else if (userInput = eight)
// {
//     eight = userInput;
// }
// else if (userInput = nine)
// {
//     nine = userInput;
// }


namespace cseUnitOne{

public class Program
{
	public static void Main(string[]args){
	
    string[] numberArray = {"1","2","3","4","5","6","7","8","9"};
    string currentPlayer = "x";

    
        string gameOver = "false";
        int counter = 0;
        while(gameOver == "false")
            {
            printBoard(numberArray);
            Console.Write($"Please pick a number between 1 and 9 player: {currentPlayer}");
            String cellNumber = Console.ReadLine();

            int cellNumberConvert = Int32.Parse(cellNumber);

            numberArray[cellNumberConvert - 1] = currentPlayer;
            currentPlayer = getNextPlayer(currentPlayer);

            counter++;
            gameOver = IsWinner(numberArray,counter); 
            
            }
        if (gameOver == "tie")
            {
            Console.WriteLine("You tied. you both lose");
            
            }
        else{
            Console.WriteLine($"The winner is {gameOver}");
        }
        
        





        }
static void printBoard(string[] numberArray)
        {
            
            //print board
            Console.WriteLine($"{numberArray[0]}|{numberArray[1]}|{numberArray[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{numberArray[3]}|{numberArray[4]}|{numberArray[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{numberArray[6]}|{numberArray[7]}|{numberArray[8]}");
        }






 public static string getNextPlayer(string getCurrentPlayer){
    //player turn by taking curent the current player in play
    //if current player is = x then return o if not then return next player as x
    
    string next = "x";

    if (getCurrentPlayer == "x"){
        next = "o";
    }

    return next;
 }
static string IsWinner(string[] numberArray, int counter)
{
    // determine if game is over and who is winner 
       
    // if some one is winning declare winner
    string Winner = "x";
    for (int i = 0; i <= 1; i++)
    {

        if (numberArray[0] == Winner && numberArray[1] == Winner && numberArray[2] == Winner){
            return Winner;
        }
        else if (numberArray[3] == Winner && numberArray[4] == Winner && numberArray[5] == Winner){
            return Winner;
        }
        else if (numberArray[6] == Winner && numberArray[7] == Winner && numberArray[8] == Winner){
            return Winner;
        }
        else if (numberArray[0] == Winner && numberArray[3] == Winner && numberArray[6] == Winner){
            return Winner;    
        }
        else if (numberArray[1] == Winner && numberArray[4] == Winner && numberArray[7] == Winner){
            return Winner;
        }
        else if (numberArray[2] == Winner && numberArray[5] == Winner && numberArray[8] == Winner){
            return Winner;
        }
        else if (numberArray[0] == Winner && numberArray[4] == Winner && numberArray[8] == Winner){
            return Winner;
        }
        else if (numberArray[2] == Winner && numberArray[4] == Winner && numberArray[6] == Winner){
            return Winner;
        }
        else{ 
            Winner = "o";
            }
    }
    // else if the board is filled call a tie
    if (counter >= 9)
    {
        Winner = "tie";
    }
    else
    {
        Winner = "false";
    }
    // else game over is false
    
    return Winner;
}   
}
}



