using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.IO;

namespace TweetManager
{
    public partial class form_manager : MetroFramework.Forms.MetroForm
    {
        enum LANGUAGE
        {
            TURKISH,
            ENGLISH
        }

        // Will get these datas from an XML file once we have enough language support. For now, since it only contains
        // really simple sentences, I'll put all these down to an array.

        private string[] ENG_LANG = { "Divide",
                               "Let this app divide your long paragraphs into tweets less than 140 characters which you can post one by one with copying. Or you can simply let this app post them for you!" ,
                               "Enter your tweet here",
                               "Total char count is ", ". All text divided into "," pieces of tweet.",
                               "Copy",
                                "Welcome! We hope you are doing fine!. \n You need to give required permissions to this app for posting tweets for you. If this is your choice, please simply click related button!\n However you might want to copy divided tweets manually. In this case app won't ask any permissions on your account.",
                                 "Continue without Login", "Continue with Login", "Please enter the PIN which directed Twitter Page provide to you","Login", "Post",
                                "Something went terribly wrong! Don't worry, we can fix it. Ehh... I hope. Please try again.", "Uh.. Okay.."},
                
                TURK_LANG = { "Ayır",
                              "Bırakın bu uygulama sizin için uzun paragraflarınızı 140 karakterin altında tweetlere bölsün! Veya sizin yerinize böldüğü tweetleri yollamasını da sağlayabilirsiniz!",
                              "Tweetinizi buraya girin",
                              "Toplam karakter sayısı ",". Tüm yazı ", " tane tweete bölündü.",
                              "Kopyala",
                              "Merhaba! Umarım iyisindir.\n Uygulamanın senin adına tweet atabilmesi için Twitterına erişmesine izin vermelisin. \nEğer tercihin bu yöndeyse lütfen aşağıdaki ilgili butona tıkla!\nVeya bölünmüş tweetleri kendin de kopyalayıp gönderebilirsin. Bu yolu seçersen uygulama hiçbir izin istemeyecektir.",
                              "Giriş Yapmadan Devam Et", "Giriş Yaparak Devam Et", "Yönlendirildiğiniz sitede size verilen PIN'i giriniz.","Giriş", "Yayınla",
                              "Bir şey çok yanlış gitti! Ama merak etme, bunu çözebiliriz... Ehh.. Umarım yani. Lütfen tekrar dene.", "Uhh.. Peki.."} ;


        private LANGUAGE LANGUAGE_SELECTION = LANGUAGE.ENGLISH;
        private TweetManager.Codes.Twitter_Side.TwitterAuth authObject;
        private List<string> userTweetList;
        private bool firstStart;

        public form_manager()
        {
            firstStart = false;
            // Our Auth object. This is required for entering.
            authObject = new Codes.Twitter_Side.TwitterAuth();

            InitializeComponent();
            InitialChecks();
            InitialBootCheck();
           
        }

        // Copy tweet to the clipboard. Saves a lot of time.
        private void Copy_Clipboard (object sender, EventArgs e, TextBox itsTextBox)
        {
            Clipboard.Clear();
            Clipboard.SetText((itsTextBox).Text);
        }


        private void InitialChecks() {
            // Initialization work. Lets set default language first.
            this.loginpanel.Hide();
            this.errorPanel.Hide();
            this.start_button.Text = ENG_LANG[0];
            this.metroTextBox1.Text = ENG_LANG[1];
            this.metroLabel1.Text = ENG_LANG[2];
            this.userDataInfo.Text = ENG_LANG[3] + "0" + ENG_LANG[4] + "0" + ENG_LANG[5];
            this.welcomeLabel.Text = ENG_LANG[7];
            this.dontButton.Text = ENG_LANG[8];
            this.pinButton.Text = ENG_LANG[9];
            this.loginLabel.Text = ENG_LANG[10];
            this.loginButton.Text = ENG_LANG[11];
            this.postButton.Text = ENG_LANG[12];
            this.errorText.Text = ENG_LANG[13];
            this.errorButton.Text = ENG_LANG[14];

            // Lets assign job to our language buttons. For now, 1 == ENGLISH, 0 == TURKISH
            langEng.Click += (sender, EventArgs) => { Change_Language(sender, EventArgs, 1); };
            langTurk.Click += (sender, EventArgs) => { Change_Language(sender, EventArgs, 0); }; 
        }

        private void InitialBootCheck () {
            // Lets first check whether we have folder or not. If not, lets create one.

            string AppData = Environment.ExpandEnvironmentVariables("%AppData%");
            
            string path = AppData + "/TweetManager";
            try
            {
                if (!System.IO.Directory.Exists(path))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    firstStart = true;
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine(ioex.Message);
            }

            if (!firstStart)
            {
                string initPath = path + "/user.ini";

                // If we have that file, lets read its content and skip the welcome screen.
                if (File.Exists(initPath))
                {
                    int counter = 0;
                    string line;
                    string SECRET = "", TOKEN = "";
                    // Read the file and display it line by line.
                    System.IO.StreamReader file =
                       new System.IO.StreamReader(initPath);

                    // There should be 2 line, but anyway...
                    while ((line = file.ReadLine()) != null)
                    {
                        if (counter == 0) // First line
                            TOKEN = line;
                        else if (counter == 1)
                            SECRET = line;

                        counter++;
                    }

                    file.Close();

                    bool response = false;
                    if (SECRET != "" && TOKEN != "")
                        response = authObject.SetAuthWithCredentials(SECRET, TOKEN);

                    if (response)
                    {
                        welcomePanel.Dispose();
                    }
                    else
                    {
                        // We have file but its corrupted? Delete it. We don't want anymore trouble.
                        System.IO.File.Delete(initPath);
                        this.errorPanel.Show();
                    }

                }

            }
        }

        // Language settings.
        private void Change_Language(object sender, EventArgs e, int selection)
        {
            if (selection == 0) { // Which is Turkish
                LANGUAGE_SELECTION = LANGUAGE.TURKISH;
                this.start_button.Text = TURK_LANG[0];
                this.metroTextBox1.Text = TURK_LANG[1];
                this.metroLabel1.Text = TURK_LANG[2];
                this.userDataInfo.Text = TURK_LANG[3] + "0" + TURK_LANG[4] + "0" + TURK_LANG[5];
                this.welcomeLabel.Text = TURK_LANG[7];

                this.dontButton.Text = TURK_LANG[8];
                this.pinButton.Text = TURK_LANG[9];
                this.loginLabel.Text = TURK_LANG[10];
                this.loginButton.Text = TURK_LANG[11];
                this.postButton.Text = TURK_LANG[12];
                this.errorText.Text = TURK_LANG[13];
                this.errorButton.Text = TURK_LANG[14];
            }
            else if (selection == 1){ // Which is English
                LANGUAGE_SELECTION = LANGUAGE.ENGLISH;
                this.start_button.Text = ENG_LANG[0];
                this.metroTextBox1.Text = ENG_LANG[1];
                this.metroLabel1.Text = ENG_LANG[2];
                this.userDataInfo.Text = ENG_LANG[3] + "0" + ENG_LANG[4] + "0" + ENG_LANG[5];
                this.welcomeLabel.Text = ENG_LANG[7];

                this.dontButton.Text = ENG_LANG[8];
                this.pinButton.Text = ENG_LANG[9];
                this.loginLabel.Text = ENG_LANG[10];
                this.loginButton.Text = ENG_LANG[11];
                this.postButton.Text = ENG_LANG[12];
                this.errorText.Text = ENG_LANG[13];
                this.errorButton.Text = ENG_LANG[14];
            }
            // Once we change the language, lets remove everything.
            ResetEverything();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            CreateTweets(userTweetBox.Text); // User input given, lets start our procedure.
        }

        // Needed for cleanup. NOT WORKING PROPERLY...
        private void ResetEverything()
        {
            ResetPanel();
            userTweetBox.Text = "";
        }

        // For retry, we need to reset panel. This is also useful for resetting everything.
        private void ResetPanel() {
            foreach (Control ctrl in TweetShowPanel.Controls ) {
                if (ctrl is MetroPanel)
                    TweetShowPanel.Controls.Remove(ctrl);
                
            }
        }

        private void pinButton_Click(object sender, EventArgs e)
        {
            loginpanel.Show();
            authObject.StartAuthProcess();
        }

        private void dontButton_Click(object sender, EventArgs e)
        {
           welcomePanel.Dispose();
            postButton.Enabled = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userPin = pinBoxInput.Text;
            if (userPin != null || userPin != "")
            {
                // Means that we dont have any user data anyway. Hence, we now need to write down them.
                bool result  = authObject.SetAuth(userPin);

                if (result)
                {

                    string AppData = Environment.ExpandEnvironmentVariables("%AppData%");

                    string path = AppData + "/TweetManager/user.ini";


                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(authObject.ACCESS_TOKEN);
                        tw.WriteLine(authObject.ACCESS_SECRET);
                        tw.Close();
                    }


                    welcomePanel.Dispose();
                }
                else
                {
                    this.errorPanel.Show();
                    Console.WriteLine("ERROR! CREDENTIALS ARE NOT MATCHED OR PROBLEMATIC!");
                }
            }
        }

        private void postButton_Click(object sender, EventArgs e)
        {
            if(userTweetList != null)
                if(userTweetList.Count != 0)
                    authObject.PostTweets(userTweetList);
        }

        private void CreateTweets(string userTweetOriginal)
        {
            ResetPanel();
            int PADDING = 10;
            userTweetList = new List<string>();

            if (userTweetOriginal.Length > 140)
            {
                string[] userTweetWords = userTweetOriginal.Split(' ');

                int index = 0;
                bool isFirstPass = false;

                while (index + 1 < userTweetWords.Length)
                {
                    string tmpStr = "";
                    tmpStr += userTweetWords[index];
                    index++;

                    while ((tmpStr + userTweetWords[index]).Length < 136 && (index < userTweetWords.Length))
                    {
                        tmpStr += " " + userTweetWords[index];

                        if (index + 1 < userTweetWords.Length)
                            index++;
                        else
                            break;
                    }

                    if (index + 1 >= userTweetWords.Length)
                        isFirstPass = true;

                    if (!isFirstPass)
                        tmpStr += "++";
                    else
                        isFirstPass = false;

                    userTweetList.Add(tmpStr);
                    
                }
            }
            else
                userTweetList.Add(userTweetOriginal);
            // We have our tweets now. All we have to do is adding them to the panel where user can see.


            for (int i = 0; i < userTweetList.Count; i++)
            {
                MetroPanel newPanel = new MetroPanel();

                newPanel = createNewPanel();

                newPanel.Location = new Point(OuterTweetPanel.Location.X, i * newPanel.Height + PADDING);
                newPanel.Visible = true;
                foreach (Control outerElement in newPanel.Controls)
                {
                   
                    if (outerElement is System.Windows.Forms.TextBox)
                    {
                        outerElement.Text = userTweetList[i];
                    }
                }
                TweetShowPanel.Controls.Add(newPanel);
                TweetShowPanel.Update();
            }

            if(LANGUAGE_SELECTION == LANGUAGE.TURKISH)
            {
                userDataInfo.Text = TURK_LANG[3] + userTweetOriginal.Length + TURK_LANG[4] + userTweetList.Count + TURK_LANG[5];
            }else if (LANGUAGE_SELECTION == LANGUAGE.ENGLISH)
            {
                userDataInfo.Text = ENG_LANG[3] + userTweetOriginal.Length + ENG_LANG[4] + userTweetList.Count + ENG_LANG[5];
            }
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            errorPanel.Hide();
        }


        /*
         * Because Windows Forms has no Clone function, we need to create every panel differently. This is REALLY problematic.
         * But as far as I know, there are no other solutions for this. So, lets make some magic. 
         */
        private MetroPanel createNewPanel()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manager));
            PictureBox pictureBoxOneTemp = new PictureBox();
            PictureBox pictureBoxTwoTemp = new PictureBox();
            TextBox tweetdataboxTemp = new TextBox();
            MetroPanel outerTweetTemp = new MetroPanel();
            MetroButton copyButtonTemp = new MetroButton();

            pictureBoxOneTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            pictureBoxOneTemp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBoxOneTemp.Location = new System.Drawing.Point(17, 114);
            pictureBoxOneTemp.Name = "pictureBox1";
            pictureBoxOneTemp.Size = new System.Drawing.Size(405, 40);
            pictureBoxOneTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxOneTemp.TabIndex = 2;
            pictureBoxOneTemp.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBoxTwoTemp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            pictureBoxTwoTemp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBoxTwoTemp.Location = new System.Drawing.Point(18, 14);
            pictureBoxTwoTemp.Name = "pictureBox2";
            pictureBoxTwoTemp.Size = new System.Drawing.Size(405, 40);
            pictureBoxTwoTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxTwoTemp.TabIndex = 3;
            pictureBoxTwoTemp.TabStop = false;
            // 
            // tweetdatabox
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(tweetdataboxTemp, true);
            tweetdataboxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            tweetdataboxTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tweetdataboxTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            tweetdataboxTemp.Location = new System.Drawing.Point(19, 69);
            tweetdataboxTemp.Multiline = true;
            tweetdataboxTemp.Name = "tweetdatabox";
            tweetdatabox.Enabled = false;
            tweetdataboxTemp.Size = new System.Drawing.Size(385, 59);
            tweetdataboxTemp.TabIndex = 4;
            // 
            // OuterTweetPanel
            // 
            outerTweetTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            outerTweetTemp.Controls.Add(tweetdataboxTemp);
            outerTweetTemp.Controls.Add(copyButtonTemp);
            outerTweetTemp.Controls.Add(pictureBoxTwoTemp);
            outerTweetTemp.Controls.Add(pictureBoxOneTemp);
            outerTweetTemp.HorizontalScrollbarBarColor = true;
            outerTweetTemp.HorizontalScrollbarHighlightOnWheel = false;
            outerTweetTemp.HorizontalScrollbarSize = 10;
            outerTweetTemp.Location = new System.Drawing.Point(3, 3);
            outerTweetTemp.Name = "OuterTweetPanel";
            outerTweetTemp.Size = new System.Drawing.Size(549, 164);
            outerTweetTemp.TabIndex = 5;
            outerTweetTemp.VerticalScrollbarBarColor = true;
            outerTweetTemp.VerticalScrollbarHighlightOnWheel = false;
            outerTweetTemp.VerticalScrollbarSize = 10;
            // 
            // CopyButton
            // 
            copyButtonTemp.Location = new System.Drawing.Point(429, 59);
            copyButtonTemp.Name = "CopyButton";
            copyButtonTemp.Size = new System.Drawing.Size(67, 59);
            copyButtonTemp.TabIndex = 5;
            if (LANGUAGE_SELECTION == LANGUAGE.ENGLISH)
                copyButtonTemp.Text = ENG_LANG[6];
            else if (LANGUAGE_SELECTION == LANGUAGE.TURKISH)
                copyButtonTemp.Text = TURK_LANG[6];
            copyButtonTemp.Click += (sender, EventArgs) => { Copy_Clipboard(sender, EventArgs, tweetdataboxTemp); };

            return outerTweetTemp;

        }

    }
}
