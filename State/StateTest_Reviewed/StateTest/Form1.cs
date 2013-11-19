using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StateTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            textBoxATM.Text = _atm.Description;
        }

        public ATM _atm = new ATM();

        public string cardNumber { get { return textBoxCardNumber.Text; } }
        public string psw { get { return textBoxPsw.Text; } }

        private void buttonCardin_Click(object sender, EventArgs e)
        {
            _atm.CardIn(cardNumber);
            DisplayDescrition();
        }

        private void DisplayDescrition()
        {
            textBoxATM.Text += _atm.Description + "\r\n";
        }

        private void buttonInputpsw_Click(object sender, EventArgs e)
        {
            _atm.InputPsw(psw);
            DisplayDescrition();
        }

        private void cardout_Click(object sender, EventArgs e)
        {
            _atm.CardOut();
            DisplayDescrition();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            _atm.Withdraw();
            DisplayDescrition();
        }
    }
}
