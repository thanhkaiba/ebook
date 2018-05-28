using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBook
{
    public partial class FormAddBookmark : Form
    {
        public const int RESULT_OK = 1;
        public const int RESULT_CANCEL = 0;
        private int result = RESULT_CANCEL;
        private string name = "";
        private ErrorProvider nameErrorProvider;

        public FormAddBookmark(string defaultName)
        {
            InitializeComponent();
            this.bookmarkName.Text = defaultName;
            name = defaultName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            
            if (this.bookmarkName.Text.Equals(""))
            {
                nameErrorProvider.SetError(this.bookmarkName, "Name is required!");
            }
            else
            {
                name = this.bookmarkName.Text;
                result = RESULT_OK;
                this.Close();
                this.Dispose();
            }
        }

        public int getResult()
        {
            return result;
        } 

        public string getBookmarkName()
        {
            return name;
        }

        private void bookmarkName_TextChanged(object sender, EventArgs e)
        {
            nameErrorProvider.Dispose();
        }
    }
}
