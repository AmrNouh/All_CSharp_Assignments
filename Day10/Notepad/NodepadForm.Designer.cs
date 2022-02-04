namespace Notepad
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.Mnu_top = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_new = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_newWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_fontEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_colorEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlog_color = new System.Windows.Forms.ColorDialog();
            this.dlog_font = new System.Windows.Forms.FontDialog();
            this.opndlog = new System.Windows.Forms.OpenFileDialog();
            this.savedlog = new System.Windows.Forms.SaveFileDialog();
            this.txt_area = new System.Windows.Forms.RichTextBox();
            this.Mnu_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_top
            // 
            this.Mnu_top.BackColor = System.Drawing.SystemColors.Control;
            this.Mnu_top.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Mnu_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Mnu_top.Location = new System.Drawing.Point(0, 0);
            this.Mnu_top.Name = "Mnu_top";
            this.Mnu_top.Size = new System.Drawing.Size(1166, 28);
            this.Mnu_top.TabIndex = 0;
            this.Mnu_top.Text = "Mnu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_new,
            this.Btn_newWindow,
            this.Btn_open,
            this.Btn_Save,
            this.Btn_saveAs,
            this.exitToolStripMenuItem,
            this.Btn_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Btn_new
            // 
            this.Btn_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_new.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_new.Name = "Btn_new";
            this.Btn_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Btn_new.Size = new System.Drawing.Size(274, 26);
            this.Btn_new.Text = "New";
            this.Btn_new.Click += new System.EventHandler(this.Btn_new_Click);
            // 
            // Btn_newWindow
            // 
            this.Btn_newWindow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_newWindow.Name = "Btn_newWindow";
            this.Btn_newWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.Btn_newWindow.Size = new System.Drawing.Size(274, 26);
            this.Btn_newWindow.Text = "New Window";
            this.Btn_newWindow.Click += new System.EventHandler(this.Btn_newWindow_Click);
            // 
            // Btn_open
            // 
            this.Btn_open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_open.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_open.Name = "Btn_open";
            this.Btn_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Btn_open.Size = new System.Drawing.Size(274, 26);
            this.Btn_open.Text = "Open...";
            this.Btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Btn_Save.Size = new System.Drawing.Size(274, 26);
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Btn_saveAs
            // 
            this.Btn_saveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_saveAs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_saveAs.Name = "Btn_saveAs";
            this.Btn_saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Btn_saveAs.Size = new System.Drawing.Size(274, 26);
            this.Btn_saveAs.Text = "Save as...";
            this.Btn_saveAs.Click += new System.EventHandler(this.Btn_saveAs_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(271, 6);
            // 
            // Btn_exit
            // 
            this.Btn_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Btn_exit.Size = new System.Drawing.Size(274, 26);
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.Btn_fontEdit,
            this.Btn_colorEdit});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Checked = true;
            this.fontToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fontToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontToolStripMenuItem.Text = "Word Wrap";
            // 
            // Btn_fontEdit
            // 
            this.Btn_fontEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_fontEdit.Name = "Btn_fontEdit";
            this.Btn_fontEdit.Size = new System.Drawing.Size(224, 26);
            this.Btn_fontEdit.Text = "Font";
            this.Btn_fontEdit.Click += new System.EventHandler(this.Btn_fontEdit_Click);
            // 
            // Btn_colorEdit
            // 
            this.Btn_colorEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_colorEdit.Name = "Btn_colorEdit";
            this.Btn_colorEdit.Size = new System.Drawing.Size(224, 26);
            this.Btn_colorEdit.Text = "Color";
            this.Btn_colorEdit.Click += new System.EventHandler(this.Btn_colorEdit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // opndlog
            // 
            this.opndlog.FileName = "openFileDialog1";
            // 
            // txt_area
            // 
            this.txt_area.AcceptsTab = true;
            this.txt_area.BackColor = System.Drawing.SystemColors.Window;
            this.txt_area.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_area.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_area.Location = new System.Drawing.Point(0, 28);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(1166, 693);
            this.txt_area.TabIndex = 1;
            this.txt_area.Text = "";
            // 
            // Frm_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1166, 721);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.Mnu_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.Mnu_top;
            this.MinimumSize = new System.Drawing.Size(1184, 768);
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Untitled - Nodepad";
            this.Mnu_top.ResumeLayout(false);
            this.Mnu_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip Mnu_top;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem Btn_new;
        private ToolStripMenuItem Btn_open;
        private ToolStripMenuItem Btn_Save;
        private ToolStripMenuItem Btn_saveAs;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem Btn_newWindow;
        private ToolStripSeparator exitToolStripMenuItem;
        private ToolStripMenuItem Btn_exit;
        private ToolStripMenuItem Btn_fontEdit;
        private ToolStripMenuItem Btn_colorEdit;
        private ColorDialog dlog_color;
        private FontDialog dlog_font;
        private OpenFileDialog opndlog;
        private SaveFileDialog savedlog;
        private RichTextBox txt_area;
    }
}