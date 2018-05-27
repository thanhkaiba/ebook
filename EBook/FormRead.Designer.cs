using System;
using System.Drawing;
using System.Windows.Forms;

namespace EBook
{
    partial class FormRead
    {
        private System.Windows.Forms.RichTextBox Content;
         
        private bool favor = false;

        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        


        private void InitializeComponent()
        {
            this.Content = new System.Windows.Forms.RichTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnFavor = new System.Windows.Forms.Button();
            this.cbBookmark = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.rtbCurentPage = new System.Windows.Forms.RichTextBox();
            this.lbOfPage = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbChapter = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.ForeColor = System.Drawing.Color.Black;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(929, 491);
            this.Content.TabIndex = 6;
            this.Content.Text = "ahihi";
            this.Content.TextChanged += new System.EventHandler(this.Content_TextChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(929, 35);
            this.panel10.TabIndex = 13;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnFavor);
            this.panel11.Controls.Add(this.cbBookmark);
            this.panel11.Controls.Add(this.button2);
            this.panel11.Controls.Add(this.button1);
            this.panel11.Controls.Add(this.btnHome);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(434, 35);
            this.panel11.TabIndex = 17;
            // 
            // btnFavor
            // 
            this.btnFavor.FlatAppearance.BorderSize = 0;
            this.btnFavor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFavor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFavor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavor.Image = global::EBook.Properties.Resources.starborder;
            this.btnFavor.Location = new System.Drawing.Point(388, -3);
            this.btnFavor.Name = "btnFavor";
            this.btnFavor.Size = new System.Drawing.Size(41, 41);
            this.btnFavor.TabIndex = 23;
            this.btnFavor.UseVisualStyleBackColor = true;
            this.btnFavor.Click += new System.EventHandler(this.btnFavor_Click);
            // 
            // cbBookmark
            // 
            this.cbBookmark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbBookmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBookmark.ForeColor = System.Drawing.Color.White;
            this.cbBookmark.FormattingEnabled = true;
            this.cbBookmark.Location = new System.Drawing.Point(196, 7);
            this.cbBookmark.Name = "cbBookmark";
            this.cbBookmark.Size = new System.Drawing.Size(186, 21);
            this.cbBookmark.TabIndex = 22;
            this.cbBookmark.Text = "Danh sách chỉ mục";
            this.cbBookmark.SelectedIndexChanged += new System.EventHandler(this.cbBookmark_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(118, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Màu nền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Màu chữ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::EBook.Properties.Resources.homebtn1;
            this.btnHome.Location = new System.Drawing.Point(-1, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 35);
            this.btnHome.TabIndex = 8;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnZoomIn);
            this.panel12.Controls.Add(this.btnZoomOut);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(556, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(102, 35);
            this.panel12.TabIndex = 10;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Image = global::EBook.Properties.Resources.addbtn;
            this.btnZoomIn.Location = new System.Drawing.Point(58, 0);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(35, 35);
            this.btnZoomIn.TabIndex = 11;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Image = global::EBook.Properties.Resources.subbtn;
            this.btnZoomOut.Location = new System.Drawing.Point(3, 0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(35, 35);
            this.btnZoomOut.TabIndex = 10;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbSearch);
            this.panel6.Controls.Add(this.btnSearch);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(658, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(271, 35);
            this.panel6.TabIndex = 16;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.tbSearch.Location = new System.Drawing.Point(3, 8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(219, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::EBook.Properties.Resources.ic_search1;
            this.btnSearch.Location = new System.Drawing.Point(228, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 526);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(929, 41);
            this.panel7.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DimGray;
            this.panel9.Controls.Add(this.btnPrev);
            this.panel9.Controls.Add(this.btnFirst);
            this.panel9.Controls.Add(this.btnLast);
            this.panel9.Controls.Add(this.btnNext);
            this.panel9.Controls.Add(this.rtbCurentPage);
            this.panel9.Controls.Add(this.lbOfPage);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(592, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 41);
            this.panel9.TabIndex = 18;
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(75, 1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(41, 41);
            this.btnPrev.TabIndex = 27;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(16, 1);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 41);
            this.btnFirst.TabIndex = 26;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(284, 1);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(51, 41);
            this.btnLast.TabIndex = 25;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(234, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(41, 41);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rtbCurentPage
            // 
            this.rtbCurentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtbCurentPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCurentPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbCurentPage.ForeColor = System.Drawing.Color.White;
            this.rtbCurentPage.Location = new System.Drawing.Point(125, 12);
            this.rtbCurentPage.Multiline = false;
            this.rtbCurentPage.Name = "rtbCurentPage";
            this.rtbCurentPage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbCurentPage.Size = new System.Drawing.Size(36, 19);
            this.rtbCurentPage.TabIndex = 2;
            this.rtbCurentPage.Text = "22";
            this.rtbCurentPage.WordWrap = false;
            this.rtbCurentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbCurrentPage_KeyPress);
            // 
            // lbOfPage
            // 
            this.lbOfPage.AutoSize = true;
            this.lbOfPage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOfPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbOfPage.Location = new System.Drawing.Point(170, 12);
            this.lbOfPage.Name = "lbOfPage";
            this.lbOfPage.Size = new System.Drawing.Size(55, 19);
            this.lbOfPage.TabIndex = 0;
            this.lbOfPage.Text = "of 100";
            this.lbOfPage.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.cbChapter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(316, 41);
            this.panel5.TabIndex = 17;
            // 
            // cbChapter
            // 
            this.cbChapter.BackColor = System.Drawing.Color.DimGray;
            this.cbChapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChapter.ForeColor = System.Drawing.Color.White;
            this.cbChapter.FormattingEnabled = true;
            this.cbChapter.Location = new System.Drawing.Point(11, 11);
            this.cbChapter.Name = "cbChapter";
            this.cbChapter.Size = new System.Drawing.Size(252, 21);
            this.cbChapter.TabIndex = 21;
            this.cbChapter.MouseClick += new MouseEventHandler(this.cbChapter_onMouseClick);
            this.cbChapter.SelectionChangeCommitted += new System.EventHandler(this.cbChapter_SelectedIndexChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Content);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 35);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(929, 491);
            this.panel8.TabIndex = 16;
            // 
            // FormRead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 567);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Name = "FormRead";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tên truyện";
            this.Load += new System.EventHandler(this.FormRead_Load);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        private Panel panel10;
        private Panel panel7;
        private Panel panel8;
        private Panel panel6;
        private TextBox tbSearch;
        private Button btnSearch;
        private Panel panel5;
        private Panel panel9;
        private Label lbOfPage;
        private RichTextBox rtbCurentPage;
        private Panel panel11;
        private Button btnHome;
        private Panel panel12;
        private Button btnZoomIn;
        private Button btnZoomOut;
        private Button button2;
        private Button button1;
        private Button btnPrev;
        private Button btnFirst;
        private Button btnLast;
        private Button btnNext;
        private ComboBox cbBookmark;
        private ComboBox cbChapter;
        private Button btnFavor;
    }
}