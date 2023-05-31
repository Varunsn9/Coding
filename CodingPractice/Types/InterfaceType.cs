using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Types
{
    internal class InterfaceType
    {
    }

    interface IControl
    {
        void paint();
    }
    interface ITextBox : IControl
    {
        void SetString(string text);
    }
    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }
    interface IComboBox : IControl, ITextBox, IListBox { }
    
    interface IDataBound
    {
        void Bind(Binder b);
    }
    public class EditBox : IDataBound, IControl
    {
        public void paint() { }
        public void Bind(Binder b) { }
    
        public static void main()
        {
            EditBox eb=new();
            IControl control = eb;
            IDataBound dataBound = eb;

        }
    }


}
