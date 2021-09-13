using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM9_13.Properties
{
    public partial class InputDialog : Form
    {
        public delegate void TextEventHander(string strText);

        public TextEventHander textHander;

        public event TextEventHander TextEnter;

        public InputDialog()
        {
            InitializeComponent();
        }

        private void InputDialog_Load(object sender, EventArgs e)
        {

        }

        private void click_OK_Click(object sender, EventArgs e)
        {
            if (textHander != null)
            {
                textHander(inputText.Text);
                
                Close();
            }
        }

        private void click_Cancel_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
