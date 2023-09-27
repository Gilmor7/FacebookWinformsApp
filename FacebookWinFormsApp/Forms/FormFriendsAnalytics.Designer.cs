
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
            this.labelLikes = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelLikesCount = new System.Windows.Forms.Label();
            this.labelCommentsCount = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameLabel1 = new System.Windows.Forms.Label();
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
            // labelLikes
            // 
            this.labelLikes.Location = new System.Drawing.Point(747, 253);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(213, 33);
            this.labelLikes.TabIndex = 11;
            this.labelLikes.Text = "Number Of Likes: ";
            // 
            // labelComments
            // 
            this.labelComments.Location = new System.Drawing.Point(747, 320);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(173, 21);
            this.labelComments.TabIndex = 12;
            this.labelComments.Text = "Number Of Comments:";
            // 
            // labelLikesCount
            // 
            this.labelLikesCount.Location = new System.Drawing.Point(1014, 253);
            this.labelLikesCount.Name = "labelLikesCount";
            this.labelLikesCount.Size = new System.Drawing.Size(100, 23);
            this.labelLikesCount.TabIndex = 13;
            // 
            // labelCommentsCount
            // 
            this.labelCommentsCount.Location = new System.Drawing.Point(1014, 320);
            this.labelCommentsCount.Name = "labelCommentsCount";
            this.labelCommentsCount.Size = new System.Drawing.Size(100, 23);
            this.labelCommentsCount.TabIndex = 14;
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
            // FormFriendsAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1288, 641);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCommentsCount);
            this.Controls.Add(this.labelLikesCount);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelLikes);
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

        }

        private System.Windows.Forms.Label labelLikes;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelLikesCount;
        private System.Windows.Forms.Label labelCommentsCount;

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
    }
}