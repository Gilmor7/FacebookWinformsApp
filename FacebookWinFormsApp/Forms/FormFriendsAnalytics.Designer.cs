
namespace BasicFacebookFeatures.Forms
{
    partial class FormFriendsAnalytics
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
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label numberOfCommentsLabel;
            System.Windows.Forms.Label numberOfLikesLabel;
            System.Windows.Forms.Label numberOfOverallEngagementsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendsAnalytics));
            this.friendsAnalyticsFeatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelFriends = new System.Windows.Forms.Label();
            this.listBoxFriendsAnalytics = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.panelAnalysis = new System.Windows.Forms.Panel();
            this.numberOfCommentsLabel1 = new System.Windows.Forms.Label();
            this.numberOfLikesLabel1 = new System.Windows.Forms.Label();
            this.numberOfOverallEngagementsLabel1 = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            numberOfCommentsLabel = new System.Windows.Forms.Label();
            numberOfLikesLabel = new System.Windows.Forms.Label();
            numberOfOverallEngagementsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.friendsAnalyticsFeatureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.panelAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(11, 101);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(56, 20);
            aboutLabel.TabIndex = 0;
            aboutLabel.Text = "About:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(11, 124);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(11, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(11, 171);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(42, 20);
            linkLabel.TabIndex = 8;
            linkLabel.Text = "Link:";
            // 
            // numberOfCommentsLabel
            // 
            numberOfCommentsLabel.AutoSize = true;
            numberOfCommentsLabel.Location = new System.Drawing.Point(14, 36);
            numberOfCommentsLabel.Name = "numberOfCommentsLabel";
            numberOfCommentsLabel.Size = new System.Drawing.Size(171, 20);
            numberOfCommentsLabel.TabIndex = 0;
            numberOfCommentsLabel.Text = "Number Of Comments:";
            // 
            // numberOfLikesLabel
            // 
            numberOfLikesLabel.AutoSize = true;
            numberOfLikesLabel.Location = new System.Drawing.Point(14, 59);
            numberOfLikesLabel.Name = "numberOfLikesLabel";
            numberOfLikesLabel.Size = new System.Drawing.Size(131, 20);
            numberOfLikesLabel.TabIndex = 2;
            numberOfLikesLabel.Text = "Number Of Likes:";
            // 
            // numberOfOverallEngagementsLabel
            // 
            numberOfOverallEngagementsLabel.AutoSize = true;
            numberOfOverallEngagementsLabel.Location = new System.Drawing.Point(14, 82);
            numberOfOverallEngagementsLabel.Name = "numberOfOverallEngagementsLabel";
            numberOfOverallEngagementsLabel.Size = new System.Drawing.Size(246, 20);
            numberOfOverallEngagementsLabel.TabIndex = 4;
            numberOfOverallEngagementsLabel.Text = "Number Of Overall Engagements:";
            // 
            // friendsAnalyticsFeatureBindingSource
            // 
            this.friendsAnalyticsFeatureBindingSource.DataSource = typeof(BasicFacebookFeatures.Features.FriendsAnalyticsFeature.FriendsAnalyticsFeature);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // LabelFriends
            // 
            this.LabelFriends.BackColor = System.Drawing.Color.Transparent;
            this.LabelFriends.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFriends.Location = new System.Drawing.Point(45, 181);
            this.LabelFriends.Name = "LabelFriends";
            this.LabelFriends.Size = new System.Drawing.Size(206, 37);
            this.LabelFriends.TabIndex = 7;
            this.LabelFriends.Text = "Friends:";
            this.LabelFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxFriendsAnalytics
            // 
            this.listBoxFriendsAnalytics.DataSource = this.userBindingSource;
            this.listBoxFriendsAnalytics.DisplayMember = "Name";
            this.listBoxFriendsAnalytics.FormattingEnabled = true;
            this.listBoxFriendsAnalytics.ItemHeight = 20;
            this.listBoxFriendsAnalytics.Location = new System.Drawing.Point(45, 236);
            this.listBoxFriendsAnalytics.Name = "listBoxFriendsAnalytics";
            this.listBoxFriendsAnalytics.Size = new System.Drawing.Size(206, 344);
            this.listBoxFriendsAnalytics.TabIndex = 6;
            this.listBoxFriendsAnalytics.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsAnalytics_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1126, 124);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(aboutLabel);
            this.panel1.Controls.Add(this.aboutLabel1);
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(this.emailLinkLabel);
            this.panel1.Controls.Add(linkLabel);
            this.panel1.Controls.Add(this.linkLinkLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Location = new System.Drawing.Point(329, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 226);
            this.panel1.TabIndex = 10;
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(129, 101);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(171, 23);
            this.aboutLabel1.TabIndex = 1;
            this.aboutLabel1.Text = "label1";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(129, 124);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(171, 23);
            this.birthdayLabel1.TabIndex = 3;
            this.birthdayLabel1.Text = "label1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(15, 10);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(96, 69);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLinkLabel.Location = new System.Drawing.Point(129, 147);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(171, 23);
            this.emailLinkLabel.TabIndex = 5;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "linkLabel1";
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(129, 171);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(171, 23);
            this.linkLinkLabel.TabIndex = 9;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(129, 10);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 11;
            this.nameLabel1.Text = "label1";
            // 
            // panelAnalysis
            // 
            this.panelAnalysis.Controls.Add(numberOfCommentsLabel);
            this.panelAnalysis.Controls.Add(this.numberOfCommentsLabel1);
            this.panelAnalysis.Controls.Add(numberOfLikesLabel);
            this.panelAnalysis.Controls.Add(this.numberOfLikesLabel1);
            this.panelAnalysis.Controls.Add(numberOfOverallEngagementsLabel);
            this.panelAnalysis.Controls.Add(this.numberOfOverallEngagementsLabel1);
            this.panelAnalysis.Location = new System.Drawing.Point(713, 243);
            this.panelAnalysis.Name = "panelAnalysis";
            this.panelAnalysis.Size = new System.Drawing.Size(454, 122);
            this.panelAnalysis.TabIndex = 11;
            // 
            // numberOfCommentsLabel1
            // 
            this.numberOfCommentsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsAnalyticsFeatureBindingSource, "NumberOfComments", true));
            this.numberOfCommentsLabel1.Location = new System.Drawing.Point(266, 36);
            this.numberOfCommentsLabel1.Name = "numberOfCommentsLabel1";
            this.numberOfCommentsLabel1.Size = new System.Drawing.Size(166, 23);
            this.numberOfCommentsLabel1.TabIndex = 1;
            this.numberOfCommentsLabel1.Text = "label1";
            // 
            // numberOfLikesLabel1
            // 
            this.numberOfLikesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsAnalyticsFeatureBindingSource, "NumberOfLikes", true));
            this.numberOfLikesLabel1.Location = new System.Drawing.Point(266, 59);
            this.numberOfLikesLabel1.Name = "numberOfLikesLabel1";
            this.numberOfLikesLabel1.Size = new System.Drawing.Size(166, 23);
            this.numberOfLikesLabel1.TabIndex = 3;
            this.numberOfLikesLabel1.Text = "label1";
            // 
            // numberOfOverallEngagementsLabel1
            // 
            this.numberOfOverallEngagementsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.friendsAnalyticsFeatureBindingSource, "NumberOfOverallEngagements", true));
            this.numberOfOverallEngagementsLabel1.Location = new System.Drawing.Point(266, 82);
            this.numberOfOverallEngagementsLabel1.Name = "numberOfOverallEngagementsLabel1";
            this.numberOfOverallEngagementsLabel1.Size = new System.Drawing.Size(166, 23);
            this.numberOfOverallEngagementsLabel1.TabIndex = 5;
            this.numberOfOverallEngagementsLabel1.Text = "label1";
            // 
            // FormFriendsAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1288, 641);
            this.Controls.Add(this.panelAnalysis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelFriends);
            this.Controls.Add(this.listBoxFriendsAnalytics);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.Name = "FormFriendsAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Friends Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.friendsAnalyticsFeatureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.panelAnalysis.ResumeLayout(false);
            this.panelAnalysis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LabelFriends;
        private System.Windows.Forms.ListBox listBoxFriendsAnalytics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource friendsAnalyticsFeatureBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Panel panelAnalysis;
        private System.Windows.Forms.Label numberOfCommentsLabel1;
        private System.Windows.Forms.Label numberOfLikesLabel1;
        private System.Windows.Forms.Label numberOfOverallEngagementsLabel1;
    }
}