using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsWallet
{
    const int BASE10 = 1;
    const int BASE20 = 2;
    const int BASE30 = 3;
    const int DEFAULTBALANCE = 100;
    const int DEFAULTBET = 10;

    private int currentBalance;
    private int currentBet;
    private int numberOfTime;
    private int maxRandom;
    private int currentComputerNumber;

    /// <summary>
    /// To set defualt balance,bet and game type
    /// </summary>
    /// <param name="gameType">
    /// number that determine game type</param>
    public clsWallet (int gameType)
    {
        currentBalance = DEFAULTBALANCE;
        currentBet = DEFAULTBET;
        SetWallet(gameType);
    }

    public int CurrentBalance
    {
        get
        {
            return currentBalance;
        }
    }

    public int CurrentBet
    {
        get
        {
            return currentBet;
        }
        set
        {
            if (value > 0)
            {
                currentBet = value;
            }
        }
    }

    public int NumberOfTime
    {
        get
        {
            return numberOfTime;
        }
    }

    public int CurrentComputerNumber
    {
        get
        {
            return currentComputerNumber;
        }
    }

    /// <summary>
    /// Initial game by set number of time to bet and range of random
    /// </summary>
    /// <param name="gameType">
    /// </param>
    public void SetWallet(int gameType)
    {
        if (gameType == 1)
        {
            numberOfTime = 2;
            maxRandom = 10;
        }
        else if (gameType == 2)
        {
            numberOfTime = 3;
            maxRandom = 20;
        }
        else
        {
            numberOfTime = 4;
            maxRandom = 30;
        }
    }

    /// <summary>
    /// To reset number of time while playing game
    /// </summary>
    /// <param name="gameType">
    /// number that determine game type
    /// </param>

    public void ResetTime(int gameType)
    {
        if (gameType == 1)
        {
            numberOfTime = 2;
        }
        else if (gameType == 2)
        {
            numberOfTime = 3;
        }
        else
        {
            numberOfTime = 4;
        }
    }
    /// <summary>
    /// To adjust balance up on result
    /// </summary>
    /// <param name="result">
    /// result from compare method
    /// number that determine game type
    /// </param>
    private void AdjustBalance(bool result)
    {
        if (result == true)
        {
            currentBalance += currentBet;
        }
        else
        {
            currentBalance -= currentBet;
        }
    }

    /// <summary>
    /// Random number in range to compare to player
    /// </summary>
    public void ComputerRandom()
    {
        Random comRandom = new Random();
        currentComputerNumber = comRandom.Next(maxRandom) + 1;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="number">
    /// number that player guess
    /// </param>
    /// <param name="textClue">
    /// text that give clue to playaer
    /// </param>
    /// <returns> bool true if match otherwise false </returns>
    public bool CompareToComputer(int number,out string textClue)
    {
        numberOfTime--;
        if (currentComputerNumber == number)    //case win
        {
            textClue = "คุณทายถูกต้อง";
            AdjustBalance(true);
            return true;
        }
        else
        {
            if (numberOfTime == 0)  //case lose
            {
                textClue = "คุณหมดสิทธิ์ทาย";
                AdjustBalance(false);
            }
            else if (number > currentComputerNumber)    // doesn't match
            {
                textClue = "คุณทายสูงเกินไป";
            }
            else
            {
                textClue = "คุณทายต่ำเกินไป";
            }
            return false;
        }
    }
}
