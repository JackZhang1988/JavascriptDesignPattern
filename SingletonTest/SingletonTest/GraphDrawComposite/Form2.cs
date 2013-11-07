using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphDrawComposite
{
    public partial class Form2 : Form
    {
        private static Form2 instance = null;
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new Form2();
            }
            return instance;
        }

    }
}
