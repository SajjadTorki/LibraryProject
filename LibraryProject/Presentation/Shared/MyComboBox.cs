

namespace System.Windows.Forms
{
    public class MyComboBox:ComboBox
    {
        public MyComboBox()
        {
            SelectedIndex = -1;
            ValueMember = "ID";
            DisplayMember = "Name";
        }
    }
}
