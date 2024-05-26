using System.Linq;
using System.Windows.Forms;

namespace Dictionary
{
    public static class FormChangesThread
    {
        public static Dictionary FormHome = Application.OpenForms.OfType<Dictionary>().FirstOrDefault();
        public static void changeText(string Text)
        {
            chTexts(Text);
        }
        private delegate void Text_Delegate();
        private static void chTexts(string Text)
        {
                if (FormHome.meaningBox.InvokeRequired)
                {
                    FormHome.meaningBox.Invoke(new Text_Delegate(() => chTexts(Text)), new object[] { });
                }
                else
                {
                    FormHome.meaningBox.Text = "";
                    FormHome.meaningBox.Text = Text;
                }
        }

        public static void NoConnection(string Text)
        {
            NoConn(Text);
        }
        private delegate void NoConnection_Delegate();
        private static void NoConn(string Text)
        {
            if(Text == "NoConnection")
            {
                if (FormHome.connectionLabel.InvokeRequired)
                {
                    FormHome.connectionLabel.Invoke(new NoConnection_Delegate(() => NoConn(Text)), new object[] { });
                }
                else
                {
                    FormHome.connectionLabel.Visible = true;
                }
            }
            else
            {
                if (FormHome.connectionLabel.InvokeRequired)
                {
                    FormHome.connectionLabel.Invoke(new NoConnection_Delegate(() => NoConn(Text)), new object[] { });
                }
                else
                {
                    FormHome.connectionLabel.Text = "Connection Restored!";
                    FormHome.connectionLabel.Visible = true;
                }
            }
            
        }
    }
}
