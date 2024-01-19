namespace Project_TextEditor
{
    partial class TextWire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextWire));
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.ofd2 = new System.Windows.Forms.OpenFileDialog();
            this.fntDialog = new System.Windows.Forms.FontDialog();
            this.clDialog = new System.Windows.Forms.ColorDialog();
            this.setFont = new System.Windows.Forms.Button();
            this.setColor = new System.Windows.Forms.Button();
            this.sfDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.Dark = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbText.Location = new System.Drawing.Point(0, 81);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(1177, 753);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            this.rtbText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tbFileName
            // 
            this.tbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFileName.Location = new System.Drawing.Point(0, 12);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(722, 26);
            this.tbFileName.TabIndex = 1;
            this.tbFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnOpen.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpen.ForeColor = System.Drawing.Color.Yellow;
            this.btnOpen.Location = new System.Drawing.Point(1091, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 45);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofd2
            // 
            this.ofd2.FileName = "openFileDialog1";
            this.ofd2.Filter = "\"Text files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*\"";
            // 
            // setFont
            // 
            this.setFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.setFont.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setFont.ForeColor = System.Drawing.Color.Yellow;
            this.setFont.Location = new System.Drawing.Point(913, 12);
            this.setFont.Name = "setFont";
            this.setFont.Size = new System.Drawing.Size(85, 45);
            this.setFont.TabIndex = 3;
            this.setFont.Text = "Font";
            this.setFont.UseVisualStyleBackColor = false;
            this.setFont.Click += new System.EventHandler(this.setFont_Click);
            // 
            // setColor
            // 
            this.setColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.setColor.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.setColor.ForeColor = System.Drawing.Color.Yellow;
            this.setColor.Location = new System.Drawing.Point(1004, 12);
            this.setColor.Name = "setColor";
            this.setColor.Size = new System.Drawing.Size(85, 45);
            this.setColor.TabIndex = 4;
            this.setColor.Text = "Color";
            this.setColor.UseVisualStyleBackColor = false;
            this.setColor.Click += new System.EventHandler(this.setColor_Click);
            // 
            // sfDialog
            // 
            this.sfDialog.Filter = "Text files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf|All Files (*.*)|*.*";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Yellow;
            this.btnSave.Location = new System.Drawing.Point(819, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 45);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Dark
            // 
            this.Dark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.Dark.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Dark.ForeColor = System.Drawing.Color.Yellow;
            this.Dark.Location = new System.Drawing.Point(728, 12);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(85, 45);
            this.Dark.TabIndex = 6;
            this.Dark.Text = "Mode";
            this.Dark.UseVisualStyleBackColor = false;
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 804);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1178, 32);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(192, 25);
            this.toolStripStatusLabel1.Text = "Status Level For Words";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel2.Text = "Status Level For Lines";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // TextWire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1178, 836);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.setColor);
            this.Controls.Add(this.setFont);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.rtbText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextWire";
            this.Text = "TextWire";
            this.Load += new System.EventHandler(this.TextWire_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog ofd2;
        private System.Windows.Forms.FontDialog fntDialog;
        private System.Windows.Forms.ColorDialog clDialog;
        private System.Windows.Forms.Button setFont;
        private System.Windows.Forms.Button setColor;
        private System.Windows.Forms.SaveFileDialog sfDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button Dark;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

