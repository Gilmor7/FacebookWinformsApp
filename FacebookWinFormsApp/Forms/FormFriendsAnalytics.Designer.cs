
using BasicFacebookFeatures.ApplicationLogic.Features.FriendsAnalyticsFeature;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendsAnalytics));
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            this.LabelFriends = new System.Windows.Forms.Label();
            this.listBoxFriendsAnalytics = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLikesOnPosts = new System.Windows.Forms.Label();
            this.labelCommentsOnPosts = new System.Windows.Forms.Label();
            this.labelPostLikesCount = new System.Windows.Forms.Label();
            this.labelPostCommentsCount = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.labelOverallEngagements = new System.Windows.Forms.Label();
            this.labelPhotosLikesCount = new System.Windows.Forms.Label();
            this.labelLikesOnPhotos = new System.Windows.Forms.Label();
            this.labelNumberOfLikes = new System.Windows.Forms.Label();
            this.labelLikesCount = new System.Windows.Forms.Label();
            this.labelPostEngagementsCount = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.listBoxFriendsAnalytics.ValueMember = "About";
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
            // labelLikesOnPosts
            // 
            this.labelLikesOnPosts.Location = new System.Drawing.Point(709, 253);
            this.labelLikesOnPosts.Name = "labelLikesOnPosts";
            this.labelLikesOnPosts.Size = new System.Drawing.Size(213, 33);
            this.labelLikesOnPosts.TabIndex = 11;
            this.labelLikesOnPosts.Text = "Number Of Likes On Posts:";
            // 
            // labelCommentsOnPosts
            // 
            this.labelCommentsOnPosts.Location = new System.Drawing.Point(709, 299);
            this.labelCommentsOnPosts.Name = "labelCommentsOnPosts";
            this.labelCommentsOnPosts.Size = new System.Drawing.Size(250, 25);
            this.labelCommentsOnPosts.TabIndex = 12;
            this.labelCommentsOnPosts.Text = "Number Of Comments On Posts:";
            // 
            // labelPostLikesCount
            // 
            this.labelPostLikesCount.Location = new System.Drawing.Point(1025, 252);
            this.labelPostLikesCount.Name = "labelPostLikesCount";
            this.labelPostLikesCount.Size = new System.Drawing.Size(100, 23);
            this.labelPostLikesCount.TabIndex = 13;
            // 
            // labelPostCommentsCount
            // 
            this.labelPostCommentsCount.Location = new System.Drawing.Point(1025, 296);
            this.labelPostCommentsCount.Name = "labelPostCommentsCount";
            this.labelPostCommentsCount.Size = new System.Drawing.Size(100, 23);
            this.labelPostCommentsCount.TabIndex = 14;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(aboutLabel);
            this.panel1.Controls.Add(this.aboutLabel1);
            this.panel1.Controls.Add(birthdayLabel);
            this.panel1.Controls.Add(this.birthdayLabel1);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailLinkLabel);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(linkLabel);
            this.panel1.Controls.Add(this.linkLinkLabel);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameLabel1);
            this.panel1.Location = new System.Drawing.Point(287, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 317);
            this.panel1.TabIndex = 15;
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(26, 40);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(56, 20);
            aboutLabel.TabIndex = 0;
            aboutLabel.Text = "About:";
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(144, 40);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(100, 23);
            this.aboutLabel1.TabIndex = 1;
            this.aboutLabel1.Text = "label1";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(26, 63);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(71, 20);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(144, 63);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 3;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 86);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLinkLabel.Location = new System.Drawing.Point(144, 86);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLinkLabel.TabIndex = 5;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "linkLabel1";
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(30, 158);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(144, 129);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(26, 114);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(42, 20);
            linkLabel.TabIndex = 8;
            linkLabel.Text = "Link:";
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(144, 114);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.linkLinkLabel.TabIndex = 9;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(26, 17);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(144, 17);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 11;
            this.nameLabel1.Text = "label1";
            // 
            // labelOverallEngagements
            // 
            this.labelOverallEngagements.AutoSize = true;
            this.labelOverallEngagements.Location = new System.Drawing.Point(709, 464);
            this.labelOverallEngagements.Name = "labelOverallEngagements";
            this.labelOverallEngagements.Size = new System.Drawing.Size(263, 20);
            this.labelOverallEngagements.TabIndex = 16;
            this.labelOverallEngagements.Text = "Number Of Engagements On Posts:";
            // 
            // labelPhotosLikesCount
            // 
            this.labelPhotosLikesCount.Location = new System.Drawing.Point(1025, 353);
            this.labelPhotosLikesCount.Name = "labelPhotosLikesCount";
            this.labelPhotosLikesCount.Size = new System.Drawing.Size(100, 23);
            this.labelPhotosLikesCount.TabIndex = 17;
            // 
            // labelLikesOnPhotos
            // 
            this.labelLikesOnPhotos.AutoSize = true;
            this.labelLikesOnPhotos.Location = new System.Drawing.Point(709, 353);
            this.labelLikesOnPhotos.Name = "labelLikesOnPhotos";
            this.labelLikesOnPhotos.Size = new System.Drawing.Size(210, 20);
            this.labelLikesOnPhotos.TabIndex = 18;
            this.labelLikesOnPhotos.Text = "Number Of Likes On Photos:";
            // 
            // labelNumberOfLikes
            // 
            this.labelNumberOfLikes.AutoSize = true;
            this.labelNumberOfLikes.Location = new System.Drawing.Point(709, 408);
            this.labelNumberOfLikes.Name = "labelNumberOfLikes";
            this.labelNumberOfLikes.Size = new System.Drawing.Size(135, 20);
            this.labelNumberOfLikes.TabIndex = 19;
            this.labelNumberOfLikes.Text = "Number Of Likes: ";
            // 
            // labelLikesCount
            // 
            this.labelLikesCount.Location = new System.Drawing.Point(1025, 408);
            this.labelLikesCount.Name = "labelLikesCount";
            this.labelLikesCount.Size = new System.Drawing.Size(100, 23);
            this.labelLikesCount.TabIndex = 20;
            // 
            // labelPostEngagementsCount
            // 
            this.labelPostEngagementsCount.Location = new System.Drawing.Point(1025, 464);
            this.labelPostEngagementsCount.Name = "labelPostEngagementsCount";
            this.labelPostEngagementsCount.Size = new System.Drawing.Size(100, 23);
            this.labelPostEngagementsCount.TabIndex = 21;
            // 
            // FormFriendsAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1288, 641);
            this.Controls.Add(this.labelPostEngagementsCount);
            this.Controls.Add(this.labelLikesCount);
            this.Controls.Add(this.labelNumberOfLikes);
            this.Controls.Add(this.labelLikesOnPhotos);
            this.Controls.Add(this.labelPhotosLikesCount);
            this.Controls.Add(this.labelOverallEngagements);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPostCommentsCount);
            this.Controls.Add(this.labelPostLikesCount);
            this.Controls.Add(this.labelCommentsOnPosts);
            this.Controls.Add(this.labelLikesOnPosts);
            this.Controls.Add(this.LabelFriends);
            this.Controls.Add(this.listBoxFriendsAnalytics);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormFriendsAnalytics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelLikesOnPosts;
        private System.Windows.Forms.Label labelCommentsOnPosts;
        private System.Windows.Forms.Label labelPostLikesCount;
        private System.Windows.Forms.Label labelPostCommentsCount;

        #endregion
        private System.Windows.Forms.Label LabelFriends;
        private System.Windows.Forms.ListBox listBoxFriendsAnalytics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutLabel1;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label labelOverallEngagements;
        private System.Windows.Forms.Label labelPhotosLikesCount;
        private System.Windows.Forms.Label labelLikesOnPhotos;
        private System.Windows.Forms.Label labelNumberOfLikes;
        private System.Windows.Forms.Label labelLikesCount;
        private System.Windows.Forms.Label labelPostEngagementsCount;
    }
}