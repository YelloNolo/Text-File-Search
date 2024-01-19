namespace FileSearch
{
    partial class FileSearch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.SelectedFileDisplay = new System.Windows.Forms.TextBox();
            this.outputForm = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 509);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 58);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.searchBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectFileBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(819, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(108, 58);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.Location = new System.Drawing.Point(3, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(102, 23);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFileBtn.Location = new System.Drawing.Point(3, 32);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(102, 23);
            this.selectFileBtn.TabIndex = 2;
            this.selectFileBtn.Text = "Open";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchBar);
            this.panel3.Controls.Add(this.SelectedFileDisplay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(774, 58);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // searchBar
            // 
            this.searchBar.AcceptsReturn = true;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar.Location = new System.Drawing.Point(0, 0);
            this.searchBar.Multiline = true;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(774, 38);
            this.searchBar.TabIndex = 3;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // SelectedFileDisplay
            // 
            this.SelectedFileDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SelectedFileDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedFileDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SelectedFileDisplay.Location = new System.Drawing.Point(0, 38);
            this.SelectedFileDisplay.Name = "SelectedFileDisplay";
            this.SelectedFileDisplay.ReadOnly = true;
            this.SelectedFileDisplay.Size = new System.Drawing.Size(774, 20);
            this.SelectedFileDisplay.TabIndex = 2;
            this.SelectedFileDisplay.TextChanged += new System.EventHandler(this.SelectedFile_TextChanged);
            this.SelectedFileDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SelectedFileDisplay_MouseDown);
            // 
            // outputForm
            // 
            this.outputForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputForm.Location = new System.Drawing.Point(0, 0);
            this.outputForm.Multiline = true;
            this.outputForm.Name = "outputForm";
            this.outputForm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputForm.Size = new System.Drawing.Size(927, 509);
            this.outputForm.TabIndex = 1;
            this.outputForm.TextChanged += new System.EventHandler(this.outputForm_TextChanged);
            // 
            // FileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(927, 567);
            this.Controls.Add(this.outputForm);
            this.Controls.Add(this.panel1);
            this.Name = "FileSearch";
            this.Text = "File Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox outputForm;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox SelectedFileDisplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchBar;
    }
}

