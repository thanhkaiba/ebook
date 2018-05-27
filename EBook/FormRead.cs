
using EBook.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace EBook
{
    public partial class FormRead : Form
    {
        private Novel novel;
        private int[] indexArray;
        private List<Page> bookmarks = new List<Page>();
        
        private int currentChapter = 0;
        private int currentPageIndex = 0;
        private int totalPage = 0;
        int[] resultsIndex;
        //int temp = 1;
        //Regex regex = null;
        MatchCollection matches;
        //private int number = 1;
        //private int index = 0;
      //  Boolean textChanged = false;
        
       
        public FormRead(Novel novel)
        {
            this.novel = novel;
            string connetionString = "Data Source=DESKTOP-DAUSDI2\\SQLEXPRESS;Initial Catalog=kimdungnovel;Integrated Security=True;MultipleActiveResultSets=true";
            SqlConnection cnn = new SqlConnection(connetionString);
            try {
                cnn.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM chapter WHERE idnovel = '" + novel.id + "';", cnn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    int pageNumber = 1;
                    while (reader.Read())
                    {
                        Chapter chapter = new Chapter();
                        chapter.id = reader.GetInt32(0);
                        chapter.number = reader.GetInt32(1);
                        chapter.name = reader.GetString(2);
                        chapter.pages = new List<Page>();
                        SqlCommand subCommand = new SqlCommand("SELECT * FROM page WHERE idchapter = '" + chapter.id + "';", cnn);
                        using (SqlDataReader subReader = subCommand.ExecuteReader())
                        {
                            while (subReader.Read())
                            {
                                Page page = new Page();
                                page.id = subReader.GetInt32(0);
                                page.content = subReader.GetString(1);
                                page.idChapter = chapter.number - 1;
                                page.pageNumber = pageNumber++;
                                page.bookmark = (subReader.GetInt32(3) == 1);
                                
                                if (page.bookmark)
                                {
                                    page.name = subReader.GetString(4);
                                    bookmarks.Add(page);
                                }
                                chapter.pages.Add(page);
                            }
                        }
                        novel.chapters.Add(chapter);
                    }
                }

                cnn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Can't load novel's content! ");
            }
            InitializeComponent();
            addContent();
            
        }

        public void addContent()
        {
            
            
            indexArray = new int[novel.chapters.Count];
            
            for (int i = 0; i < novel.chapters.Count; i++) {
                indexArray[i] = totalPage - 1;
                totalPage += novel.chapters[i].pages.Count;
                this.cbChapter.Items.Add(novel.chapters[i].name);
                
            }
            foreach (Page bookmark in bookmarks)
            {
                this.cbBookmark.Items.Add(bookmark.name);
            }
            setContent(currentChapter, currentPageIndex);
            this.lbOfPage.Text = "of " + totalPage.ToString();
            

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
            //this.btnSearch.Image = global::EBook.Properties.Resources.kripto_search_b;
            //textChanged = true;
            //matches = null;
            //regex = null;
            //temp = 1;
            //index = 0;
            //resultsIndex = null;
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

        //private void buttonSearch_Click(object sender, EventArgs e)
        //{
            
           
        //    if (textChanged)
        //    {
        //        string[] key = tbSearch.Text.Trim().Split(' ');
        //        string pattern = "[^.-:;!\\n?].*(";
        //        for (int i = 0; i < key.Length; i++)
        //        {
        //            pattern += "\\W?" + key[i] + "\\W.*";
        //            if (i != key.Length - 1)
        //                pattern += "|";
        //        }
        //        pattern += ")+.*[.:;!\\n?]";
        //        regex = new Regex(pattern);
                
        //    }

        //    if ((matches == null ||index == matches.Count) && temp <= Number_Chapter)
        //    {
              
        //        string ChapterContent = "";
        //        index = 0;
        //        do
        //        {
        //            string Chapter = novel + "_c" + temp;
        //            ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;
        //            matches = null;
                    
                    
        //            if (regex.IsMatch(ChapterContent))
        //            {
        //                matches = regex.Matches(ChapterContent);
        //                Order();
        //                if (temp != number - 1)
        //                {
        //                    this.Content.Text = ChapterContent;
        //                    markText(ChapterContent);
                           
        //                }
        //                temp++;
        //                break;
        //            }
        //            temp++;
        //        } while (temp <= Number_Chapter);
        //    }
                  
        //    if (matches != null && matches.Count > 0)
        //    {

        //        if (index < matches.Count)
        //        {
        //            this.Content.Select(matches[resultsIndex[index]].Index, matches[resultsIndex[index]].Length);
        //            this.Content.Focus();
        //            this.btnSearch.Image = global::EBook.Properties.Resources.kripto_search_next2;
        //            index++; 
        //        }
        //    }
        //    else
        //    {
        //        this.btnSearch.Image = global::EBook.Properties.Resources.kripto_search_b;
        //    }
        //    textChanged = false;

        //}
        

        //private void chapterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    LinkLabel LinkChapter = sender as LinkLabel;
        //    number = int.Parse(LinkChapter.Name);
        //    this.Content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
        //    string Chapter = novel + "_c" + number;
        //    string ChapterContent = res.GetProperty(Chapter).GetValue(r) as String;

        //    this.Content.Text = ChapterContent;
        //    markText(ChapterContent);
            
        //    if (number < Number_Chapter)
        //        number++;
        //    else
        //        number = 1;
        //    tbSearch.Focus();
        //}

        private void markText(string pageContent)
        {
            int len = Content.TextLength;
            string[] wrongWords = CheckVietnamese.Check(pageContent);
           
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
            string[] keys = tbSearch.Text.Trim().Split(' ');
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void Content_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
        

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            Font currentFont = Content.Font;
            Content.Font = new System.Drawing.Font("Microsoft Sans Serif", currentFont.Size - 1, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            Font currentFont = Content.Font;
            Content.Font = new System.Drawing.Font("Microsoft Sans Serif", currentFont.Size + 1, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            Content.ForeColor = color.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            Content.BackColor = color.Color;
        }

       
        private void btnFavor_Click(object sender, EventArgs e)
        {
            favor = !favor;
            if (!favor)
            {
                btnFavor.Image = global::EBook.Properties.Resources.starborder;
                
            }
            else
            {
                btnFavor.Image = global::EBook.Properties.Resources.star;
                
            }
        }

        void rtbCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                int selectedPage = Int32.Parse(rtbCurentPage.Text);
                if (selectedPage > totalPage)
                {
                    btnLast_Click(sender, e);
                } else
                {
                    
                    rtbCurentPage.Text = (selectedPage).ToString();
                    if (selectedPage - 1 > indexArray[indexArray.Length-1])
                    {
                        currentChapter = indexArray.Length - 1;
                        currentPageIndex = selectedPage - 2 - indexArray[indexArray.Length - 1];
                    } else
                    {
                        for (int i = 0; i < indexArray.Length; i++)
                        {
                            if (selectedPage - 1 < indexArray[i])
                            {
                                currentChapter = i - 1;
                                currentPageIndex = selectedPage - 2 - indexArray[i - 1];
                                break;
                            }
                            else if (selectedPage == indexArray[i])
                            {
                                currentChapter = i;
                                currentPageIndex = 0;
                                break;
                            }
                        }
                    }

                    setContent(currentChapter, currentPageIndex);

                } 

            }
            else if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            

            
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentChapter + 1 < novel.chapters.Count)
            {
                if (currentPageIndex + 1 == novel.chapters[currentChapter].pages.Count)
                {
                    currentChapter++;
                    currentPageIndex = -1;
                    
                } 
              
            } else
            {
                if (currentPageIndex + 1== novel.chapters[currentChapter].pages.Count)
                {
                    return;
                }
            }
            setContent(currentChapter, currentPageIndex + 1);
            
            currentPageIndex++;
            
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentChapter > 0)
            {
                if (currentPageIndex == 0)
                {
                    currentChapter--;
                    currentPageIndex = novel.chapters[currentChapter].pages.Count;

                }

            }
            else
            {
                if (currentPageIndex == 0)
                {
                    return;
                }
            }
            setContent(currentChapter, currentPageIndex - 1);
           
            currentPageIndex--;
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentChapter = novel.chapters.Count - 1; 
            currentPageIndex = novel.chapters[currentChapter].pages.Count - 1;
            setContent(currentChapter, currentPageIndex);
            
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentChapter = 0;
            
            currentPageIndex = 0;
            setContent(currentChapter, currentPageIndex);
            
        }

        private void setContent(int chapter, int pageIndex)
        {
            this.Content.Text = novel.chapters[chapter].pages[pageIndex].content;
            if (novel.chapters[chapter].pages[pageIndex].bookmark)
            {
                favor = true;
                btnFavor.Image = global::EBook.Properties.Resources.star;
            }
            else
            {
                favor = false;
                btnFavor.Image = global::EBook.Properties.Resources.starborder;
            }
         
            cbChapter.SelectedIndex = cbChapter.FindStringExact(novel.chapters[chapter].name);
            this.rtbCurentPage.Text = novel.chapters[chapter].pages[pageIndex].pageNumber.ToString();
            markText(Content.Text);
            
        }

     

        private void cbBookmark_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pageIndex = this.cbBookmark.SelectedIndex;
            Page page = bookmarks[pageIndex];
            currentChapter = page.idChapter;
            currentPageIndex = page.pageNumber - 2 - indexArray[currentChapter];
            setContent(currentChapter, currentPageIndex);
         

        }

        private void cbChapter_onMouseClick(object sender, MouseEventArgs e)
        {
       
        }

        private void cbChapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentChapter = this.cbChapter.SelectedIndex;
            currentPageIndex = 0;
            setContent(currentChapter, currentPageIndex);
        }
    }
}
