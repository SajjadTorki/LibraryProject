using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class MyGridView : DataGridView
    {
        public MyGridView()
        {
            AutoGenerateColumns = false;
            BackgroundColor = Color.AliceBlue;
            RightToLeft = RightToLeft.Yes;
            GridColor = Color.BurlyWood;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
        }

        
    }
}
