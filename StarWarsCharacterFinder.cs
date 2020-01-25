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
	/* Name: Reggie Telemaque  * Date: 01/21/2020  
	 *   
	 * 
	 * Program: Star Wars Character Finder  
	 * 
	 * 
	 *  Purpose: A program that a user can find a character in a array of star wars characters and find them by way of a search box.  
	 */

	public partial class StarWarsCharacterFinder : Form
	{
		PrivateFontCollection starwarsfont = new PrivateFontCollection();

		public StarWarsCharacterFinder()
		{
			InitializeComponent();
		}
		private void AddFont(string font)
		{
			// Add Fonts
			starwarsfont.AddFontFile(font);
		}

		private void LoadFonts()
		{
			AddFont(Path.Combine(Directory.GetCurrentDirectory(), "Starjedi.ttf"));

			//lstCharacters.Font = new Font(starwarsfont.Families[1], 8, FontStyle.Regular);
			//txtCharacterName.Font = new Font(starwarsfont.Families[1], 8, FontStyle.Regular);
			//btnFind.Font = new Font(starwarsfont.Families[1], 8, FontStyle.Regular);
		}
		private void LoadCharacters()
		{
			StreamReader inputFile;
			string fileName;

			fileName = Path.Combine(Directory.GetCurrentDirectory(), "StarWarsCharacters.csv");
			inputFile = File.OpenText(fileName);

			

			
		}

		private void StarWarsCharacterFinder_Load(object sender, EventArgs e)
		{
			LoadCharacters();
			LoadFonts();


			string[] starwarscharacters = new string[114];

			starwarscharacters[0] = "Anakin";
			starwarscharacters[1] = "Darth Vader";

		}

	}
}


