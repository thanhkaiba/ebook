using CheckRule;
using EBook.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SearchKey;
using System.Text.RegularExpressions;
using System.Threading;

namespace EBook
{
    public partial class FormRead : Form
    {

        int[] resultsIndex;
        int temp = 1;
        Regex regex = null;
        MatchCollection matches;
        private int number = 1;
        private int index = 0;
        Boolean textChanged = false;
        Type res = typeof(Resources);
        Resources r = new Resources();
        public FormRead(string title, string novel)
        {
            this.novel = novel;
            this.title = title;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormRead_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
       {
            this.buttonSearch.Image = global::EBook.Properties.Resources.kripto_search_b;
            textChanged = true;
            matches = null;
            regex = null;
            temp = 1;
            index = 0;
            resultsIndex = null;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
           
            if (textChanged)
            {
                string[] key = textBoxSearch.Text.Trim().Split(' ');
                string pattern = "[^.-:;!\\n?].*(";
                for (int i = 0; i < key.Length; i++)
                {
                    pattern += "\\W?" + key[i] + "\\W.*";
                    if (i != key.Length - 1)
                        pattern += "|";
                }
                pattern += ")+.*[.:;!\\n?]";
                regex = new Regex(pattern);
                
            }

            if ((matches == null ||index == matches.Count) && temp <= Number_Chapter)
            {
              
                string ChapterContent = "";
                index = 0;
                do
                {
                    string Chapter = novel + "_c" + temp;
                    ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
                    matches = null;
                    
                    
                    if (regex.IsMatch(ChapterContent))
                    {
                        matches = regex.Matches(ChapterContent);
                        Order();
                        if (temp != number - 1)
                        {
                            this.Content.Text = ChapterContent;
                            markText(ChapterContent);
                           
                        }
                        temp++;
                        break;
                    }
                    temp++;
                } while (temp <= Number_Chapter);
            }
                  
            if (matches != null && matches.Count > 0)
            {

                if (index < matches.Count)
                {
                    this.Content.Select(matches[resultsIndex[index]].Index, matches[resultsIndex[index]].Length);
                    this.Content.Focus();
                    this.buttonSearch.Image = global::EBook.Properties.Resources.kripto_search_next2;
                    index++; 
                }
            }
            else
            {
                this.buttonSearch.Image = global::EBook.Properties.Resources.kripto_search_b;
            }
            textChanged = false;

        }
        

        private void chapterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel LinkChapter = sender as LinkLabel;
            number = int.Parse(LinkChapter.Name);
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            string Chapter = novel + "_c" + number;
            string ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;

            this.Content.Text = ChapterContent;
            markText(ChapterContent);
            
            if (number < Number_Chapter)
                number++;
            else
                number = 1;
            textBoxSearch.Focus();
        }

        private void markText(string ChapterContent)
        {
            int len = Content.TextLength;
            string[] wrongWords = CheckVietnamese.Check(ChapterContent);
           
            foreach (string wrongWord in wrongWords)
            {
                int index = 0;

                int lastIndex = Content.Text.LastIndexOf(wrongWord);
                while (index < lastIndex)
                {

                    int indexTemp = Content.Find(wrongWord, index, len, RichTextBoxFinds.None);

                    Content.SelectionBackColor = Color.Red;

                    index = indexTemp + 1;

                }
            }
        }

        private void Order() 
        {
            string[] keys = textBoxSearch.Text.Trim().Split(' ');
            int len = matches.Count;
            int[] priority = new int[len];
            resultsIndex = new int[len];
            for (int i = 0; i < len; i++)
            {
                int n = 0;
                foreach(string key in keys)
                {
                    if (matches[i].Value.Contains(key))
                    {
                        n++;
                    }
                }
                priority[i] = n;

            }
            for (int i = 0; i < len; i++)
            {
                resultsIndex[i] = i;
            }
            Array.Sort(priority, resultsIndex);
            Array.Reverse(resultsIndex);  
        }
    }
}
