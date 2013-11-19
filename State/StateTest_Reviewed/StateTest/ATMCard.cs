using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateTest
{
    public class ATM
    {
        public ATM()
        {
            _cardState = new StateCardOut(this);
        }

        private CardState _cardState;

        public string Description { get; set; }

        public void CardIn(string cardNumber)
        {
            this._cardState = _cardState.CardIn(cardNumber);
        }

        public void InputPsw(string psw)
        {
            this._cardState = _cardState.InputPsw(psw);
        }

        public void Withdraw()
        {
            this._cardState = _cardState.Withdraw();
        }

        public void CardOut()
        {
            this._cardState = _cardState.CardOut();
        }
    }
}