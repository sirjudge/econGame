using System;
using System.Collections.Generic;
using econGameOfChamps;

namespace econGameOfChamps
{
    public class econGameMaster
    {

        List<Player> playerList = new List<Player>();

        public econGameMaster()
        {
            Console.WriteLine("I am the game master");
        }

        public void addPlayerToList(Player p)
        {
            playerList.Add(p);
        }

    }

    public class Item
    {
        string name;
        string description;
        double value = 0.00;
        bool isKeyItem = false;

        public Item(string n, string d, double v, bool isKey)
        {
            name = n;
            description = d;
            value = v;
            isKeyItem = isKey;
        }

        public string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }
        public double getValue()
        {
            return value;
        }
        public bool isThisKeyItem()
        {
            return isKeyItem;
        }
        public void setName(string n)
        {
            name = n;
        }
        public void setDescription(string d)
        {
            description = d;
        }
        public void setValue(double v)
        {
            value = v;
        }
        public void setIsKeyItem(bool b)
        {
            isKeyItem = b;
        }
    }

    public class Trade
    {

        private Player p1;
        private Player p2;

        double p1TradeMoney = 0.00; //amount to give to player 2
        double p2TradeMoney = 0.00; // amount to give to player 1

        // both parties must agree to the trade before trade can commence
        bool p1Agree = false;
        bool p2Agree = false;

        public Trade(Player pl1, Player pl2, double p1Money, double p2Money)
        {
            p1 = pl1;
            p2 = pl2;
            p1TradeMoney = p1Money;
            p2TradeMoney = p2Money;
        }

        public void p1Confirm()
        {
            p1Agree = true;
        }
        public void p2Confirmt()
        {
            p2Agree = true;
        }

        public void doTrade()
        {
            if (p1Agree && p2Agree)
            {
                p1.addMoney(p2TradeMoney);
                p2.addMoney(p1.TotalMoney);
            }
            else
            {
                Console.WriteLine("both players have not confirmed");
            }
        }

    }


    public class Player
    {

        private int playerID;
        private string name;
        private string team;
        private double totalMoney = 5000;


        public Player(int pid, string n, string t)
        {
            this.playerID = pid;
            this.name = n;
            this.Team = t;
        }

        // getters & setters
        public string Team { get => team; set => team = value; }
        public string Name { get => name; set => name = value; }
        public int PlayerID { get => playerID; set => playerID = value; }
        public double TotalMoney { get => totalMoney; set => totalMoney = value; }

        public void subtractMoney(double amountToSubtract)
        {
            this.totalMoney = this.totalMoney - amountToSubtract;
        }

        public void addMoney(double amountToSubtract)
        {
            this.totalMoney = this.totalMoney + amountToSubtract;
        }


        // p1 gives money to p2
        public void giveMoney(Player p1, Player p2, double moneyToPlayer2)
        {
            Trade T = new Trade(p1, p2, moneyToPlayer2, 0.00);
        }

    }
}