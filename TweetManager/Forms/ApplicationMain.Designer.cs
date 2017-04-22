namespace TweetManager
{
    partial class form_manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manager));
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.pinBoxInput = new MetroFramework.Controls.MetroTextBox();
            this.start_button = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.userTweetBox = new System.Windows.Forms.RichTextBox();
            this.tweetdatabox = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.OuterTweetPanel = new MetroFramework.Controls.MetroPanel();
            this.CopyButton = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TweetShowPanel = new MetroFramework.Controls.MetroPanel();
            this.userDataInfo = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.langTurk = new System.Windows.Forms.Button();
            this.langEng = new System.Windows.Forms.Button();
            this.postButton = new MetroFramework.Controls.MetroButton();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.errorPanel = new MetroFramework.Controls.MetroPanel();
            this.errorText = new MetroFramework.Controls.MetroTextBox();
            this.errorButton = new MetroFramework.Controls.MetroButton();
            this.OOPS = new MetroFramework.Controls.MetroLabel();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.pinButton = new MetroFramework.Controls.MetroButton();
            this.dontButton = new MetroFramework.Controls.MetroButton();
            this.welcomeLabel = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.OuterTweetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TweetShowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.welcomePanel.SuspendLayout();
            this.errorPanel.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(3, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(93, 32);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "label1";
            // 
            // loginButton
            // 
            this.loginButton.Highlight = true;
            this.loginButton.Location = new System.Drawing.Point(414, 195);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(396, 129);
            this.loginButton.Style = MetroFramework.MetroColorStyle.White;
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pinBoxInput
            // 
            this.pinBoxInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pinBoxInput.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.pinBoxInput.Location = new System.Drawing.Point(9, 66);
            this.pinBoxInput.MaxLength = 20;
            this.pinBoxInput.Multiline = true;
            this.pinBoxInput.Name = "pinBoxInput";
            this.pinBoxInput.PromptText = "PIN";
            this.pinBoxInput.Size = new System.Drawing.Size(1187, 94);
            this.pinBoxInput.Style = MetroFramework.MetroColorStyle.White;
            this.pinBoxInput.TabIndex = 0;
            this.pinBoxInput.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // start_button
            // 
            this.start_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.start_button.Highlight = true;
            this.start_button.Location = new System.Drawing.Point(20, 973);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(678, 94);
            this.start_button.Style = MetroFramework.MetroColorStyle.Blue;
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.Theme = MetroFramework.MetroThemeStyle.Light;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // userTweetBox
            // 
            this.userTweetBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroStyleExtender1.SetApplyMetroTheme(this.userTweetBox, true);
            this.userTweetBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userTweetBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userTweetBox.Location = new System.Drawing.Point(24, 325);
            this.userTweetBox.Name = "userTweetBox";
            this.userTweetBox.Size = new System.Drawing.Size(658, 455);
            this.userTweetBox.TabIndex = 2;
            this.userTweetBox.Text = "";
            // 
            // tweetdatabox
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.tweetdatabox, true);
            this.tweetdatabox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tweetdatabox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tweetdatabox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tweetdatabox.Location = new System.Drawing.Point(38, 124);
            this.tweetdatabox.Multiline = true;
            this.tweetdatabox.Name = "tweetdatabox";
            this.tweetdatabox.Size = new System.Drawing.Size(785, 99);
            this.tweetdatabox.TabIndex = 4;
            this.tweetdatabox.Text = "This shouldn\'t be longer than 140 chars. And you shouldn\'t be able to see this. I" +
    "f you are seeing this, something went wrong probably. Yeah, thats all.";
            // 
            // pictureBox4
            // 
            this.metroStyleExtender1.SetApplyMetroTheme(this.pictureBox4, true);
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox4.Enabled = false;
            this.pictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(41, 110);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(877, 857);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBox1.CustomBackground = true;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Location = new System.Drawing.Point(24, 129);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroTextBox1.Size = new System.Drawing.Size(2092, 126);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.Text = "Write your long paragraphs, let this app divide it into pieces which you can post" +
    " one by one. Or, simply enter your username and password and enjoy this app post" +
    " divided tweets for you!";
            this.metroTextBox1.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 276);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(193, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Enter your tweet here";
            // 
            // OuterTweetPanel
            // 
            this.OuterTweetPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OuterTweetPanel.Controls.Add(this.tweetdatabox);
            this.OuterTweetPanel.Controls.Add(this.CopyButton);
            this.OuterTweetPanel.Controls.Add(this.pictureBox2);
            this.OuterTweetPanel.Controls.Add(this.pictureBox1);
            this.OuterTweetPanel.HorizontalScrollbarBarColor = true;
            this.OuterTweetPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.OuterTweetPanel.HorizontalScrollbarSize = 10;
            this.OuterTweetPanel.Location = new System.Drawing.Point(13, 3);
            this.OuterTweetPanel.Name = "OuterTweetPanel";
            this.OuterTweetPanel.Size = new System.Drawing.Size(1019, 364);
            this.OuterTweetPanel.TabIndex = 5;
            this.OuterTweetPanel.VerticalScrollbarBarColor = true;
            this.OuterTweetPanel.VerticalScrollbarHighlightOnWheel = false;
            this.OuterTweetPanel.VerticalScrollbarSize = 10;
            this.OuterTweetPanel.Visible = false;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(829, 124);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(95, 64);
            this.CopyButton.TabIndex = 5;
            this.CopyButton.Text = "Copy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(786, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 229);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TweetShowPanel
            // 
            this.TweetShowPanel.AutoScroll = true;
            this.TweetShowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TweetShowPanel.Controls.Add(this.OuterTweetPanel);
            this.TweetShowPanel.HorizontalScrollbar = true;
            this.TweetShowPanel.HorizontalScrollbarBarColor = true;
            this.TweetShowPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.TweetShowPanel.HorizontalScrollbarSize = 40;
            this.TweetShowPanel.Location = new System.Drawing.Point(709, 325);
            this.TweetShowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TweetShowPanel.Name = "TweetShowPanel";
            this.TweetShowPanel.Size = new System.Drawing.Size(1399, 614);
            this.TweetShowPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.TweetShowPanel.TabIndex = 6;
            this.TweetShowPanel.VerticalScrollbar = true;
            this.TweetShowPanel.VerticalScrollbarBarColor = true;
            this.TweetShowPanel.VerticalScrollbarHighlightOnWheel = false;
            this.TweetShowPanel.VerticalScrollbarSize = 40;
            // 
            // userDataInfo
            // 
            this.userDataInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userDataInfo.CustomBackground = true;
            this.userDataInfo.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.userDataInfo.Location = new System.Drawing.Point(24, 808);
            this.userDataInfo.Multiline = true;
            this.userDataInfo.Name = "userDataInfo";
            this.userDataInfo.ReadOnly = true;
            this.userDataInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userDataInfo.Size = new System.Drawing.Size(658, 131);
            this.userDataInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.userDataInfo.TabIndex = 9;
            this.userDataInfo.Text = "Total char count is 0. All text divided into 0 tweets.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::TweetManager.Properties.Resources.twitter_logo;
            this.pictureBox3.Location = new System.Drawing.Point(55, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(115, 102);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // langTurk
            // 
            this.langTurk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("langTurk.BackgroundImage")));
            this.langTurk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.langTurk.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.langTurk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langTurk.Location = new System.Drawing.Point(1925, 35);
            this.langTurk.Name = "langTurk";
            this.langTurk.Size = new System.Drawing.Size(88, 74);
            this.langTurk.TabIndex = 8;
            this.langTurk.UseVisualStyleBackColor = true;
            // 
            // langEng
            // 
            this.langEng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("langEng.BackgroundImage")));
            this.langEng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.langEng.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.langEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.langEng.Location = new System.Drawing.Point(2019, 35);
            this.langEng.Name = "langEng";
            this.langEng.Size = new System.Drawing.Size(88, 74);
            this.langEng.TabIndex = 7;
            this.langEng.UseVisualStyleBackColor = true;
            // 
            // postButton
            // 
            this.postButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.postButton.Highlight = true;
            this.postButton.Location = new System.Drawing.Point(722, 973);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(1398, 94);
            this.postButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.postButton.TabIndex = 13;
            this.postButton.Text = "Post";
            this.postButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // welcomePanel
            // 
            this.welcomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.welcomePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomePanel.Controls.Add(this.errorPanel);
            this.welcomePanel.Controls.Add(this.loginpanel);
            this.welcomePanel.Controls.Add(this.pinButton);
            this.welcomePanel.Controls.Add(this.dontButton);
            this.welcomePanel.Controls.Add(this.welcomeLabel);
            this.welcomePanel.Controls.Add(this.pictureBox4);
            this.welcomePanel.Location = new System.Drawing.Point(8, 129);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(2227, 954);
            this.welcomePanel.TabIndex = 14;
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.errorText);
            this.errorPanel.Controls.Add(this.errorButton);
            this.errorPanel.Controls.Add(this.OOPS);
            this.errorPanel.HorizontalScrollbarBarColor = true;
            this.errorPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.errorPanel.HorizontalScrollbarSize = 10;
            this.errorPanel.Location = new System.Drawing.Point(715, 197);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(1347, 673);
            this.errorPanel.TabIndex = 15;
            this.errorPanel.VerticalScrollbarBarColor = true;
            this.errorPanel.VerticalScrollbarHighlightOnWheel = false;
            this.errorPanel.VerticalScrollbarSize = 10;
            // 
            // errorText
            // 
            this.errorText.Location = new System.Drawing.Point(5, 144);
            this.errorText.Multiline = true;
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(1339, 308);
            this.errorText.TabIndex = 4;
            this.errorText.Text = "metroTextBox2";
            // 
            // errorButton
            // 
            this.errorButton.Location = new System.Drawing.Point(555, 511);
            this.errorButton.Name = "errorButton";
            this.errorButton.Size = new System.Drawing.Size(338, 100);
            this.errorButton.TabIndex = 3;
            this.errorButton.Text = "OKAY";
            this.errorButton.Click += new System.EventHandler(this.errorButton_Click);
            // 
            // OOPS
            // 
            this.OOPS.BackColor = System.Drawing.Color.Red;
            this.OOPS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OOPS.CustomBackground = true;
            this.OOPS.CustomForeColor = true;
            this.OOPS.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OOPS.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.OOPS.ForeColor = System.Drawing.Color.White;
            this.OOPS.Location = new System.Drawing.Point(4, 4);
            this.OOPS.Name = "OOPS";
            this.OOPS.Size = new System.Drawing.Size(1340, 137);
            this.OOPS.Style = MetroFramework.MetroColorStyle.Red;
            this.OOPS.TabIndex = 2;
            this.OOPS.Text = "Ooups....";
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.loginLabel);
            this.loginpanel.Controls.Add(this.loginButton);
            this.loginpanel.Controls.Add(this.pinBoxInput);
            this.loginpanel.Location = new System.Drawing.Point(957, 567);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(1234, 364);
            this.loginpanel.TabIndex = 7;
            // 
            // pinButton
            // 
            this.pinButton.Highlight = true;
            this.pinButton.Location = new System.Drawing.Point(1643, 386);
            this.pinButton.Name = "pinButton";
            this.pinButton.Size = new System.Drawing.Size(396, 129);
            this.pinButton.Style = MetroFramework.MetroColorStyle.White;
            this.pinButton.TabIndex = 4;
            this.pinButton.Text = "pinButton";
            this.pinButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pinButton.Click += new System.EventHandler(this.pinButton_Click);
            // 
            // dontButton
            // 
            this.dontButton.Highlight = true;
            this.dontButton.Location = new System.Drawing.Point(1139, 386);
            this.dontButton.Name = "dontButton";
            this.dontButton.Size = new System.Drawing.Size(396, 129);
            this.dontButton.Style = MetroFramework.MetroColorStyle.White;
            this.dontButton.TabIndex = 3;
            this.dontButton.Text = "dontButton";
            this.dontButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dontButton.Click += new System.EventHandler(this.dontButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.CustomBackground = true;
            this.welcomeLabel.CustomForeColor = true;
            this.welcomeLabel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(938, 110);
            this.welcomeLabel.Multiline = true;
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(1287, 205);
            this.welcomeLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = resources.GetString("welcomeLabel.Text");
            this.welcomeLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.welcomeLabel.UseStyleColors = true;
            // 
            // form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(2248, 1087);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.userDataInfo);
            this.Controls.Add(this.langTurk);
            this.Controls.Add(this.langEng);
            this.Controls.Add(this.TweetShowPanel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.userTweetBox);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.start_button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(2248, 1087);
            this.Name = "form_manager";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 10, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "      Tweet Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.OuterTweetPanel.ResumeLayout(false);
            this.OuterTweetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TweetShowPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.welcomePanel.ResumeLayout(false);
            this.errorPanel.ResumeLayout(false);
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton start_button;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.RichTextBox userTweetBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tweetdatabox;
        private MetroFramework.Controls.MetroPanel OuterTweetPanel;
        private MetroFramework.Controls.MetroButton CopyButton;
        private MetroFramework.Controls.MetroPanel TweetShowPanel;
        private System.Windows.Forms.Button langEng;
        private System.Windows.Forms.Button langTurk;
        private MetroFramework.Controls.MetroTextBox userDataInfo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel welcomePanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton postButton;
        private MetroFramework.Controls.MetroTextBox welcomeLabel;
        private MetroFramework.Controls.MetroButton dontButton;
        private MetroFramework.Controls.MetroButton pinButton;
        private System.Windows.Forms.Label loginLabel;
        private MetroFramework.Controls.MetroButton loginButton;
        private MetroFramework.Controls.MetroTextBox pinBoxInput;
        private System.Windows.Forms.Panel panelPinPlaceHolder ;
        private System.Windows.Forms.Panel loginpanel;
        private MetroFramework.Controls.MetroPanel errorPanel;
        private MetroFramework.Controls.MetroLabel OOPS;
        private MetroFramework.Controls.MetroButton errorButton;
        private MetroFramework.Controls.MetroTextBox errorText;
    }
}

