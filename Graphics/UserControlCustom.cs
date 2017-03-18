using System.Windows.Forms;

namespace Tools4Libraries
{
    public delegate void UserControlCustomEventHandler(object o);
    public abstract class UserControlCustom : UserControl
    {
        public abstract event UserControlCustomEventHandler HeightChanged;
        public virtual void RefreshData()
        {

        }
        public virtual void ChangeLanguage()
        {

        }
    }
}
