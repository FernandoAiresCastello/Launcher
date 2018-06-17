namespace Launcher
{
    partial class AddDialog
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TxtShortcut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TxtPath);
            this.flowLayoutPanel1.Controls.Add(this.TxtShortcut);
            this.flowLayoutPanel1.Controls.Add(this.BtnOk);
            this.flowLayoutPanel1.Controls.Add(this.BtnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 10F);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 133);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TxtShortcut
            // 
            this.TxtShortcut.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtShortcut.Location = new System.Drawing.Point(10, 60);
            this.TxtShortcut.Margin = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.TxtShortcut.Name = "TxtShortcut";
            this.TxtShortcut.Size = new System.Drawing.Size(262, 23);
            this.TxtShortcut.TabIndex = 0;
            this.TxtShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtShortcut_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter shortcut for this file:";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 9F);
            this.BtnCancel.Location = new System.Drawing.Point(150, 93);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.Font = new System.Drawing.Font("Arial", 9F);
            this.BtnOk.Location = new System.Drawing.Point(65, 93);
            this.BtnOk.Margin = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 3;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Font = new System.Drawing.Font("Arial", 8F);
            this.TxtPath.Location = new System.Drawing.Point(10, 36);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(262, 20);
            this.TxtPath.TabIndex = 4;
            // 
            // AddDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddDialog";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtShortcut;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtPath;
    }
}