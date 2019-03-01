//Importing libraries

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BikeRace{

	//Creating the Bet class

    public class Bet
    {
        private int _amount;

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private int _bikeNumber;

        public int BikeNumber
        {
            get { return _bikeNumber; }
            set { _bikeNumber = value; }
        }

        private Bettor _bettor;

        public Bettor Bettor
        {
            get { return _bettor; }
            set { _bettor = value; }
        }

        public string GetDescription()
        {
            if (this._amount == 0)
                return this._bettor.Name + " hasn't placed any bet";
                return this._bettor.Name + " placed " + this._bettor.MyBet._amount.ToString() + " bucks on bike # " + this._bettor.MyBet.BikeNumber.ToString();
        }

        public int Payout(int winningBikeNumber)
        {
            if (this._bettor.MyBet.BikeNumber == winningBikeNumber)
                return this._amount;
            else
                return -this._amount;
        }
    }
}
