using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuyMore.controllers;
using BuyMore.tools;
namespace BuyMore
{
    public partial class Utilisateur : Form
    {
        String id_ = null,old_userName;
        public Utilisateur()
        {
            InitializeComponent();
            UtilisateurC.showUser(userTable);
            main.currentPage = "utilisateur";
            main.currentTable = userTable;
            if (main.poste == "caissier")
            {
                save_u.Enabled = false;
                Suprimer_u.Enabled = false;
            }
            UtilisateurC.showUser(userTable);
            if (main.poste == "gestionnaire de stock")
            {
                save_u.Enabled = false;
                Suprimer_u.Enabled = false;
            }
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearFields()
        {
          // nom_u.Text = "";
           //id_employer.Text = "";
           username_u.Text = "";
           password.Text = "";
           password_conf_u.Text = "";
        }

        private void Save_u_Click(object sender, EventArgs e)
        {
            string nom, prenom, username, passwd, passwd_conf,code_employer;
            code_employer = id_employer.Text;
            username = username_u.Text;
            //String hash = hashMe.HASH_SHA1(code_employer);
            
            int ifCodeEmployerExiste = UtilisateurC.ifCodeEmployerExiste(code_employer);
            int ifUserNameExist = UtilisateurC.ifUserEmployerExiste(username);
            if (ifCodeEmployerExiste==0)
            {
                if(ifUserNameExist==0)
                {
                    try
                    {
                        nom = Employer_C.getNameAndFirstnameById(code_employer)[0].ToString();
                        prenom = Employer_C.getNameAndFirstnameById(code_employer)[1].ToString();
                        //username = username_u.Text;
                        passwd = hashMe.HASH_SHA1(password.Text);
                        passwd_conf = hashMe.HASH_SHA1(password_conf_u.Text);
                        if (passwd.Equals(passwd_conf))
                        {
                            int rep = UtilisateurC.saveUser(nom, prenom, username, passwd, code_employer, userTable);
                            if (rep == 0)
                            {
                                clearFields();
                                
                                MessageBox.Show("Utilisateur enregistrer avec succes");
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de l'enregistrement");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Entrer le meme mot de passe dans les deux champs");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Cet employer n'existe pas");
                    }
                }
                else
                {
                    MessageBox.Show("deja pris");
                }
            }
            else
            {
                MessageBox.Show("Cet utilisateur existe deja dans la base se donnee");
            }
            
            
            
            
        }

        private void Refresh_u_Click(object sender, EventArgs e)
        {
            UtilisateurC.showUser(userTable);
        }
        private void modify(String user)
        {
            string nom, prenom, username, passwd, passwd_conf, code_employer;
            username = user;
            passwd = hashMe.HASH_SHA1(password.Text);
            passwd_conf = hashMe.HASH_SHA1(password_conf_u.Text);
            if (passwd.Equals(passwd_conf))
            {
                int rep = UtilisateurC.modifyUser(username, passwd, userTable, id_);
                if (rep == 0)
                {
                    MessageBox.Show("Utilisateur modifier avec succes");
                    main.userName = username;
                    UtilisateurC.showUser(userTable);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification");
                }
            }
            else
            {
                MessageBox.Show("Entrer le meme mot de passe dans les deux champs");
            }

        }
        private void Modifier_u_Click(object sender, EventArgs e)
        {
            string nom, prenom, username, passwd, passwd_conf, code_employer;
            username = username_u.Text;
            
            int ifUserNameExist = UtilisateurC.ifUserEmployerExiste(username);
            if (ifUserNameExist==0)
            {
                modify(username);
            }
            else
            {
                if(username.Equals(old_userName))
                {
                    modify(username);
                }else
                {
                    MessageBox.Show("Ce nom d'utilisateur est deja pris");
                }
            }
        }

        private void UserTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_ = userTable.CurrentRow.Cells["id"].Value.ToString();
            //nom_u.Text = userTable.CurrentRow.Cells["nom"].Value.ToString();
            //id_employer.Text = userTable.CurrentRow.Cells["prenom"].Value.ToString();
            username_u.Text = userTable.CurrentRow.Cells["usernameT"].Value.ToString();
            old_userName = userTable.CurrentRow.Cells["usernameT"].Value.ToString();
            password.Text = userTable.CurrentRow.Cells["passwdT"].Value.ToString();
            password_conf_u.Text = userTable.CurrentRow.Cells["passwdT"].Value.ToString();
        }

        private void Suprimer_u_Click(object sender, EventArgs e)
        {
            int rep = UtilisateurC.deleteUser(userTable, id_);
            MessageBox.Show(id_.ToString());
            if (rep == 0)
            {
                MessageBox.Show("Utilisateur suprimer avec succes");
                clearFields();
            }
            else
            {
                MessageBox.Show("Erreur lors de la supression");
            }
        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files(*.*)|*.*|Image File (*.png)|*.png|Image File (*.jpg)|*.jpg)";
            dialog.ShowDialog();
            MessageBox.Show(dialog.FileName.ToString());
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {

        }
    }
}
