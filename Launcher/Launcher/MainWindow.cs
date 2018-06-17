using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Launcher
{
    public partial class MainWindow : Form
    {
        public readonly string ListFile = "programs.txt";
        public readonly string NoteFile = "note.txt";

        ProgramList Programs = new ProgramList();

        public MainWindow()
        {
            InitializeComponent();

            Left = 0;
            Top = 0;

            HideNote();
            LoadNote();
            LoadList();
        }

        public void LoadNote()
        {
            TxtNote.Text = File.ReadAllText(NoteFile);
        }

        public void SaveNote()
        {
            File.WriteAllText(NoteFile, TxtNote.Text);
        }

        public void SaveList()
        {
            using (StreamWriter writer = new StreamWriter(ListFile))
            {
                foreach (Program p in Programs)
                {
                    string shortcut = p.Shortcut.Trim();
                    string path = p.Path.Trim();
                    string line = shortcut + " = " + path;

                    writer.WriteLine(line);
                }
            }
        }

        public void LoadList()
        {
            Programs.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(ListFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        if (line.Trim() == "")
                            continue;

                        string[] program = line.ToLower().Trim().Split('=');
                        string shortcut = program[0].Trim();
                        string path = program[1].Trim();

                        Programs.Add(new Program(shortcut, path));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading program file.\n\n" + ex.Message, "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UpdateList();
        }

        public void UpdateList()
        {
            ProgramBox.Items.Clear();

            foreach (Program p in Programs)
                ProgramBox.Items.Add(p.Shortcut);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SaveNote();
            Application.Exit();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog(this);

            if (result == DialogResult.OK)
                AddShortcut(dialog.FileName);
        }

        public void AddShortcut(string path)
        {
            AddDialog dialog = new AddDialog(path);
            dialog.ShowDialog(this);

            string shortcut = dialog.Shortcut;

            if (shortcut != null)
            {
                Programs.Add(new Program(shortcut, path));
                SaveList();
                UpdateList();
            }
        }

        private void BtnNote_Click(object sender, EventArgs e)
        {
            if (NoteVisible())
                HideNote();
            else
                ShowNote();
        }

        public bool NoteVisible()
        {
            return TxtNote.Visible;
        }

        public void HideNote()
        {
            Height = 70;
            TblLayout.RowStyles[1].Height = 0;
            TxtNote.Hide();
        }

        public void ShowNote()
        {
            Height = Screen.PrimaryScreen.Bounds.Height - 40;
            TblLayout.RowStyles[1].Height = 140;
            TxtNote.Show();
        }

        private void TxtNote_Leave(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void TxtNote_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void ProgramBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                Program prog = Programs.Get(ProgramBox.Text);
                ProgramBox.Text = "";

                if (prog == null)
                {
                    MessageBox.Show("Undefined shortcut", "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    ProcessStartInfo procinfo = new ProcessStartInfo(prog.Path);
                    FileInfo fileinfo = new FileInfo(prog.Path);
                    procinfo.WorkingDirectory = fileinfo.DirectoryName;
                    Process.Start(procinfo);
                    this.SendToBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error launching program.\n\n" + ex.Message, "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void BtnOpacity_Click(object sender, EventArgs e)
        {
            if (Opacity >= 1.0)
                Opacity = 0.5;
            else
                Opacity = 1.0;
        }

        private void BtnTopmost_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost;
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Process.Start(ListFile);
        }
    }
}
