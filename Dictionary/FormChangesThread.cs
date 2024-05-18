using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //if Device Connected
            /*if (color == "Connected")
            {
                if (FormConnect.connectButton1.InvokeRequired)
                {
                    FormConnect.connectButton1.Invoke(new Colors_Delegate(() => chColors(color)), new object[] { });
                }
                else
                {
                    FormConnect.connectButton1.BackColor = Color.Green;
                    //FormConnect.connectButton1.Enabled = false;
                    FormConnect.connectButton1.Text = "Connected";
                    FormConnect.connectButton1.ForeColor = Color.White;
                }

                if (FormConnect.portCombo1.InvokeRequired)
                {
                    FormConnect.portCombo1.Invoke(new Colors_Delegate(() => chColors(color)), new object[] { });
                }
                else
                {
                    FormConnect.portCombo1.Enabled = false;
                }
            }
            else //if device not connected or disconnected
            {
                if (FormConnect.connectButton1.InvokeRequired)
                {
                    FormConnect.connectButton1.Invoke(new Colors_Delegate(() => chColors(color)), new object[] { });
                }
                else
                {
                    FormConnect.connectButton1.BackColor = Color.Red;
                    FormConnect.connectButton1.ForeColor = Color.White;
                    FormConnect.connectButton1.Text = "Disconnected";
                }
            }*/



        }
    }
}
