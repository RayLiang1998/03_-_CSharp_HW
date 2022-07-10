
namespace _03_梁延睿_CSharp_HW
{
    partial class Frm_Painter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reUndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openNewToolStripMenuItem
            // 
            this.openNewToolStripMenuItem.Name = "openNewToolStripMenuItem";
            this.openNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openNewToolStripMenuItem.Text = "Open New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.reUndoToolStripMenuItem,
            this.ctrlXToolStripMenuItem,
            this.ctrlCToolStripMenuItem,
            this.ctrlVToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // reUndoToolStripMenuItem
            // 
            this.reUndoToolStripMenuItem.Name = "reUndoToolStripMenuItem";
            this.reUndoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reUndoToolStripMenuItem.Text = "Re-Undo";
            // 
            // ctrlXToolStripMenuItem
            // 
            this.ctrlXToolStripMenuItem.Name = "ctrlXToolStripMenuItem";
            this.ctrlXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlXToolStripMenuItem.Text = "ctrl X";
            // 
            // ctrlCToolStripMenuItem
            // 
            this.ctrlCToolStripMenuItem.Name = "ctrlCToolStripMenuItem";
            this.ctrlCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlCToolStripMenuItem.Text = "ctrl C";
            // 
            // ctrlVToolStripMenuItem
            // 
            this.ctrlVToolStripMenuItem.Name = "ctrlVToolStripMenuItem";
            this.ctrlVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ctrlVToolStripMenuItem.Text = "ctrl V";
            // 
            // Frm_Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Painter";
            this.Text = "Frm_Painter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reUndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlVToolStripMenuItem;
    }
}