using BuyMore.controllers;
using BuyMore.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyMore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void login_()
        {
            String user, passwd;
            user = username.Text;
            passwd = hashMe.HASH_SHA1(password.Text);
           
            int rep = UtilisateurC.login(user, passwd);
            if (rep == 0)
            {
                Dispose();
                string year, month, day, date_x,heure,minute;
                year = DateTime.Now.Year.ToString();
                month = DateTime.Now.Month.ToString();
                day = DateTime.Now.Day.ToString();
                date_x = year + "/" + month + "/" + day;
                heure = DateTime.Now.Hour.ToString()+":"+ DateTime.Now.Minute.ToString();
                
                List<string> list = new List<string>();
                list = LogC.getInfoByUserName(user);
                LogC.saveLog(list[0].ToString(), list[1].ToString(), list[2].ToString(), user, date_x, heure);
                //MessageBox.Show(list[1].ToString());
                //main.Welcome.Visible = true;
                main.the_name.Visible = true;
                main.userName = user;
                main.connect_.Visible = false;
                main.disconect.Visible = true;
            }
            
            else
            {
                MessageBox.Show("le mot de passe ou le nom d'utilisateur est incorrect");
            }
        }
        private void Connecte_Click(object sender, EventArgs e)
        {
            login_();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            main.connect_.Enabled = true;
            Dispose();
        }
    }
}
