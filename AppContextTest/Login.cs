using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContextTest.appContext;

namespace AppContextTest
{
    public partial class Login : Form
    {
        AppAuthContext appAuthContext;
        public Login()
        {
            InitializeComponent();
            appAuthContext = new AppAuthContext(this);
            appAuthContext.start();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username = "test";
            String password = "12345";
            appAuthContext.authenticate(username, password);
        }

        public void setStateMessage(String stateMessage)
        {
            MethodInvoker methodInvokerDelegate = delegate ()
            { this.AppAuthStateMessage.Text = stateMessage; };

            //This will be true if Current thread is not UI thread.
            if (this.InvokeRequired)
                this.Invoke(methodInvokerDelegate);
            else
                methodInvokerDelegate();
        }
    }
}
