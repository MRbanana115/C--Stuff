// Project : Txt FIle to list
// Jan 29, 2024
// By Brian Banas
//
// Form type - Form definition - Main Form
// ///////////////////////////////////////////////////////////////////////////

/*
    - created Form
    - added drag & drop
    - added func so we can get all words into a hash set and display it
    - added buttons so a person can copy the nessasary verson of the list they need
    - added the ability for the user to redo there word get with a different word length
 */
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

namespace txt_to_List
{
    public partial class Form1 : Form
    {
        #region Vars
        /// <summary>
        /// raw data from the text file if the user wants to get different words with different lengths
        /// </summary>
        List<string> rawData = new List<string>();
        /// <summary>
        /// list of all of our words
        /// </summary>
        HashSet<string> Words = new HashSet<string>();
        /// <summary>
        /// wantd word length
        /// </summary>
        int WordLength = 4;
        #endregion
        #region constructor
        public Form1()
        {
            InitializeComponent();
            //drop area events
            L_Drop.DragOver += DragedOver;
            L_Drop.DragDrop += Dropped;

            //button events
            B_Copy.Click += RawCopy;
            B_ListConv.Click += ToList;

            //change word length
            n_value.Click += WordLengthChanged;
        }
        #endregion
        #region Drag and drop
        //Drag and drop func is from https://www.c-sharpcorner.com/blogs/drag-and-drop-file-on-windows-forms1
        public void DragedOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
        /// <summary>
        /// when user drags a file in we will take it and 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Dropped (object sender, DragEventArgs e)
        {
            //all files given to use
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  

            //if the files are real files
            if (files != null && files.Any())
            {
                //try catch to make sure the file is a txt and if not we throw an error
                try
                {
                    //try to get the raw data
                    rawData = File.ReadLines(files[0]).ToList();
                }
                catch
                {
                    //show our waning and stop this function from running
                    L_warning.Visible = true;
                    return;
                }
                //send the data to be refined
                RefineData(rawData.ToArray());

                //set warning visability to false so we dont see the message
                L_warning.Visible = false;
            }
        }
        #endregion
        #region Change word length
        /// <summary>
        /// take the new word length and rerun the data through it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WordLengthChanged(object sender, EventArgs e)
        {
            //get new word length
            WordLength = (int)n_value.Value;
            //refine data
            RefineData(rawData.ToArray());
        }
        #endregion
        #region Raw Data To List
        /// <summary>
        /// refine the data so we get only the words in the file that are the wanted caracters long
        /// </summary>
        /// <param name="Data"></param>
        public void RefineData(string[] Data)
        {
            //clear word list
            Words.Clear();
            //get all lines form text 
            foreach (string line in Data)
                //get each word in a line
                foreach (string word in line.Trim().Split(' '))
                    //if the word is equal to our wanted length we will add it to the collection
                    if (word.Trim().Length == WordLength)
                        Words.Add(word.Trim().ToUpper());

            //clear results
            TB_results.Clear();
            //display all words for output
            string display = "";
            foreach (string word in Words)
                display += word + "\r\n";
            TB_results.Text = display;
            //show word count
            L_WordCount.Text = "Word count is : " + Words.Count;
            //enable buttons
            B_Copy.Enabled = true;
            B_ListConv.Enabled = true;
        }
        #endregion
        #region Button handlers
        /// <summary>
        /// when called we will give the user the data as a string with a space between the words and give it to the users clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RawCopy(object sender, EventArgs e)
        {
            string output = "";

            foreach (string word in Words)
                output += word + " ";

            //add string to the clip board
            Clipboard.SetText(output);
        }
        /// <summary>
        /// when called we will use the data to makes a hashset with the data as its defult data and give it to the users clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ToList(object sender, EventArgs e)
        {
            //init output with our Hashset start
            string output = "HashSet<string> Words = new HashSet<string>(){";

            //add all of our words to a string
            foreach (string word in Words)
                output += $"\"{word}\", ";
            //remove the last comman
            output = output.Remove(output.Length - 2);
            //add the final bit to the formate
            output += "};";
            //add string to the clip board
            Clipboard.SetText(output);

        }
        #endregion
    }
}
