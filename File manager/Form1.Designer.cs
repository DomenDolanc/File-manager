namespace File_manager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.videoPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moviesButton = new System.Windows.Forms.ToolStripButton();
            this.musicButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.googleDriveButton = new System.Windows.Forms.ToolStripButton();
            this.oneDriveButton = new System.Windows.Forms.ToolStripButton();
            this.dropBoxButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesList = new System.Windows.Forms.ImageList(this.components);
            this.listViewContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listViewCopyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewPasteContext = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewDeleteContext = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.listViewContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 118);
            this.panel2.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 83);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(288, 400);
            this.treeView1.TabIndex = 8;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(26, 525);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(76, 77);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.videoPlayer1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 729);
            this.panel1.TabIndex = 10;
            // 
            // videoPlayer1
            // 
            this.videoPlayer1.Enabled = true;
            this.videoPlayer1.Location = new System.Drawing.Point(300, 80);
            this.videoPlayer1.Name = "videoPlayer1";
            this.videoPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer1.OcxState")));
            this.videoPlayer1.Size = new System.Drawing.Size(1050, 522);
            this.videoPlayer1.TabIndex = 0;
            this.videoPlayer1.Visible = false;
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.LargeImageList = this.largeImageList;
            this.listView1.Location = new System.Drawing.Point(294, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1056, 522);
            this.listView1.SmallImageList = this.smallImageList;
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "folder.png");
            this.largeImageList.Images.SetKeyName(1, "movies.png");
            this.largeImageList.Images.SetKeyName(2, "music.png");
            this.largeImageList.Images.SetKeyName(3, "pictures.png");
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "folder.png");
            this.smallImageList.Images.SetKeyName(1, "movies.png");
            this.smallImageList.Images.SetKeyName(2, "music.png");
            this.smallImageList.Images.SetKeyName(3, "pictures.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesButton,
            this.musicButton,
            this.toolStripButton4,
            this.googleDriveButton,
            this.oneDriveButton,
            this.dropBoxButton,
            this.toolStripButton1,
            this.toolStripButton2,
            this.refreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1350, 56);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moviesButton
            // 
            this.moviesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.moviesButton.Image = ((System.Drawing.Image)(resources.GetObject("moviesButton.Image")));
            this.moviesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.moviesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moviesButton.Name = "moviesButton";
            this.moviesButton.Size = new System.Drawing.Size(49, 53);
            this.moviesButton.Text = "Movies";
            this.moviesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.moviesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.moviesButton.Click += new System.EventHandler(this.moviesButton_Click);
            // 
            // musicButton
            // 
            this.musicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.musicButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.musicButton.Image = ((System.Drawing.Image)(resources.GetObject("musicButton.Image")));
            this.musicButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.musicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.musicButton.Name = "musicButton";
            this.musicButton.Size = new System.Drawing.Size(43, 53);
            this.musicButton.Text = "Music";
            this.musicButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.musicButton.Click += new System.EventHandler(this.musicButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(53, 53);
            this.toolStripButton4.Text = "Pictures";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.picturesButton_Click);
            // 
            // googleDriveButton
            // 
            this.googleDriveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.googleDriveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.googleDriveButton.Image = ((System.Drawing.Image)(resources.GetObject("googleDriveButton.Image")));
            this.googleDriveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.googleDriveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.googleDriveButton.Name = "googleDriveButton";
            this.googleDriveButton.Size = new System.Drawing.Size(79, 53);
            this.googleDriveButton.Text = "Google Drive";
            this.googleDriveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.googleDriveButton.Click += new System.EventHandler(this.googleDriveButton_Click);
            // 
            // oneDriveButton
            // 
            this.oneDriveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oneDriveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.oneDriveButton.Image = ((System.Drawing.Image)(resources.GetObject("oneDriveButton.Image")));
            this.oneDriveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.oneDriveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.oneDriveButton.Name = "oneDriveButton";
            this.oneDriveButton.Size = new System.Drawing.Size(60, 53);
            this.oneDriveButton.Text = "OneDrive";
            this.oneDriveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.oneDriveButton.Click += new System.EventHandler(this.oneDriveButton_Click);
            // 
            // dropBoxButton
            // 
            this.dropBoxButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dropBoxButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dropBoxButton.Image = ((System.Drawing.Image)(resources.GetObject("dropBoxButton.Image")));
            this.dropBoxButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dropBoxButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dropBoxButton.Name = "dropBoxButton";
            this.dropBoxButton.Size = new System.Drawing.Size(56, 53);
            this.dropBoxButton.Text = "DropBox";
            this.dropBoxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dropBoxButton.Click += new System.EventHandler(this.dropBoxButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(40, 53);
            this.toolStripButton1.Text = "Close";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.closeVideoButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 53);
            this.toolStripButton2.Text = "Back";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.parentDirectoryButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refreshButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(50, 53);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // picturesList
            // 
            this.picturesList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.picturesList.ImageSize = new System.Drawing.Size(16, 16);
            this.picturesList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewContext
            // 
            this.listViewContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listViewCopyContext,
            this.listViewPasteContext,
            this.listViewDeleteContext});
            this.listViewContext.Name = "listViewContext";
            this.listViewContext.Size = new System.Drawing.Size(108, 70);
            // 
            // listViewCopyContext
            // 
            this.listViewCopyContext.Name = "listViewCopyContext";
            this.listViewCopyContext.Size = new System.Drawing.Size(107, 22);
            this.listViewCopyContext.Text = "Copy";
            // 
            // listViewPasteContext
            // 
            this.listViewPasteContext.Name = "listViewPasteContext";
            this.listViewPasteContext.Size = new System.Drawing.Size(107, 22);
            this.listViewPasteContext.Text = "Paste";
            // 
            // listViewDeleteContext
            // 
            this.listViewDeleteContext.Name = "listViewDeleteContext";
            this.listViewDeleteContext.Size = new System.Drawing.Size(107, 22);
            this.listViewDeleteContext.Text = "Delete";
            this.listViewDeleteContext.Click += new System.EventHandler(this.listViewDeleteContext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.listViewContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton moviesButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton musicButton;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton googleDriveButton;
        private System.Windows.Forms.ToolStripButton oneDriveButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ImageList largeImageList;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer1;
        private System.Windows.Forms.ImageList picturesList;
        private System.Windows.Forms.ToolStripButton dropBoxButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ContextMenuStrip listViewContext;
        private System.Windows.Forms.ToolStripMenuItem listViewCopyContext;
        private System.Windows.Forms.ToolStripMenuItem listViewPasteContext;
        private System.Windows.Forms.ToolStripMenuItem listViewDeleteContext;
    }
}

