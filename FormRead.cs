using CheckRule;
using EBook.Properties;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EBook
{
    public partial class FormRead : Form
    {

        int[] resultsIndex;
        int temp = 1;
        int startTemp = 1;
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
            number = 1;
            SetCover();
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
            startTemp = 1;
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
                if (textBoxSearch.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Không có từ khóa");
                    return;
                }
                string[] key = textBoxSearch.Text.Trim().Split(' ');
                
                string pattern = "";
                for (int i = 0; i < key.Length; i++)
                {
                    if (HasSpecialChars(key[i])) {
                        key[i] = Regex.Escape(key[i]);
                      
                    }
                  
                    pattern += "\\W?.*" + key[i].ToLower() + "\\W?.*\\W";
                    if (i != key.Length - 1)
                        pattern += "|";
                }
               
                regex = new Regex(pattern, RegexOptions.Multiline);
                matches = regex.Matches(Content.Text.ToLower());
                if (matches!= null && matches.Count > 0)
                {
                    Order();
                }
                startTemp = number-1;
                temp = number;

            }

            

            if ((matches == null || index == matches.Count) && temp != startTemp) 
            {
              
                string ChapterContent = "";
                index = 0;
                do
                {
                    string Chapter = novel + "_c" + temp;
                    ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
                    matches = null;
                   

                    if (regex.IsMatch(ChapterContent.ToLower()))
                    {
                        matches = regex.Matches(ChapterContent.ToLower());
                        Order();
                        this.label_chapter_name.Text = "Hồi " + temp;
                        this.Content.Text = ChapterContent;
                        markText(ChapterContent);   
                        
                        temp++;
                        if (temp > Number_Chapter)
                        {
                            temp = 1;
                        }

                        break;
                    }
                    temp++;
                    if (temp > Number_Chapter)
                    {
                        temp = 1;
                    }
                } while (temp != startTemp);
            }
                  
            if (matches != null && matches.Count > 0)
            {
                number = temp;
                if (number == 1)
                {
                    number = 2;
                }
                if (index < matches.Count)
                {
                    this.label_result_search.Text = "Kết quả " + (index + 1) + "/" + matches.Count + " trong hồi này";
                    this.Content.Select(matches[resultsIndex[index]].Index, matches[resultsIndex[index]].Length);
                    this.Content.Focus();
                    this.buttonSearch.Image = global::EBook.Properties.Resources.kripto_search_next2;
                    index++;
                    
                }
                textChanged = false;

            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp");
                this.buttonSearch.Image = global::EBook.Properties.Resources.kripto_search_b;
                textBox1_TextChanged(sender, e);
                
            }
            

        }
        

        private void chapterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel LinkChapter = sender as LinkLabel;
            number = int.Parse(LinkChapter.Name);
            this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            string Chapter = novel + "_c" + number;
            string ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;

            var data = ChapterContent.Trim();
            int maxLength = 715;

            //Adjust the pages for blanklines
            if (data.Contains("\r\n"))
            {
                string[] stringSeparators = new string[] { "\r\n" };
                string[] lines = data.Split(stringSeparators, StringSplitOptions.None);
                var count = lines.Where(i => i.Equals("") || i.Equals(" ")).Count();

                if (count > 0) maxLength = (11 - lines.Length / count) * 65;
            }

            this.Content.Text = ChapterContent;
            markText(ChapterContent);
            this.label_chapter_name.Text = "Hồi " + number;
            
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

                    int indexTemp = Content.Find(wrongWord, index, len, RichTextBoxFinds.WholeWord);
                   
                    Content.SelectionBackColor = Color.Red;

                    if (indexTemp == -1)
                    {
                        index = lastIndex;
                    } else
                    {
                        index = indexTemp+1;
                    }

                }
            }
        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                buttonSearch_Click(sender, e);
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
                    if (matches[i].Value.ToLower().Contains(key.ToLower()))
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
        private bool HasSpecialChars(string yourString)
        {
            return yourString.Any(ch => !Char.IsLetterOrDigit(ch));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    

}
