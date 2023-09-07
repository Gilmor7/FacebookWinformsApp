namespace BasicFacebookFeatures.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.userFriendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postedItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.friendsAnalyticsFeatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBoxPages = new System.Windows.Forms.ListBox(); ;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonRelationships = new System.Windows.Forms.Button();
            this.buttonAnalytics = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPostsTitle = new System.Windows.Forms.Label();
            this.labelEventsTitle = new System.Windows.Forms.Label();
            this.labelAlbumsTitle = new System.Windows.Forms.Label();
            this.labelPagesTitle = new System.Windows.Forms.Label();
            this.labelFriendsTitle = new System.Windows.Forms.Label();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelExtendView3 = new System.Windows.Forms.Label();
            this.labelExtendView2 = new System.Windows.Forms.Label();
            this.labelExtendView1 = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.tabControlFormMain = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.userFriendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postedItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsAnalyticsFeatureBindingSource)).BeginInit();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabControlFormMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // userFriendsBindingSource
            // 
            this.userFriendsBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.postedItemBindingSource;
            // 
            // postedItemBindingSource
            // 
            this.postedItemBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.PostedItem);
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.userFriendsBindingSource;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.userFriendsBindingSource;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // tabPageHome
            // 
            this.tabPageHome.AutoScroll = true;
            this.tabPageHome.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.tabPageHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.tabPageHome.Controls.Add(this.listBoxEvents);
            this.tabPageHome.Controls.Add(this.pictureBox3);
            this.tabPageHome.Controls.Add(this.listBoxAlbums);
            this.tabPageHome.Controls.Add(this.pictureBox2);
            this.tabPageHome.Controls.Add(this.listBoxPages);
            this.tabPageHome.Controls.Add(this.pictureBox1);
            this.tabPageHome.Controls.Add(this.listBoxFriends);
            this.tabPageHome.Controls.Add(this.buttonRelationships);
            this.tabPageHome.Controls.Add(this.buttonAnalytics);
            this.tabPageHome.Controls.Add(this.label3);
            this.tabPageHome.Controls.Add(this.labelPostsTitle);
            this.tabPageHome.Controls.Add(this.labelEventsTitle);
            this.tabPageHome.Controls.Add(this.labelAlbumsTitle);
            this.tabPageHome.Controls.Add(this.labelPagesTitle);
            this.tabPageHome.Controls.Add(this.labelFriendsTitle);
            this.tabPageHome.Controls.Add(this.listBoxPostComments);
            this.tabPageHome.Controls.Add(this.label5);
            this.tabPageHome.Controls.Add(this.labelExtendView3);
            this.tabPageHome.Controls.Add(this.labelExtendView2);
            this.tabPageHome.Controls.Add(this.labelExtendView1);
            this.tabPageHome.Controls.Add(this.listBoxPosts);
            this.tabPageHome.Controls.Add(this.buttonPost);
            this.tabPageHome.Controls.Add(this.textBoxStatus);
            this.tabPageHome.Controls.Add(this.labelStatus);
            this.tabPageHome.Controls.Add(this.labelUserName);
            this.tabPageHome.Controls.Add(this.pictureBoxProfile);
            this.tabPageHome.Controls.Add(this.buttonLogout);
            this.tabPageHome.Controls.Add(this.buttonLogin);
            this.tabPageHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.tabPageHome.Location = new System.Drawing.Point(4, 35);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(1343, 771);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 26;
            this.listBoxEvents.Location = new System.Drawing.Point(982, 519);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(289, 212);
            this.listBoxEvents.TabIndex = 87;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.pictureBox3.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumsBindingSource, "ImageAlbum", true));
            this.pictureBox3.Location = new System.Drawing.Point(878, 665);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumsBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 26;
            this.listBoxAlbums.Location = new System.Drawing.Point(666, 519);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(289, 212);
            this.listBoxAlbums.TabIndex = 85;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.pictureBox2.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.pictureBox2.Location = new System.Drawing.Point(564, 665);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 84;
            this.pictureBox2.TabStop = false;
            // 
            // listBoxPages
            // 
            this.listBoxPages.DataSource = this.pageBindingSource;
            this.listBoxPages.DisplayMember = "Name";
            this.listBoxPages.FormattingEnabled = true;
            this.listBoxPages.ItemHeight = 26;
            this.listBoxPages.Location = new System.Drawing.Point(344, 519);
            this.listBoxPages.Name = "listBoxPages";
            this.listBoxPages.Size = new System.Drawing.Size(289, 212);
            this.listBoxPages.TabIndex = 83;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userFriendsBindingSource, "ImageNormal", true));
            this.pictureBox1.Location = new System.Drawing.Point(249, 665);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.DataSource = this.userFriendsBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 26;
            this.listBoxFriends.Location = new System.Drawing.Point(18, 519);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(289, 212);
            this.listBoxFriends.TabIndex = 81;
            // 
            // buttonRelationships
            // 
            this.buttonRelationships.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRelationships.Enabled = false;
            this.buttonRelationships.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.buttonRelationships.Location = new System.Drawing.Point(18, 382);
            this.buttonRelationships.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRelationships.Name = "buttonRelationships";
            this.buttonRelationships.Size = new System.Drawing.Size(268, 32);
            this.buttonRelationships.TabIndex = 80;
            this.buttonRelationships.Text = "Find Matches";
            this.buttonRelationships.UseVisualStyleBackColor = true;
            this.buttonRelationships.Click += new System.EventHandler(this.buttonRelationships_Click);
            // 
            // buttonAnalytics
            // 
            this.buttonAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnalytics.Enabled = false;
            this.buttonAnalytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.buttonAnalytics.Location = new System.Drawing.Point(18, 342);
            this.buttonAnalytics.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAnalytics.Name = "buttonAnalytics";
            this.buttonAnalytics.Size = new System.Drawing.Size(268, 32);
            this.buttonAnalytics.TabIndex = 79;
            this.buttonAnalytics.Text = "Friends Analytics";
            this.buttonAnalytics.UseVisualStyleBackColor = true;
            this.buttonAnalytics.Click += new System.EventHandler(this.buttonAnalytics_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 78;
            this.label3.Text = "Logged as:";
            // 
            // labelPostsTitle
            // 
            this.labelPostsTitle.AutoSize = true;
            this.labelPostsTitle.Location = new System.Drawing.Point(387, 80);
            this.labelPostsTitle.Name = "labelPostsTitle";
            this.labelPostsTitle.Size = new System.Drawing.Size(73, 26);
            this.labelPostsTitle.TabIndex = 76;
            this.labelPostsTitle.Text = "Posts:";
            // 
            // labelEventsTitle
            // 
            this.labelEventsTitle.AutoSize = true;
            this.labelEventsTitle.Location = new System.Drawing.Point(977, 447);
            this.labelEventsTitle.Name = "labelEventsTitle";
            this.labelEventsTitle.Size = new System.Drawing.Size(85, 26);
            this.labelEventsTitle.TabIndex = 75;
            this.labelEventsTitle.Text = "Events:";
            // 
            // labelAlbumsTitle
            // 
            this.labelAlbumsTitle.AutoSize = true;
            this.labelAlbumsTitle.Location = new System.Drawing.Point(653, 447);
            this.labelAlbumsTitle.Name = "labelAlbumsTitle";
            this.labelAlbumsTitle.Size = new System.Drawing.Size(92, 26);
            this.labelAlbumsTitle.TabIndex = 74;
            this.labelAlbumsTitle.Text = "Albums:";
            // 
            // labelPagesTitle
            // 
            this.labelPagesTitle.AutoSize = true;
            this.labelPagesTitle.Location = new System.Drawing.Point(338, 447);
            this.labelPagesTitle.Name = "labelPagesTitle";
            this.labelPagesTitle.Size = new System.Drawing.Size(80, 26);
            this.labelPagesTitle.TabIndex = 73;
            this.labelPagesTitle.Text = "Pages:";
            // 
            // labelFriendsTitle
            // 
            this.labelFriendsTitle.AutoSize = true;
            this.labelFriendsTitle.Location = new System.Drawing.Point(23, 447);
            this.labelFriendsTitle.Name = "labelFriendsTitle";
            this.labelFriendsTitle.Size = new System.Drawing.Size(90, 26);
            this.labelFriendsTitle.TabIndex = 72;
            this.labelFriendsTitle.Text = "Friends:";
            // 
            // listBoxPostComments
            // 
            this.listBoxPostComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(200)))), ((int)(((byte)(228)))));
            this.listBoxPostComments.DataSource = this.commentsBindingSource;
            this.listBoxPostComments.DisplayMember = "Message";
            this.listBoxPostComments.FormattingEnabled = true;
            this.listBoxPostComments.ItemHeight = 26;
            this.listBoxPostComments.Location = new System.Drawing.Point(973, 202);
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(289, 160);
            this.listBoxPostComments.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(654, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 22);
            this.label5.TabIndex = 65;
            this.label5.Text = "(Click on an album to view it\'s cover)";
            // 
            // labelExtendView3
            // 
            this.labelExtendView3.AutoSize = true;
            this.labelExtendView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelExtendView3.Location = new System.Drawing.Point(339, 487);
            this.labelExtendView3.Name = "labelExtendView3";
            this.labelExtendView3.Size = new System.Drawing.Size(293, 22);
            this.labelExtendView3.TabIndex = 63;
            this.labelExtendView3.Text = "(Click on a page to view it\'s picture)";
            // 
            // labelExtendView2
            // 
            this.labelExtendView2.AutoSize = true;
            this.labelExtendView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelExtendView2.Location = new System.Drawing.Point(23, 487);
            this.labelExtendView2.Name = "labelExtendView2";
            this.labelExtendView2.Size = new System.Drawing.Size(299, 22);
            this.labelExtendView2.TabIndex = 61;
            this.labelExtendView2.Text = "(Click on a friend to view his picture)";
            // 
            // labelExtendView1
            // 
            this.labelExtendView1.AutoSize = true;
            this.labelExtendView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelExtendView1.Location = new System.Drawing.Point(387, 118);
            this.labelExtendView1.Name = "labelExtendView1";
            this.labelExtendView1.Size = new System.Drawing.Size(287, 22);
            this.labelExtendView1.TabIndex = 59;
            this.labelExtendView1.Text = "(Click on a post to view comments)";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postedItemBindingSource;
            this.listBoxPosts.DisplayMember = "Message";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(392, 150);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(651, 186);
            this.listBoxPosts.TabIndex = 58;
            this.listBoxPosts.ValueMember = "Comments";
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonPost
            // 
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.buttonPost.Location = new System.Drawing.Point(1056, 13);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(86, 33);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(513, 17);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(530, 32);
            this.textBoxStatus.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(387, 19);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(130, 26);
            this.labelStatus.TabIndex = 57;
            this.labelStatus.Text = "Post Status:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.labelUserName.Location = new System.Drawing.Point(138, 106);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(217, 26);
            this.labelUserName.TabIndex = 56;
            this.labelUserName.Text = "No user logged in yet";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 150);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(248, 156);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // tabControlFormMain
            // 
            this.tabControlFormMain.Controls.Add(this.tabPageHome);
            this.tabControlFormMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlFormMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlFormMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlFormMain.Name = "tabControlFormMain";
            this.tabControlFormMain.SelectedIndex = 0;
            this.tabControlFormMain.Size = new System.Drawing.Size(1351, 810);
            this.tabControlFormMain.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1351, 810);
            this.Controls.Add(this.tabControlFormMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1350, 800);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desktop Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.userFriendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postedItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsAnalyticsFeatureBindingSource)).EndInit();
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabControlFormMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userFriendsBindingSource;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.BindingSource pageBindingSource;
        private System.Windows.Forms.BindingSource postedItemBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource friendsAnalyticsFeatureBindingSource;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPostsTitle;
        private System.Windows.Forms.Label labelEventsTitle;
        private System.Windows.Forms.Label labelAlbumsTitle;
        private System.Windows.Forms.Label labelPagesTitle;
        private System.Windows.Forms.Label labelFriendsTitle;
        private System.Windows.Forms.ListBox listBoxPostComments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelExtendView3;
        private System.Windows.Forms.Label labelExtendView2;
        private System.Windows.Forms.Label labelExtendView1;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabControl tabControlFormMain;
        private System.Windows.Forms.Button buttonRelationships;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBoxPages;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.ListBox listBoxEvents;
    }
}

