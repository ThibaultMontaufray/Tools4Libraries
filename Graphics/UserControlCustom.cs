using System.Windows.Forms;

namespace Tools4Libraries
{
    public delegate void UserControlCustomEventHandler(object o);
    public class UserControlCustom : UserControl
    {
        public virtual event UserControlCustomEventHandler HeightChanged;
        public virtual void RefreshData()
        {

        }
        public virtual void ChangeLanguage()
        {

        }
    }
}
