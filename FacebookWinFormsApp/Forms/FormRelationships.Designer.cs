
using BasicFacebookFeatures.ApplicationLogic.Features.RelationshipFeature;

namespace BasicFacebookFeatures.Forms
{
    partial class FormRelationships
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
            this.LabelRelationshipFriends = new System.Windows.Forms.Label();
            this.listBoxRelationship = new System.Windows.Forms.ListBox();
            this.LabelRelationshipFeature = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.LabelGender = new System.Windows.Forms.Label();
            this.labelAgePref = new System.Windows.Forms.Label();
            this.labelCityPref = new System.Windows.Forms.Label();
            this.checkBoxSameCity = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxAge = new System.Windows.Forms.NumericUpDown();
            this.labelMinAge = new System.Windows.Forms.Label();
            this.labelMaxAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelRelationshipFriends
            // 
            this.LabelRelationshipFriends.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.LabelRelationshipFriends.Location = new System.Drawing.Point(43, 124);
            this.LabelRelationshipFriends.Name = "LabelRelationshipFriends";
            this.LabelRelationshipFriends.Size = new System.Drawing.Size(237, 36);
            this.LabelRelationshipFriends.TabIndex = 18;
            this.LabelRelationshipFriends.Text = "1. Select a friend";
            this.LabelRelationshipFriends.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxRelationship
            // 
            this.listBoxRelationship.FormattingEnabled = true;
            this.listBoxRelationship.ItemHeight = 20;
            this.listBoxRelationship.Location = new System.Drawing.Point(43, 173);
            this.listBoxRelationship.Name = "listBoxRelationship";
            this.listBoxRelationship.Size = new System.Drawing.Size(237, 464);
            this.listBoxRelationship.TabIndex = 17;
            this.listBoxRelationship.SelectedIndexChanged += new System.EventHandler(this.ListBoxRelationship_SelectedIndexChanged);
            // 
            // LabelRelationshipFeature
            // 
            this.LabelRelationshipFeature.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRelationshipFeature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.LabelRelationshipFeature.Location = new System.Drawing.Point(41, 49);
            this.LabelRelationshipFeature.Name = "LabelRelationshipFeature";
            this.LabelRelationshipFeature.Size = new System.Drawing.Size(1368, 35);
            this.LabelRelationshipFeature.TabIndex = 16;
            this.LabelRelationshipFeature.Text = "Find Potential Matches from a Friend\'s Friend List Based on Preferences";
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.checkBoxMale.Location = new System.Drawing.Point(326, 173);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(258, 53);
            this.checkBoxMale.TabIndex = 19;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.CheckBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.checkBoxFemale.Location = new System.Drawing.Point(326, 232);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(258, 60);
            this.checkBoxFemale.TabIndex = 20;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.CheckBoxFemale_CheckedChanged);
            // 
            // LabelGender
            // 
            this.LabelGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.LabelGender.Location = new System.Drawing.Point(326, 124);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(258, 41);
            this.LabelGender.TabIndex = 21;
            this.LabelGender.Text = "2. Pick gender prefrence";
            this.LabelGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAgePref
            // 
            this.labelAgePref.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.labelAgePref.Location = new System.Drawing.Point(326, 323);
            this.labelAgePref.Name = "labelAgePref";
            this.labelAgePref.Size = new System.Drawing.Size(228, 41);
            this.labelAgePref.TabIndex = 22;
            this.labelAgePref.Text = "3. Pick age prefrence";
            this.labelAgePref.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCityPref
            // 
            this.labelCityPref.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.labelCityPref.Location = new System.Drawing.Point(326, 533);
            this.labelCityPref.Name = "labelCityPref";
            this.labelCityPref.Size = new System.Drawing.Size(236, 41);
            this.labelCityPref.TabIndex = 23;
            this.labelCityPref.Text = "4. Pick city prefrence";
            this.labelCityPref.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxSameCity
            // 
            this.checkBoxSameCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSameCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.checkBoxSameCity.Location = new System.Drawing.Point(326, 582);
            this.checkBoxSameCity.Name = "checkBoxSameCity";
            this.checkBoxSameCity.Size = new System.Drawing.Size(236, 53);
            this.checkBoxSameCity.TabIndex = 24;
            this.checkBoxSameCity.Text = "Same city as mine";
            this.checkBoxSameCity.UseVisualStyleBackColor = true;
            this.checkBoxSameCity.CheckedChanged += new System.EventHandler(this.checkBoxSameCity_CheckedChanged);
            // 
            // numericUpDownMinAge
            // 
            this.numericUpDownMinAge.Location = new System.Drawing.Point(489, 386);
            this.numericUpDownMinAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            this.numericUpDownMinAge.Name = "numericUpDownMinAge";
            this.numericUpDownMinAge.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownMinAge.TabIndex = 25;
            this.numericUpDownMinAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            this.numericUpDownMinAge.ValueChanged += new System.EventHandler(this.numericUpDownMinAge_ValueChanged);
            // 
            // numericUpDownMaxAge
            // 
            this.numericUpDownMaxAge.Location = new System.Drawing.Point(489, 449);
            this.numericUpDownMaxAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.numericUpDownMaxAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            this.numericUpDownMaxAge.Name = "numericUpDownMaxAge";
            this.numericUpDownMaxAge.Size = new System.Drawing.Size(65, 26);
            this.numericUpDownMaxAge.TabIndex = 26;
            this.numericUpDownMaxAge.Value = new decimal(new int[] { 120, 0, 0, 0 });
            this.numericUpDownMaxAge.ValueChanged += new System.EventHandler(this.numericUpDownMaxAge_ValueChanged);
            // 
            // labelMinAge
            // 
            this.labelMinAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.labelMinAge.Location = new System.Drawing.Point(326, 377);
            this.labelMinAge.Name = "labelMinAge";
            this.labelMinAge.Size = new System.Drawing.Size(152, 41);
            this.labelMinAge.TabIndex = 27;
            this.labelMinAge.Text = "Minimum age:";
            this.labelMinAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaxAge
            // 
            this.labelMaxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.labelMaxAge.Location = new System.Drawing.Point(326, 440);
            this.labelMaxAge.Name = "labelMaxAge";
            this.labelMaxAge.Size = new System.Drawing.Size(163, 41);
            this.labelMaxAge.TabIndex = 28;
            this.labelMaxAge.Text = "Maximum age:";
            this.labelMaxAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(692, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "Possible Mathces";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.ItemHeight = 20;
            this.listBoxMatches.Location = new System.Drawing.Point(692, 173);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(237, 464);
            this.listBoxMatches.TabIndex = 29;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(692, 669);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(237, 48);
            this.buttonSubmit.TabIndex = 31;
            this.buttonSubmit.Text = "Do The Magic!";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // FormRelationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1013, 773);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMatches);
            this.Controls.Add(this.labelMaxAge);
            this.Controls.Add(this.labelMinAge);
            this.Controls.Add(this.numericUpDownMaxAge);
            this.Controls.Add(this.numericUpDownMinAge);
            this.Controls.Add(this.checkBoxSameCity);
            this.Controls.Add(this.labelCityPref);
            this.Controls.Add(this.labelAgePref);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.LabelRelationshipFriends);
            this.Controls.Add(this.listBoxRelationship);
            this.Controls.Add(this.LabelRelationshipFeature);
            this.Name = "FormRelationships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Matches";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxAge)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonSubmit;

        #endregion
        private System.Windows.Forms.Label LabelRelationshipFriends;
        private System.Windows.Forms.ListBox listBoxRelationship;
        private System.Windows.Forms.Label LabelRelationshipFeature;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.Label labelAgePref;
        private System.Windows.Forms.Label labelCityPref;
        private System.Windows.Forms.CheckBox checkBoxSameCity;
        private System.Windows.Forms.NumericUpDown numericUpDownMinAge;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxAge;
        private System.Windows.Forms.Label labelMinAge;
        private System.Windows.Forms.Label labelMaxAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMatches;
    }
}