namespace IcaZip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.makeFirstMove = new System.Windows.Forms.Button();
            this.original = new System.Windows.Forms.TextBox();
            this.compress = new System.Windows.Forms.TextBox();
            this.charList = new System.Windows.Forms.ListBox();
            this.countList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupLowest = new System.Windows.Forms.Button();
            this.tv = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.tempBinary = new System.Windows.Forms.TextBox();
            this.dict = new System.Windows.Forms.ListBox();
            this.dictValue = new System.Windows.Forms.ListBox();
            this.transverseTree = new System.Windows.Forms.Button();
            this.CharCounter = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makeFirstMove
            // 
            this.makeFirstMove.Location = new System.Drawing.Point(1114, 63);
            this.makeFirstMove.Name = "makeFirstMove";
            this.makeFirstMove.Size = new System.Drawing.Size(107, 45);
            this.makeFirstMove.TabIndex = 0;
            this.makeFirstMove.Text = "(1) Count Chars";
            this.makeFirstMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makeFirstMove.UseVisualStyleBackColor = true;
            this.makeFirstMove.Click += new System.EventHandler(this.makeFirstMove_Click);
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(25, 63);
            this.original.Multiline = true;
            this.original.Name = "original";
            this.original.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.original.Size = new System.Drawing.Size(354, 165);
            this.original.TabIndex = 2;
            this.original.Text = resources.GetString("original.Text");
            // 
            // compress
            // 
            this.compress.Location = new System.Drawing.Point(25, 263);
            this.compress.Multiline = true;
            this.compress.Name = "compress";
            this.compress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.compress.Size = new System.Drawing.Size(354, 213);
            this.compress.TabIndex = 3;
            // 
            // charList
            // 
            this.charList.FormattingEnabled = true;
            this.charList.ItemHeight = 15;
            this.charList.Location = new System.Drawing.Point(796, 12);
            this.charList.Name = "charList";
            this.charList.Size = new System.Drawing.Size(67, 379);
            this.charList.TabIndex = 4;
            // 
            // countList
            // 
            this.countList.FormattingEnabled = true;
            this.countList.ItemHeight = 15;
            this.countList.Location = new System.Drawing.Point(869, 12);
            this.countList.Name = "countList";
            this.countList.Size = new System.Drawing.Size(67, 379);
            this.countList.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Compress (Base64)";
            // 
            // GroupLowest
            // 
            this.GroupLowest.Location = new System.Drawing.Point(1114, 113);
            this.GroupLowest.Name = "GroupLowest";
            this.GroupLowest.Size = new System.Drawing.Size(143, 71);
            this.GroupLowest.TabIndex = 8;
            this.GroupLowest.Text = "(2) GroupLowest (while charList.count >0)";
            this.GroupLowest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupLowest.UseVisualStyleBackColor = true;
            this.GroupLowest.Click += new System.EventHandler(this.GroupLowest_Click);
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(402, 12);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(388, 388);
            this.tv.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1114, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Process (1,2,3)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tempBinary
            // 
            this.tempBinary.Location = new System.Drawing.Point(402, 406);
            this.tempBinary.Multiline = true;
            this.tempBinary.Name = "tempBinary";
            this.tempBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tempBinary.Size = new System.Drawing.Size(860, 70);
            this.tempBinary.TabIndex = 11;
            // 
            // dict
            // 
            this.dict.FormattingEnabled = true;
            this.dict.ItemHeight = 15;
            this.dict.Location = new System.Drawing.Point(942, 12);
            this.dict.Name = "dict";
            this.dict.Size = new System.Drawing.Size(43, 379);
            this.dict.TabIndex = 12;
            this.dict.SelectedIndexChanged += new System.EventHandler(this.dict_SelectedIndexChanged);
            // 
            // dictValue
            // 
            this.dictValue.FormattingEnabled = true;
            this.dictValue.ItemHeight = 15;
            this.dictValue.Location = new System.Drawing.Point(991, 12);
            this.dictValue.Name = "dictValue";
            this.dictValue.Size = new System.Drawing.Size(104, 379);
            this.dictValue.TabIndex = 13;
            // 
            // transverseTree
            // 
            this.transverseTree.Location = new System.Drawing.Point(1114, 190);
            this.transverseTree.Name = "transverseTree";
            this.transverseTree.Size = new System.Drawing.Size(117, 45);
            this.transverseTree.TabIndex = 14;
            this.transverseTree.Text = "(3) Transverse Tree";
            this.transverseTree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transverseTree.UseVisualStyleBackColor = true;
            this.transverseTree.Click += new System.EventHandler(this.transverseTree_Click);
            // 
            // CharCounter
            // 
            this.CharCounter.Enabled = true;
            this.CharCounter.Interval = 1000;
            this.CharCounter.Tick += new System.EventHandler(this.CharCounter_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Save to File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(106, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "is base 64?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(266, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Read from file";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.transverseTree);
            this.Controls.Add(this.dictValue);
            this.Controls.Add(this.dict);
            this.Controls.Add(this.tempBinary);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.GroupLowest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countList);
            this.Controls.Add(this.charList);
            this.Controls.Add(this.compress);
            this.Controls.Add(this.original);
            this.Controls.Add(this.makeFirstMove);
            this.Name = "Form1";
            this.Text = "IcaZip - The simple text compressor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button makeFirstMove;
        private TextBox original;
        private TextBox compress;
        private ListBox charList;
        private ListBox countList;
        private Label label1;
        private Label label2;
        private Button GroupLowest;
        private TreeView tv;
        private Button button1;
        private TextBox tempBinary;
        private ListBox dict;
        private ListBox dictValue;
        private Button transverseTree;
        private System.Windows.Forms.Timer CharCounter;
        private Button button2;
        private CheckBox checkBox1;
        private Button button3;
    }
}