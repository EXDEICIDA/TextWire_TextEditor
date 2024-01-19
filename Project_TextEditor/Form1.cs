using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  //You see we are using this if we didnt we could get potential error

namespace Project_TextEditor
{
    public partial class TextWire : Form
    {

        //We are declaring here a avriable that will be used in coming darkmode settings
        private bool isDarkMode = false;
        // Declare isDarkMode at the class level

        //too strip adjustments
        private ToolStripStatusLabel toolStripStatusLabelWordCount;
        private ToolStripStatusLabel toolStripStatusLabelLineCount;
        public TextWire()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Initialize ToolStripStatusLabel controls
            toolStripStatusLabelWordCount = new ToolStripStatusLabel("Words: 0");
            toolStripStatusLabelLineCount = new ToolStripStatusLabel("Lines: 0");

            // Add ToolStripStatusLabel controls to statusStrip1
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelWordCount, toolStripStatusLabelLineCount });

            //We are adding a consturctor right here to ensure the event hadler 
            Dark.Click += Dark_Click;
            //event handler didnt work exactly i epexcted so i wired them up manually 
            Dark.Click += new EventHandler(Dark_Click);

            //setting the initial theme
            // Set the initial theme (light or dark)
            isDarkMode = false; // Change this to true if you want to start with dark mode
            ApplyTheme();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //First we should handle the open file dilaog
            // OpenFileDialog ofd = new OpenFileDialog();
            ofd2.Filter = "Text files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*"; /*means all now we are giving the line a logic which it can filter the txt files
                                                                         * but alos we are giving the option it can open all the txt files
                                                                         */

            if (ofd2.ShowDialog() == DialogResult.OK)
            {




                try
                {
                    // First, handle the open file dialog
                    ofd2.Filter = "Text files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*";

                    if (ofd2.ShowDialog() == DialogResult.OK)
                    {
                        if (ofd2.FileName.EndsWith("rtf"))
                        {
                            tbFileName.Text = ofd2.FileName;
                            rtbText.Text = File.ReadAllText(ofd2.FileName);
                            StreamReader sr = File.OpenText(ofd2.FileName);
                            rtbText.Rtf = sr.ReadToEnd();
                            sr.Close();
                        }
                        else if (ofd2.FileName.EndsWith("txt"))
                        {
                            tbFileName.Text = ofd2.FileName;
                            rtbText.Text = File.ReadAllText(ofd2.FileName);
                        }
                        else
                        {
                            // Handle unsupported file types
                            MessageBox.Show("Unsupported file type. Please select a .txt or .rtf file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle other exceptions
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (ofd2.FileName.EndsWith("rtf"))
                {
                    //We are taking the file name string and if this file name  which ends with rtf 
                    //true as long as satisfies the condition right here  if (ofd2.FileName.EndsWith("rtf")); 

                    tbFileName.Text = ofd2.FileName;
                    rtbText.Text = File.ReadAllText(ofd2.FileName);
                    StreamReader sr;
                    string fname;
                    fname = ofd2.FileName;
                    tbFileName.Text = fname;
                    sr = File.OpenText(fname);
                    rtbText.Rtf = sr.ReadToEnd();

                }
                else if (ofd2.FileName.EndsWith("txt"))
                {
                    tbFileName.Text = ofd2.FileName;
                    rtbText.Text = File.ReadAllText(ofd2.FileName);

                }


            }
                          UpdateStatusBar();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextbox right here enables us to write things or edit
            UpdateStatusBar();
        }

        private void TextWire_Load(object sender, EventArgs e)
        {
            //Main Load Event Handler 

          



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void setFont_Click(object sender, EventArgs e)
        {
            fntDialog.ShowDialog();
            rtbText.SelectionFont = fntDialog.Font;
            UpdateStatusBar();
        }

        private void setColor_Click(object sender, EventArgs e)
        {   //calling for the color dialog
            clDialog.ShowDialog();
            rtbText.SelectionColor = clDialog.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfDialog.ShowDialog() == DialogResult.OK)
            {
                //here we are calling for the save file dialog which we included
                if (Path.GetExtension(sfDialog.FileName) == ".txt")
                {
                    //file nme property could be extracted using Path.GetExtension//
                    rtbText.SaveFile(sfDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                if (Path.GetExtension(sfDialog.FileName) == ".rtf")
                {
                    //file name property could be extracted using Path.GetExtension//
                    rtbText.SaveFile(sfDialog.FileName, RichTextBoxStreamType.RichText);
                    //also here we are determining the same exact thing only for it to be in rtf file format
                }
            }
        }
        //del
        private void ToggleDarkMode()
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();

        }

        //Creating a dark mode Method right her e
        //TODO: Modify Acordingly
        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                // Dark mode colors
                this.BackColor = Color.FromArgb(28, 28, 28);
                rtbText.BackColor = Color.FromArgb(55, 55, 55);
                rtbText.ForeColor = Color.White;

                statusStrip1.BackColor = Color.FromArgb(28, 28, 28);
                statusStrip1.ForeColor = Color.White;

                // Set colors for ToolStripStatusLabel controls
                toolStripStatusLabelWordCount.ForeColor = Color.White;
                toolStripStatusLabelLineCount.ForeColor = Color.White;
            }
            else
            {
                // Light mode colors
                this.BackColor = SystemColors.Control;
                rtbText.BackColor = SystemColors.Window;
                rtbText.ForeColor = SystemColors.WindowText;

                statusStrip1.BackColor = SystemColors.Control;
                statusStrip1.ForeColor = SystemColors.ControlText;

                // S for ToolStripStatusLabel controls
                toolStripStatusLabelWordCount.ForeColor = SystemColors.ControlText;
                toolStripStatusLabelLineCount.ForeColor = SystemColors.ControlText;
            }
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void UpdateStatusBar()
        {
            int wordCount = GetWordCount(rtbText.Text);
            int lineCount = GetLineCount(rtbText.Text);

            toolStripStatusLabelWordCount.Text = $"Words: {wordCount}";
            toolStripStatusLabelLineCount.Text = $"Lines: {lineCount}";
        }

        private int GetWordCount(string text)
        {
            return text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private int GetLineCount(string text)
        {
            return text.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
