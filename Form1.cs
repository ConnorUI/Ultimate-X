using Hovac_API;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Executer
{
    public partial class Main : Form
    {
        Hovac_API.ExploitAPI exploitAPI = new Hovac_API.ExploitAPI();

        public Point mouseLocation;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void TopFrame_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void TopFrame_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExecuteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    exploitAPI.SendLuaScript(textBox.Text);
                }
            }
            catch { }

        }

        private void AttachBtn_Click(object sender, EventArgs e)
        {
            exploitAPI.LaunchExploit(); // Attaches To Roblox
            if (ExploitAPI.isAPIAttached())
            {
                Title.Text = "Ultimate X | Online";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (visualStudioTabControl1.TabPages.Count > 0)
                {
                    FastColoredTextBoxNS.FastColoredTextBox textBox = this.visualStudioTabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBoxNS.FastColoredTextBox;
                    textBox.Text = "";
                }
            }
            catch { }
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage();
            FastColoredTextBoxNS.FastColoredTextBox textBox = new FastColoredTextBoxNS.FastColoredTextBox();
            newTab.Name = "Script" + (visualStudioTabControl1.TabCount + 1);
            newTab.Text = "New Tab  ";
            newTab.Parent = visualStudioTabControl1;
            textBox.Dock = DockStyle.Fill;
            textBox.Name = "fastColoredTextBox1";
            textBox.Parent = newTab;
            textBox.BackColor = Color.FromArgb(35, 35, 35);
            textBox.ServiceLinesColor = Color.FromArgb(55, 55, 55);
            textBox.IndentBackColor = Color.FromArgb(50, 50, 50);
            textBox.Language = FastColoredTextBoxNS.Language.Lua;
            textBox.LineNumberColor = Color.White;
            textBox.ForeColor = Color.White;

            visualStudioTabControl1.SelectTab(newTab);
            AddTabButton.Left = AddTabButton.Left + 0;
            RemoveTabButton.Left = RemoveTabButton.Left + 0;

            if (visualStudioTabControl1.TabCount == 7)
            {
                AddTabButton.Hide();
            }

            if (visualStudioTabControl1.TabCount > 1)
            {
                RemoveTabButton.Show();
            }
        }

        private void RemoveTabButton_Click(object sender, EventArgs e)
        {
            if (visualStudioTabControl1.TabCount > 1)
            {
                Control tabPageToRemove = visualStudioTabControl1.Controls["Script" + (visualStudioTabControl1.TabCount)];
                visualStudioTabControl1.SelectTab("Script" + (visualStudioTabControl1.TabCount - 1));
                visualStudioTabControl1.Controls.Remove(tabPageToRemove);
                AddTabButton.Left = AddTabButton.Left - 0;
                RemoveTabButton.Left = RemoveTabButton.Left - 0;
                if (visualStudioTabControl1.TabCount == 7)
                {
                    AddTabButton.Hide();
                }
                else
                {
                    AddTabButton.Show();
                }
                if (visualStudioTabControl1.TabCount == 1)
                {
                    RemoveTabButton.Hide();
                }
            }
        }
    }
}
