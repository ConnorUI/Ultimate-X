namespace Executer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopFrame = new System.Windows.Forms.Panel();
            this.RemoveTabButton = new System.Windows.Forms.Button();
            this.AddTabButton = new System.Windows.Forms.Button();
            this.MinBtn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SideFrame = new System.Windows.Forms.Panel();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BottomFrame = new System.Windows.Forms.Panel();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AttachBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SideFrame2 = new System.Windows.Forms.Panel();
            this.SideFrame3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visualStudioTabControl1 = new VisualStudioTabControl.VisualStudioTabControl();
            this.Script1 = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.TopFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.BottomFrame.SuspendLayout();
            this.visualStudioTabControl1.SuspendLayout();
            this.Script1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopFrame
            // 
            this.TopFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TopFrame.Controls.Add(this.RemoveTabButton);
            this.TopFrame.Controls.Add(this.AddTabButton);
            this.TopFrame.Controls.Add(this.MinBtn);
            this.TopFrame.Controls.Add(this.Logo);
            this.TopFrame.Controls.Add(this.Title);
            this.TopFrame.Controls.Add(this.CloseBtn);
            this.TopFrame.Location = new System.Drawing.Point(0, 0);
            this.TopFrame.Name = "TopFrame";
            this.TopFrame.Size = new System.Drawing.Size(800, 45);
            this.TopFrame.TabIndex = 0;
            this.TopFrame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopFrame_MouseDown);
            this.TopFrame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopFrame_MouseMove);
            // 
            // RemoveTabButton
            // 
            this.RemoveTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RemoveTabButton.FlatAppearance.BorderSize = 0;
            this.RemoveTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveTabButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTabButton.ForeColor = System.Drawing.Color.White;
            this.RemoveTabButton.Location = new System.Drawing.Point(270, 6);
            this.RemoveTabButton.Name = "RemoveTabButton";
            this.RemoveTabButton.Size = new System.Drawing.Size(27, 33);
            this.RemoveTabButton.TabIndex = 5;
            this.RemoveTabButton.Text = "-";
            this.RemoveTabButton.UseVisualStyleBackColor = true;
            this.RemoveTabButton.Click += new System.EventHandler(this.RemoveTabButton_Click);
            // 
            // AddTabButton
            // 
            this.AddTabButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AddTabButton.FlatAppearance.BorderSize = 0;
            this.AddTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTabButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTabButton.ForeColor = System.Drawing.Color.White;
            this.AddTabButton.Location = new System.Drawing.Point(237, 6);
            this.AddTabButton.Name = "AddTabButton";
            this.AddTabButton.Size = new System.Drawing.Size(27, 33);
            this.AddTabButton.TabIndex = 4;
            this.AddTabButton.Text = "+";
            this.AddTabButton.UseVisualStyleBackColor = true;
            this.AddTabButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MinBtn
            // 
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.Location = new System.Drawing.Point(710, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(45, 45);
            this.MinBtn.TabIndex = 3;
            this.MinBtn.Text = "—";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(40, 45);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(46, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(185, 45);
            this.Title.TabIndex = 1;
            this.Title.Text = "Ultimate X | Offline";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(755, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(45, 45);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "✕";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // SideFrame
            // 
            this.SideFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SideFrame.Location = new System.Drawing.Point(0, 45);
            this.SideFrame.Name = "SideFrame";
            this.SideFrame.Size = new System.Drawing.Size(27, 285);
            this.SideFrame.TabIndex = 2;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExecuteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExecuteBtn.FlatAppearance.BorderSize = 0;
            this.ExecuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteBtn.ForeColor = System.Drawing.Color.White;
            this.ExecuteBtn.Location = new System.Drawing.Point(25, 0);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(100, 40);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = false;
            this.ExecuteBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveBtn.FlatAppearance.BorderSize = 0;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(237, 0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 40);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BottomFrame
            // 
            this.BottomFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BottomFrame.Controls.Add(this.OpenBtn);
            this.BottomFrame.Controls.Add(this.ClearBtn);
            this.BottomFrame.Controls.Add(this.AttachBtn);
            this.BottomFrame.Controls.Add(this.ExecuteBtn);
            this.BottomFrame.Controls.Add(this.SaveBtn);
            this.BottomFrame.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomFrame.Location = new System.Drawing.Point(0, 330);
            this.BottomFrame.Name = "BottomFrame";
            this.BottomFrame.Size = new System.Drawing.Size(800, 40);
            this.BottomFrame.TabIndex = 7;
            // 
            // OpenBtn
            // 
            this.OpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OpenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenBtn.FlatAppearance.BorderSize = 0;
            this.OpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenBtn.ForeColor = System.Drawing.Color.White;
            this.OpenBtn.Location = new System.Drawing.Point(343, 0);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(100, 40);
            this.OpenBtn.TabIndex = 11;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = false;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(131, 0);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 40);
            this.ClearBtn.TabIndex = 10;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AttachBtn
            // 
            this.AttachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AttachBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AttachBtn.FlatAppearance.BorderSize = 0;
            this.AttachBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttachBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachBtn.ForeColor = System.Drawing.Color.White;
            this.AttachBtn.Location = new System.Drawing.Point(665, 0);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(120, 40);
            this.AttachBtn.TabIndex = 9;
            this.AttachBtn.Text = "Attach";
            this.AttachBtn.UseVisualStyleBackColor = false;
            this.AttachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Location = new System.Drawing.Point(665, 302);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(120, 28);
            this.RefreshBtn.TabIndex = 9;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(665, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 247);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SideFrame2
            // 
            this.SideFrame2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SideFrame2.Location = new System.Drawing.Point(785, 45);
            this.SideFrame2.Name = "SideFrame2";
            this.SideFrame2.Size = new System.Drawing.Size(15, 285);
            this.SideFrame2.TabIndex = 11;
            // 
            // SideFrame3
            // 
            this.SideFrame3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SideFrame3.Location = new System.Drawing.Point(654, 45);
            this.SideFrame3.Name = "SideFrame3";
            this.SideFrame3.Size = new System.Drawing.Size(10, 285);
            this.SideFrame3.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Location = new System.Drawing.Point(665, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 10);
            this.panel1.TabIndex = 13;
            // 
            // visualStudioTabControl1
            // 
            this.visualStudioTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.visualStudioTabControl1.AllowDrop = true;
            this.visualStudioTabControl1.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.visualStudioTabControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.visualStudioTabControl1.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.visualStudioTabControl1.ClosingMessage = null;
            this.visualStudioTabControl1.Controls.Add(this.Script1);
            this.visualStudioTabControl1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.visualStudioTabControl1.HorizontalLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.visualStudioTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.visualStudioTabControl1.Location = new System.Drawing.Point(25, 45);
            this.visualStudioTabControl1.Name = "visualStudioTabControl1";
            this.visualStudioTabControl1.SelectedIndex = 0;
            this.visualStudioTabControl1.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.visualStudioTabControl1.ShowClosingButton = false;
            this.visualStudioTabControl1.ShowClosingMessage = false;
            this.visualStudioTabControl1.Size = new System.Drawing.Size(629, 285);
            this.visualStudioTabControl1.TabIndex = 10;
            this.visualStudioTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // Script1
            // 
            this.Script1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Script1.Controls.Add(this.fastColoredTextBox1);
            this.Script1.Location = new System.Drawing.Point(4, 20);
            this.Script1.Name = "Script1";
            this.Script1.Padding = new System.Windows.Forms.Padding(3);
            this.Script1.Size = new System.Drawing.Size(621, 261);
            this.Script1.TabIndex = 0;
            this.Script1.Text = "Main Tab";
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(218, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fastColoredTextBox1.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.CommentPrefix = "--";
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Language = FastColoredTextBoxNS.Language.Lua;
            this.fastColoredTextBox1.LeftBracket = '(';
            this.fastColoredTextBox1.LeftBracket2 = '{';
            this.fastColoredTextBox1.LineNumberColor = System.Drawing.Color.White;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(3, 3);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.RightBracket = ')';
            this.fastColoredTextBox1.RightBracket2 = '}';
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
            this.fastColoredTextBox1.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(615, 255);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "-- Made By T72B3 and Cynt X";
            this.fastColoredTextBox1.Zoom = 100;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideFrame3);
            this.Controls.Add(this.SideFrame2);
            this.Controls.Add(this.visualStudioTabControl1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BottomFrame);
            this.Controls.Add(this.SideFrame);
            this.Controls.Add(this.TopFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultimate X";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.BottomFrame.ResumeLayout(false);
            this.visualStudioTabControl1.ResumeLayout(false);
            this.Script1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopFrame;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.Panel SideFrame;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel BottomFrame;
        private System.Windows.Forms.Button AttachBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.ListBox listBox1;
        private VisualStudioTabControl.VisualStudioTabControl visualStudioTabControl1;
        private System.Windows.Forms.TabPage Script1;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.Button RemoveTabButton;
        private System.Windows.Forms.Button AddTabButton;
        private System.Windows.Forms.Panel SideFrame2;
        private System.Windows.Forms.Panel SideFrame3;
        private System.Windows.Forms.Panel panel1;
    }
}

