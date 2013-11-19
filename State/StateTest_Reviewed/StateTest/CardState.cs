using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateTest
{
    public interface ICardState
    {
        ATM Atm { get; }

        CardState CardIn(string cardNumber);
        CardState InputPsw(string psw);
        CardState Withdraw();
        CardState CardOut();
    }

    public abstract class CardState : ICardState
    {
        public CardState(ATM atm)
        {
            this.Atm = atm;
        }
        public ATM Atm { get; private set; }

        public virtual CardState CardIn(string cardNumber)
        {
            return InvalidOperation();
        }

       
        public virtual CardState InputPsw(string psw)
        {
            return InvalidOperation();
        }

        public virtual CardState Withdraw()
        {
            return InvalidOperation();
        }

        public virtual CardState CardOut()
        {
            return InvalidOperation();
        }
        
        private CardState InvalidOperation()
        {
            Atm.Description = "Invalid operation";
            return this;
        }

    }

    public class StateCardIn : CardState
    {
        public StateCardIn(ATM atm) : base(atm) { }
        public override CardState InputPsw(string psw)
        {
            if (string.IsNullOrWhiteSpace(psw))
            {
                Atm.Description = "Your psw is invalid";
                return this;
            }
            Atm.Description = "Password is valid";
            return new StatePasswordInputed(Atm);
        }

        public override CardState CardOut()
        {
            Atm.Description = "Card out, hope to see you again";
            return new StateCardOut(Atm);
        }

        public override CardState Withdraw()
        {
            Atm.Description = "Please input password first.";
            return this;
        }
    }

    public class StatePasswordInputed : CardState
    {
        public StatePasswordInputed(ATM atm) : base(atm) { }

        public override CardState Withdraw()
        {
            Atm.Description = "You have withdraw 10$.";
            return this;
        }

        public override CardState CardOut()
        {
            Atm.Description = "Hope to see your again.";
            return new StateCardOut(Atm);
        }
    }

    public class StateCardOut : CardState
    {
        public StateCardOut(ATM atm) : base(atm) { }
        public override CardState CardIn(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber))
            {
                Atm.Description = "Card Number invalid";
                return this;
            }
            Atm.Description = "Welcome customer " + cardNumber + ", please input your password";
            return new StateCardIn(Atm);
        }
    }
}
