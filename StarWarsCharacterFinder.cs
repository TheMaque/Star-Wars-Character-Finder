using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Media;


namespace Star_Wars_Character_Finder
{
	public partial class StarWarsCharacterFinder : Form
	{
		PrivateFontCollection starwarsfont = new PrivateFontCollection();

		public StarWarsCharacterFinder()
		{
			InitializeComponent();
		}

		private void StarWarsCharacterFinder_Load(object sender, EventArgs e)
		{
			LoadFonts();
			string[] starwarscharacters = new string[114];

			starwarscharacters[0] = "Anakin";
			starwarscharacters[1] = "Darth Vader";

		}

		private void AddFont(string font)
		{
			// Add Fonts
			starwarsfont.AddFontFile(font);
		}

		private void LoadFonts()
		{
			//AddFont(Path.Combine(Directory.GetCurrentDirectory(), "Starjedi.ttf"));

			//lstCharacters.Font = new Font(starwarsfont.Families[1], 8, FontStyle.Regular);
			//txtCharacterName.Font = new Font(starwarsfont.Families[1], 8, FontStyle.Regular);
			//btnFind.Font = new Font(starwarsfont.Families[1], 8, FontStyle.Regular);
		}

		private void btnFind_Click(object sender, EventArgs e)
		{

		}
	}




}
