using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;


namespace WindowsFormsApp1
{
    public partial class PhoneBook_Title : Form
    {
        
        static string path = @"C:\Users\tahaa\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\";
        static string selectedName;
        static string selectedLastN;
        static string selectedNumber;
        static bool isTurkish = false;

        public PhoneBook_Title()
        {
            InitializeComponent();
            if (File.Exists(path+"users.xml") == false)
            {
                XmlTextWriter createXML = new XmlTextWriter("users.xml", UTF8Encoding.UTF8);
                createXML.Close();
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInBttn_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(path+"users.xml", FileMode.Open);
            xd.Load(lfile);
            lfile.Close();

            XmlNodeList list = xd.GetElementsByTagName(encoder("user"));
            feedback.Text ="";
            for (int i = 0; i < list.Count; i++)
            {
                
                XmlElement user = (XmlElement)xd.GetElementsByTagName(encoder("user"))[i];

                if (user.GetAttribute(encoder("uName")) == encoder(uName.Text))
                {
                    if ((user.GetAttribute(encoder("password"))) == md5encoder(pass.Text))
                    {
                        feedback.Text = isTurkish ? "Doğru" : "Correct";
                        feedback.ForeColor = Color.Green;
                        feedback.Visible = true;
                        
                            login(encoder(uName.Text));
                        
                        
                        
                        break;
                    }
                    else
                    {
                        feedback.Text = isTurkish ? "Geçersiz şifre !" : "Invalid password !";
                        feedback.ForeColor = Color.Red;
                        feedback.Visible = true;
                        break;
                    }

                }
                else
                {
                    feedback.ForeColor = Color.Red;
                    feedback.Text = isTurkish ? "Geçersiz kullanıcı adı !" : "Invalid username !";
                    feedback.Visible = true;
                }
                



            }

            

            //XmlTextReader db = new XmlTextReader(path);

            //while (db.Read()) 
            //{
            //    if (db.NodeType == XmlNodeType.Element)
            //    {
            //        if(db.Name == "user")
            //        {
            //            if (db.GetAttribute("uName") == uName.Text && db.GetAttribute("password")==pass.Text)
            //            {
            //                login(uName.Text);
            //            }
            //        }
            //    }
            //}

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Size sz = new Size(600, 400);
            Image img = Image.FromFile(@"C:\Users\tahaa\Desktop\ilkProgram\koda.jpg");
            Bitmap image = new Bitmap(img, sz);
            BackgroundImage = image;
            
        }

        private void feedback_Click(object sender, EventArgs e)
        {

        }
        
        private void newUserBttn_Click(object sender, EventArgs e)
        {
            
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(path+"users.xml", FileMode.Open);
            xd.Load(lfile);
            lfile.Close();

            bool createNewUser = true;
            XmlNodeList list = xd.GetElementsByTagName(encoder("user"));
            for(int i=0; i<list.Count; i++)
            {
                XmlElement user = (XmlElement)xd.GetElementsByTagName(encoder("user"))[i];
                if (user.GetAttribute(encoder("uName")) == encoder(uName.Text))
                    createNewUser = false;
                
            }
            


            if (createNewUser)
            {
                XmlElement user_tag = xd.CreateElement(encoder("user"));
                user_tag.SetAttribute(encoder("uName"), encoder(uName.Text));
                user_tag.SetAttribute(encoder("password"), md5encoder(pass.Text));
                xd.DocumentElement.AppendChild(user_tag);
                xd.Save(path+"users.xml");
                

                XmlTextWriter createXML = new XmlTextWriter(encoder(uName.Text)+".xml", UTF8Encoding.UTF8);
                createXML.WriteStartDocument();
                createXML.WriteStartElement(encoder(uName.Text));
                createXML.WriteEndElement();
                createXML.Close();
                //XmlDocument xdoc = new XmlDocument();
                //FileStream fs = new FileStream(path + uName.Text + ".xml", FileMode.Open);
                
                //xdoc.Load(fs);
                //XmlElement root_tag = xdoc.CreateElement(uName.Text);
                //xdoc.DocumentElement.AppendChild(root_tag);
                //fs.Close();
                //xdoc.Save(path + uName.Text + ".xml");

                feedback.ForeColor = Color.Green;
                feedback.Text = isTurkish ? "Yeni Kullanıcı Oluşturuldu" : "Created New User";
                feedback.Visible = true;
            }
            else
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = isTurkish ? "Bu kullanıc ıadı kullanılıyor" : "This username has used already";
                feedback.Visible = true;
            }

            
            
        }

        private static String md5encoder(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] byt_array = Encoding.UTF8.GetBytes(password);
            byt_array = md5.ComputeHash(byt_array);

            StringBuilder sb = new StringBuilder();

            foreach(byte ba in byt_array)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            return sb.ToString();
        }

        public static string encoder(string txt)
        {
            string temp_txt = "";
            foreach (char c in txt)
            {
                if (c == ' ' || c == '<' || c == '/' || c == '>' || c == '\n' || c == '\t' ||
                    c=='@' || c=='[' || c==']' || c == '\"' || c == '\'' || c == '=' || c == '\r' || c == '?')
                    temp_txt += (char)c;
                else if (c == 'z')
                    temp_txt += "a";
                else if (c == 'Z')
                    temp_txt += "A";
                else
                    temp_txt += (char)(c + 1);

            }
            return temp_txt;
        }

        private static string decoder(string txt)
        {
            string temp_txt = "";
            foreach (char c in txt)
            {
                if (c == ' ' || c == '<' || c == '/' || c == '>' || c == '\n' || c == '\t' ||
                    c == '@' || c == '[' || c == ']' || c == '\"' || c == '\'' || c == '=' || c == '\r' || c == '?')
                    temp_txt += (char)c;
                else if (c == 'a')
                    temp_txt += "z";
                else if (c == 'A')
                    temp_txt += "Z";
                else
                    temp_txt += (char)(c - 1);

            }
            return temp_txt;
        }

        private static FileStream decoderToStream(string pth)
        {
            
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(pth, FileMode.Open);
            FileStream fs_temp = new FileStream("list", FileMode.Open);
            xd.Load(fs);
            fs.Close();
            AddText(fs_temp, "<?xml version=\"1.0\" encoding=\"utf - 8\"?>\n");
            for (int i = 38; i < xd.OuterXml.Length; i++)
            {
                
                char c = xd.OuterXml[i];
                if (c == ' ' || c == '<' || c == '/' || c == '>' || c == '\n' || c == '\t' ||
                    c == '@' || c == '[' || c == ']' || c == '\"' || c=='\'' || c == '=' || c=='\r' || c=='?' )
                    AddText(fs_temp, c.ToString()); 
                else if (c == 'a')
                    AddText(fs_temp, "z");
                else if (c == 'A')
                    AddText(fs_temp, "Z");
                else if (c == '>')
                    AddText(fs_temp, ">\n\r");
                else
                    AddText(fs_temp, (((char)(c - 1)).ToString()).ToString());

            }
            
            fs_temp.Close();
            return fs_temp;
            
        }


        private static void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
        

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addB_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(@path+encoder(uName.Text)+".xml",FileMode.Open);
            xd.Load(fs);                                                            //   attention !
            fs.Close();                                                                 //  (note myself)
            XmlElement person_tag = xd.CreateElement(encoder("person"));
            person_tag.SetAttribute(encoder("name"), encoder(name_textbox.Text));
            person_tag.SetAttribute(encoder("sName"), encoder(lastN_texbox.Text));
            person_tag.SetAttribute(encoder("number"), encoder(number_textbox.Text));
            xd.DocumentElement.AppendChild(person_tag);
            xd.Save(path + encoder(uName.Text) + ".xml");
            
            name_textbox.Clear();
            lastN_texbox.Clear();
            number_textbox.Clear();

            Listing();
        }

        public void Listing()
        {

            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(path + encoder(uName.Text) + ".xml", FileMode.Open);
            xd.Load(fs);
            fs.Close();

            book.Rows.Clear();
            book.Refresh();
            
            for(int i =0; i<xd.GetElementsByTagName(encoder("person")).Count; i++)
            {
                XmlElement person = (XmlElement) xd.GetElementsByTagName(encoder("person"))[i];
                string[] row = new string[] { decoder(person.GetAttribute(encoder("name"))), decoder(person.GetAttribute(encoder("sName"))), decoder(person.GetAttribute(encoder("number"))) };
                book.Rows.Add(row);
            }
            




        }

        private void logInBttn_KeyDown(object sender, KeyEventArgs e)
        {
            

            if (e.KeyData == Keys.Enter)
                logInBttn.PerformClick();
        }

        public void login(string uname)
        {
            loginPanel.Visible=false;
            bookPanel.Visible = true;
            book.Visible = true;
            selected_panel.Visible = true;
            edit_panel.Visible = true;
            Listing();
        }

        public void logout()
        {
            loginPanel.Visible = true;
            bookPanel.Visible = false;
            book.Visible = false;
            selected_panel.Visible = false;
            edit_panel.Visible = false;
            book.DataSource = null;

        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            XmlDocument xd = new XmlDocument();
            FileStream fs = new FileStream(path + encoder(uName.Text) + ".xml", FileMode.Open);
            xd.Load(fs);
            fs.Close();
            XmlNode xmlNode = xd.SelectSingleNode(encoder("/" + uName.Text +
                "/person[@name='" + selectedName +
                "'") + " and " + encoder("@sName='" + selectedLastN +
                "'") + " and " + encoder("@number='" + selectedNumber + "']"));
            try
            {
                xmlNode.ParentNode.RemoveChild(xmlNode);
            }
            catch
            {
                label1.Text = isTurkish ? "Bir kişi seçiniz !" : "Please choose a person !";
                label1.Visible = true;
            }
            selected_name.Text = isTurkish ? "(isim)" : "(name)";
            selected_lastN.Text = isTurkish ? "(soyisim)" : "(lastname)";
            selected_number.Text = isTurkish ? "(numara)" : "(number)";
            xd.Save(path + encoder(uName.Text) + ".xml");
            Listing();
            
        }

        private void book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //selected_name.Font.Italic = false;

            selected_name.Text = book.SelectedRows[0].Cells[0].Value.ToString();
            selectedName = selected_name.Text;

            selected_lastN.Text = book.SelectedRows[0].Cells[1].Value.ToString();
            selectedLastN = selected_lastN.Text;

            selected_number.Text = book.SelectedRows[0].Cells[2].Value.ToString();
            selectedNumber = selected_number.Text;
        }

        private void edit_bttn_Click(object sender, EventArgs e)
        {
            
            if(!(selected_name.Text == "(isim)" || selected_name.Text == "(name)"))
            {
                XmlDocument xd = new XmlDocument();
                FileStream fs = new FileStream(path + encoder(uName.Text) + ".xml", FileMode.Open);
                xd.Load(fs);
                fs.Close();
                XmlNode xmlNode = xd.SelectSingleNode(encoder("/" + uName.Text + 
                "/person[@name='" + selectedName + 
                "'")+ " and " + encoder("@sName='"+selectedLastN +
                "'") + " and " + encoder("@number='"+selectedNumber + "']"));            
                //label1.Text = xmlNode.Value;
                xmlNode.Attributes[0].InnerText = encoder(selected_name.Text);
                xmlNode.Attributes[1].InnerText = encoder(selected_lastN.Text);
                xmlNode.Attributes[2].InnerText = encoder(selected_number.Text);
                //label1.Text = isTurkish ? "Bir kişi seçiniz !" : "Please choose a person !";
               
                xd.Save(path + encoder(uName.Text) + ".xml");
                selected_name.Text = isTurkish ? "(isim)" : "(name)";
                selected_lastN.Text = isTurkish ? "(soyisim)" : "(lastname)";
                selected_number.Text = isTurkish ? "(numara)" : "(number)";
                Listing();
            }

            
            

        }

        private void logoutbttn_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void turkish_menu_bttn_Click(object sender, EventArgs e)
        {
            isTurkish = true;
            turkish_menu_bttn.BackColor = Color.FromArgb(206, 225, 255);
            english_menu_bttn.BackColor= System.Drawing.SystemColors.Control;
            refleshLanguage();
           
        }

        private void english_menu_bttn_Click(object sender, EventArgs e)
        {
            isTurkish = false;
            english_menu_bttn.BackColor = Color.FromArgb(206, 225, 255);
            turkish_menu_bttn.BackColor = System.Drawing.SystemColors.Control;
            refleshLanguage();
        }

        private void refleshLanguage()
        {
            if (isTurkish)
            {
                language_MenuItem.Text = "Dil";
                about_MenuItem.Text = "Hakkında";
                developerToolStripMenuItem.Text = "Geliştirici";
                kulAd.Text = "Kullanıcı Adı:";
                sifre.Text = "Şifre :";
                newUserBttn.Text = "Yeni Kullanıcı";
                logInBttn.Text = "Giriş";
                logoutbttn.Text = "Çıkış";
                namLabel.Text = "İsim";
                lnamLabel.Text = "Soyisim";
                numLabel.Text = "Numara";
                selected_name.Text = "(isim)";
                selected_lastN.Text = "(soyisim)";
                selected_number.Text = "(numara)";
                add_bttn.Text = "Ekle";
                edit_bttn.Text = "Düzenle";
                delete_bttn.Text = "Sil";
            }
            else
            {
                language_MenuItem.Text = "Language";
                about_MenuItem.Text = "About";
                developerToolStripMenuItem.Text = "Developer";
                kulAd.Text = "User Name :";
                sifre.Text = "Password :";
                newUserBttn.Text = "New User";
                logInBttn.Text = "Login";
                logoutbttn.Text = "Logout";
                namLabel.Text = "Name";
                lnamLabel.Text = "Last Name";
                numLabel.Text = "Number";
                selected_name.Text = "(name)";
                selected_lastN.Text = "(lastname)";
                selected_number.Text = "(number)";
                add_bttn.Text = "Add";
                edit_bttn.Text = "Edit";
                delete_bttn.Text = "Delete";
            }
        }

        
    }

    
}
