using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactsBook_Gavrylchenko
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            DialogResult res = authorization.ShowDialog();
            if (res == DialogResult.OK)
            {
                string login = authorization.Login;
                string passw = authorization.Password;
                string path = @"..\..\accounts.xml";
                XDocument doc = XDocument.Load(path);
                var select1 = from x in doc.Element("root").Elements("account")
                              where x.Attribute("name").Value == login &&
                                    x.Attribute("password").Value == passw
                              select x;
                int k = select1.Count();
                if (k == 0)
                {
                    MessageBox.Show("Авторизация не пройдена");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Добро пожаловать");
                }
            }
        }
    }
}
