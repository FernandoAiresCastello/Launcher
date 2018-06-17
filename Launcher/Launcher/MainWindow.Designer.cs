namespace Launcher
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ProgramBox = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.FlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnNote = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.TblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.BtnOpacity = new System.Windows.Forms.Button();
            this.BtnTopmost = new System.Windows.Forms.Button();
            this.BtnMinimize = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDummy = new System.Windows.Forms.Button();
            this.FlowLayout.SuspendLayout();
            this.TblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgramBox
            // 
            this.ProgramBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ProgramBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProgramBox.DropDownHeight = 200;
            this.FlowLayout.SetFlowBreak(this.ProgramBox, true);
            this.ProgramBox.Font = new System.Drawing.Font("Arial", 10F);
            this.ProgramBox.IntegralHeight = false;
            this.ProgramBox.Location = new System.Drawing.Point(6, 35);
            this.ProgramBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.ProgramBox.MaxDropDownItems = 10;
            this.ProgramBox.Name = "ProgramBox";
            this.ProgramBox.Size = new System.Drawing.Size(230, 24);
            this.ProgramBox.Sorted = true;
            this.ProgramBox.TabIndex = 0;
            this.ProgramBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProgramBox_KeyDown);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(58, 6);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(1);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(24, 24);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(32, 6);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(1);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(24, 24);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FlowLayout
            // 
            this.FlowLayout.BackColor = System.Drawing.SystemColors.Control;
            this.FlowLayout.Controls.Add(this.BtnAdd);
            this.FlowLayout.Controls.Add(this.BtnEdit);
            this.FlowLayout.Controls.Add(this.BtnUpdate);
            this.FlowLayout.Controls.Add(this.BtnNote);
            this.FlowLayout.Controls.Add(this.BtnOpacity);
            this.FlowLayout.Controls.Add(this.BtnTopmost);
            this.FlowLayout.Controls.Add(this.BtnDummy);
            this.FlowLayout.Controls.Add(this.BtnMinimize);
            this.FlowLayout.Controls.Add(this.BtnExit);
            this.FlowLayout.Controls.Add(this.ProgramBox);
            this.FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayout.Name = "FlowLayout";
            this.FlowLayout.Padding = new System.Windows.Forms.Padding(5);
            this.FlowLayout.Size = new System.Drawing.Size(244, 65);
            this.FlowLayout.TabIndex = 3;
            // 
            // BtnNote
            // 
            this.BtnNote.Image = ((System.Drawing.Image)(resources.GetObject("BtnNote.Image")));
            this.BtnNote.Location = new System.Drawing.Point(84, 6);
            this.BtnNote.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNote.Name = "BtnNote";
            this.BtnNote.Size = new System.Drawing.Size(24, 24);
            this.BtnNote.TabIndex = 4;
            this.BtnNote.UseVisualStyleBackColor = true;
            this.BtnNote.Click += new System.EventHandler(this.BtnNote_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(214, 6);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(1);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(24, 24);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.TabStop = false;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // TblLayout
            // 
            this.TblLayout.BackColor = System.Drawing.SystemColors.Control;
            this.TblLayout.ColumnCount = 1;
            this.TblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayout.Controls.Add(this.FlowLayout, 0, 0);
            this.TblLayout.Controls.Add(this.TxtNote, 0, 1);
            this.TblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLayout.Location = new System.Drawing.Point(0, 0);
            this.TblLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TblLayout.Name = "TblLayout";
            this.TblLayout.RowCount = 2;
            this.TblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67269F));
            this.TblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.32732F));
            this.TblLayout.Size = new System.Drawing.Size(244, 443);
            this.TblLayout.TabIndex = 5;
            // 
            // TxtNote
            // 
            this.TxtNote.AcceptsTab = true;
            this.TxtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNote.Font = new System.Drawing.Font("Consolas", 8F);
            this.TxtNote.Location = new System.Drawing.Point(3, 68);
            this.TxtNote.MaxLength = 65536;
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNote.Size = new System.Drawing.Size(238, 372);
            this.TxtNote.TabIndex = 0;
            this.TxtNote.TabStop = false;
            this.TxtNote.Text = "Hello World!";
            this.TxtNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNote_KeyDown);
            this.TxtNote.Leave += new System.EventHandler(this.TxtNote_Leave);
            // 
            // BtnOpacity
            // 
            this.BtnOpacity.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpacity.Image")));
            this.BtnOpacity.Location = new System.Drawing.Point(110, 6);
            this.BtnOpacity.Margin = new System.Windows.Forms.Padding(1);
            this.BtnOpacity.Name = "BtnOpacity";
            this.BtnOpacity.Size = new System.Drawing.Size(24, 24);
            this.BtnOpacity.TabIndex = 5;
            this.BtnOpacity.UseVisualStyleBackColor = true;
            this.BtnOpacity.Click += new System.EventHandler(this.BtnOpacity_Click);
            // 
            // BtnTopmost
            // 
            this.BtnTopmost.Image = ((System.Drawing.Image)(resources.GetObject("BtnTopmost.Image")));
            this.BtnTopmost.Location = new System.Drawing.Point(136, 6);
            this.BtnTopmost.Margin = new System.Windows.Forms.Padding(1);
            this.BtnTopmost.Name = "BtnTopmost";
            this.BtnTopmost.Size = new System.Drawing.Size(24, 24);
            this.BtnTopmost.TabIndex = 6;
            this.BtnTopmost.UseVisualStyleBackColor = true;
            this.BtnTopmost.Click += new System.EventHandler(this.BtnTopmost_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.Location = new System.Drawing.Point(188, 6);
            this.BtnMinimize.Margin = new System.Windows.Forms.Padding(1);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(24, 24);
            this.BtnMinimize.TabIndex = 8;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(6, 6);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(24, 24);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDummy
            // 
            this.BtnDummy.Location = new System.Drawing.Point(162, 6);
            this.BtnDummy.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDummy.Name = "BtnDummy";
            this.BtnDummy.Size = new System.Drawing.Size(24, 24);
            this.BtnDummy.TabIndex = 7;
            this.BtnDummy.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(244, 443);
            this.Controls.Add(this.TblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Launcher";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FlowLayout.ResumeLayout(false);
            this.TblLayout.ResumeLayout(false);
            this.TblLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ProgramBox;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.FlowLayoutPanel FlowLayout;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnNote;
        private System.Windows.Forms.TableLayoutPanel TblLayout;
        private System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.Button BtnOpacity;
        private System.Windows.Forms.Button BtnTopmost;
        private System.Windows.Forms.Button BtnMinimize;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDummy;
    }
}

