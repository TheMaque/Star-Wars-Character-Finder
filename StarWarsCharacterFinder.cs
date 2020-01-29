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

		private void PrintArrayContents(ref string[] PrintArray)
		{
			foreach (string StarWarsCharacter in PrintArray)
			{
				lstCharacters.Items.Add(StarWarsCharacter);
			}

		}
	
		private void LoadCharacters(ref string[] StarWarsCharacters)
		{
			StreamReader inputFileReader = File.OpenText("StarWarsCharacters.csv");
			int index = 0;
			while (!inputFileReader.EndOfStream) 
			{
				StarWarsCharacters[index] = inputFileReader.ReadLine();
				index++;
			}
			inputFileReader.Close();
			inputFileReader.Dispose();

		}



		private void StarWarsCharacterFinder_Load(object sender, EventArgs e)
		{
			
			string[] StarWarsCharacters = new string[114];
			LoadCharacters(ref StarWarsCharacters);
			PrintArrayContents(ref StarWarsCharacters);
			
		}

		private void btnFind_Click(object sender, EventArgs e)
		{

		}
	}
}


