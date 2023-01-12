using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Microsoft.Data.SqlClient;

namespace System
{
    public static class ErrorHandler
    {
        public static string GetError(Exception ex)
        {
            string errorMessage = "خطا";
            if (ex.GetType() == typeof(DivideByZeroException))
            {
                errorMessage = "خطای تقسیم بر صفر";
            }
            if (ex.GetType() == typeof(FormatException))
            {
                errorMessage = "خطای فرمت";
            }


            if (ex.InnerException!=null && ex.InnerException.GetType() == typeof(SqlException))
            {
                SqlException sqlError = ex.InnerException as SqlException;
                errorMessage = GetSqlServerErrorMessage(sqlError);
            }
            DataBase.Context.ChangeTracker.Clear();



            if (ex.GetType() == typeof(SqlException))
            {
                SqlException sqlError = ex as SqlException;
                errorMessage = GetSqlServerErrorMessage(sqlError);
            }
            if (ex.GetType() == typeof(AuthenticateException))
            {
                errorMessage = " کلمه کاربری یا رمز عبور اشتباست ";
            }
            if (ex.GetType() == typeof(AuthorizationException))
            {
                errorMessage = " شما به این قسمت ندارید ";
            }
            MyMessageBox.ValidationErrorMessage(errorMessage);
            return errorMessage;
        }

        private static string GetSqlServerErrorMessage(SqlException sqlError)
        {
            string errorMessage = "خطای پایگاه داده";
            if (sqlError.Number == 2627 || sqlError.Number == 2601)
            {
                errorMessage = "اطلاعات تکراری است";
            }
            if (sqlError.Number == 547)
            {
                errorMessage = " به دلیل اینکه اطلاعات در قسمت های دیگر استفاده شده است قابل حذف نیست ";
            }
            if (sqlError.Number == 4060 || sqlError.Number==233 || sqlError.Number==229)
            {
                errorMessage = " شما به داده دسترسی ندارید ";
            }
            return errorMessage;
        }
    }


    public class AuthenticateException : Exception
    {

    }
    public class AuthorizationException : Exception
    {

    }
}
