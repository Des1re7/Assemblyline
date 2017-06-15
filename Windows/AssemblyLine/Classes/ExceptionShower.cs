using System;

namespace AssemblyLine.Classes
{
    class ExceptionShower
    {
        public static void ShowMsgBox(Exception ex)
        {
            System.Windows.Forms.MessageBox.Show("Неопознаная ошибка!\nПередайте информацию об ошибке разработчику:\n" + ex.StackTrace, "Ошибка!",
                System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
