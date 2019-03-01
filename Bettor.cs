//Importing libraries

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BikeRace
{

    //Creating the Bettor class
    public class Bettor
    {
        private string _name;
        public static int maxBet;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _cash;

        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        private Bet _myBet;

        public Bet MyBet
        {
            get { return _myBet; }
            set { _myBet = value; }
        }

        private RadioButton _myRadioButton;

        public RadioButton MyRadioButton
        {
            get { return _myRadioButton; }
            set { _myRadioButton = value; }
        }

        private Label _myLabel;

        public Label MyLabel
        {
            get { return _myLabel; }
            set { _myLabel = value; }
        }

        public void UpdateLabels()
        {
            maxBet = this._cash;
            this._myRadioButton.Text = this._name + " has " + this._cash.ToString() + " bucks";
            this._myLabel.Text = this._myBet.GetDescription();
        }

        public void Collect(int winnerBike)
        {
            if (this._cash >= 0)
                this._cash += this._myBet.Payout(winnerBike);
        }

        public void ClearBet()
        {            
            this._myBet.Amount = 0;
            this._myRadioButton.Text = this._name + " has " + this._cash + " bucks";
            this._myLabel.Text = this._name + " hasn't placed a bet"; 
        }

        public bool PlaceBet(int amount, int bikeNumber)
        {
            if (amount <= this._cash)
            {
                this._myBet = new Bet() { Amount = amount, BikeNumber = bikeNumber, Bettor = this };
                UpdateLabels();
                return true;
            }   

            return false;
        }
    }
}
