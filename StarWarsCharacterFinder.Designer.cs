namespace Star_Wars_Character_Finder
{
	partial class StarWarsCharacterFinder
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StarWarsCharacterFinder));
			this.lstCharacters = new System.Windows.Forms.ListBox();
			this.picStarWarsLogo = new System.Windows.Forms.PictureBox();
			this.txtCharacterName = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.picYoda = new System.Windows.Forms.PictureBox();
			this.btntxtClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picStarWarsLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picYoda)).BeginInit();
			this.SuspendLayout();
			// 
			// lstCharacters
			// 
			this.lstCharacters.BackColor = System.Drawing.Color.Black;
			this.lstCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstCharacters.ForeColor = System.Drawing.Color.Yellow;
			this.lstCharacters.FormattingEnabled = true;
			this.lstCharacters.ItemHeight = 16;
			this.lstCharacters.Location = new System.Drawing.Point(43, 104);
			this.lstCharacters.Name = "lstCharacters";
			this.lstCharacters.Size = new System.Drawing.Size(378, 180);
			this.lstCharacters.TabIndex = 0;
			// 
			// picStarWarsLogo
			// 
			this.picStarWarsLogo.BackColor = System.Drawing.Color.Transparent;
			this.picStarWarsLogo.BackgroundImage = global::Star_Wars_Character_Finder.Properties.Resources.starwars_logo;
			this.picStarWarsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picStarWarsLogo.Location = new System.Drawing.Point(136, 12);
			this.picStarWarsLogo.Name = "picStarWarsLogo";
			this.picStarWarsLogo.Size = new System.Drawing.Size(207, 86);
			this.picStarWarsLogo.TabIndex = 1;
			this.picStarWarsLogo.TabStop = false;
			// 
			// txtCharacterName
			// 
			this.txtCharacterName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtCharacterName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtCharacterName.BackColor = System.Drawing.Color.Black;
			this.txtCharacterName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCharacterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCharacterName.ForeColor = System.Drawing.Color.Yellow;
			this.txtCharacterName.Location = new System.Drawing.Point(43, 309);
			this.txtCharacterName.Name = "txtCharacterName";
			this.txtCharacterName.Size = new System.Drawing.Size(300, 20);
			this.txtCharacterName.TabIndex = 2;
			this.txtCharacterName.TextChanged += new System.EventHandler(this.txtCharacterName_TextChanged);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.Transparent;
			this.btnFind.BackgroundImage = global::Star_Wars_Character_Finder.Properties.Resources.Find_StarWars_Button;
			this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFind.Enabled = false;
			this.btnFind.ForeColor = System.Drawing.Color.Transparent;
			this.btnFind.Location = new System.Drawing.Point(349, 307);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(72, 22);
			this.btnFind.TabIndex = 3;
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// picYoda
			// 
			this.picYoda.BackColor = System.Drawing.Color.Transparent;
			this.picYoda.BackgroundImage = global::Star_Wars_Character_Finder.Properties.Resources.baby_yoda;
			this.picYoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picYoda.Image = global::Star_Wars_Character_Finder.Properties.Resources.baby_yoda;
			this.picYoda.Location = new System.Drawing.Point(84, 290);
			this.picYoda.Name = "picYoda";
			this.picYoda.Size = new System.Drawing.Size(300, 181);
			this.picYoda.TabIndex = 4;
			this.picYoda.TabStop = false;
			// 
			// btntxtClear
			// 
			this.btntxtClear.BackColor = System.Drawing.Color.Black;
			this.btntxtClear.BackgroundImage = global::Star_Wars_Character_Finder.Properties.Resources.Clear_StarWars_Button;
			this.btntxtClear.Enabled = false;
			this.btntxtClear.ForeColor = System.Drawing.Color.Transparent;
			this.btntxtClear.Location = new System.Drawing.Point(349, 347);
			this.btntxtClear.Name = "btntxtClear";
			this.btntxtClear.Size = new System.Drawing.Size(72, 22);
			this.btntxtClear.TabIndex = 5;
			this.btntxtClear.UseVisualStyleBackColor = false;
			this.btntxtClear.Click += new System.EventHandler(this.btntxtClear_Click);
			// 
			// StarWarsCharacterFinder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Star_Wars_Character_Finder.Properties.Resources.starwarscharacterbackground1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(467, 415);
			this.Controls.Add(this.btntxtClear);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.txtCharacterName);
			this.Controls.Add(this.picStarWarsLogo);
			this.Controls.Add(this.lstCharacters);
			this.Controls.Add(this.picYoda);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "StarWarsCharacterFinder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Star Wars Character Finder";
			this.Load += new System.EventHandler(this.StarWarsCharacterFinder_Load);
			((System.ComponentModel.ISupportInitialize)(this.picStarWarsLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picYoda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstCharacters;
		private System.Windows.Forms.PictureBox picStarWarsLogo;
		private System.Windows.Forms.TextBox txtCharacterName;
		private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.PictureBox picYoda;
		private System.Windows.Forms.Button btntxtClear;
	}
}

