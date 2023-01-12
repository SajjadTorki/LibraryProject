using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public static class MyMessageBox
    {
        public static void SuccessMessage(string Msg= "عملیات با موفقیت انجام شد")
        {
            MessageBox.Show(Msg, "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ValidationErrorMessage(string Msg = "اطلاعات کامل وارد نشده است")
        {
            MessageBox.Show(Msg, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SelectionErrorMessage(string Msg = "لطفا موردی را لز لیست انتخاب کنید")
        {
            MessageBox.Show(Msg, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool ConfirmedMessage()
        {
            var result = MessageBox.Show("آیا عملیات انجام شود", "سوال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return false;
            }

            return true;
        }
    }
}
