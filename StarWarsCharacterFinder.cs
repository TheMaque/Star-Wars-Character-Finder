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

		private void PrintArrayContents(ref string[] PrintArray)
		{
			// Print array to listbox
			foreach (string StarWarsCharacterList in PrintArray)
			{
				lstCharacters.Items.Add(StarWarsCharacterList);
			}

		}
	
		private void LoadCharacters(ref string[] StarWarsCharacters)
		{
			// Read and open CSV into index.
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
			// Make a array of 114 characters in locals
			string[] StarWarsCharacters = new string[114];

			// Load characters from csv file to listbox
			LoadCharacters(ref StarWarsCharacters);

			// Print CSV into array
			PrintArrayContents(ref StarWarsCharacters);
			
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			// Find character after user types
			int index = lstCharacters.FindString(txtCharacterName.Text, -1);
			if (index != -1)
			{
				lstCharacters.SetSelected(index, true);
			}
			else
			{
				// Show message to user if input is not a valid character
				MessageBox.Show("Character not found, try again!", "Error: Character Invalid");
				txtCharacterName.Clear();
			
			}
		}

		private void btntxtClear_Click(object sender, EventArgs e)
		{
			// Clear contents in text box
			txtCharacterName.Clear();
			lstCharacters.ClearSelected();
		}

		private void txtCharacterName_TextChanged(object sender, EventArgs e)
		{
			// Make sure that textbox is full to enable buttons.
			btnFind.Enabled = !string.IsNullOrEmpty(txtCharacterName.Text);
			btntxtClear.Enabled = !string.IsNullOrEmpty(txtCharacterName.Text);

		}
	}
}


