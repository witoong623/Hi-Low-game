using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsWallet
{
    //========== constant member ==========
    const int BASE10 = 1;
    const int BASE20 = 2;
    const int BASE30 = 3;
    const int DEFAULTBALANCE = 100;
    const int DEFAULTBET = 10;

    //========== instant member ==========
    private int currentBalance;
    private int currentBet;
    private int numberOfTime;
    private int maxRandom;
    private int currentComputerNumber;

    //========== constuctor ==========
    #region constuctor
    public clsWallet (int gameType)
    {
        currentBalance = DEFAULTBALANCE;
        currentBet = DEFAULTBET;
        SetWallet(gameType);
    }
    #endregion constuctor

    #region property method
    //========== property method ==========
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
    #endregion property method

    #region helper method
    //========= helper method ==========
    /***
     * purpose : set max random number and number that can bet
     * parameter :
     *      int gameType
     * return
     *      void
     ***/
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
        else if (gameType == 3)
        {
            numberOfTime = 4;
            maxRandom = 30;
        }
    }

    /***
     * purpose : adjust money in wallet depend on win or lose
     * parameter :
     *      bool    result
     * return
     *      void
     ***/
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

    #endregion helper method

    #region general method
    //========== general method ==========
    /***
     * purpose : random new number
     * parameter :
     *      N/A
     * return :
     *      void
     ***/
    public void ComputerRandom()
    {
        Random comRandom = new Random();
        currentComputerNumber = comRandom.Next(maxRandom) + 1;
    }

    /***
     * purpose : use to compare between com and player
     * parameter :
     *      int number //number that player pass
     *      string  textClue    //text to tell player if more or less
     * return :
     *      bool true = win false = lose
     *      string textClue
     * CUATION : this method use address of textClue
     ***/
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
    #endregion
}
