using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_manager
{

    public partial class Form1 : Form
    {
        private static AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private static AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        public int i = 0;
        public string current_path = @"C:\Users\domen_000\Music";
        public string root = @"C:\Users\domen_000\";
        

        public Form1()
        {
            InitializeComponent();
            
            treeView1.AfterSelect += treeView1_AfterSelect;
            foreach (DriveInfo d in DriveInfo.GetDrives()) {
                TreeNode root = new TreeNode(d.Name);
                root.Tag = d.Name;
                root.Nodes.Add(new TreeNode()); // add dummy node to allow expansion
                treeView1.Nodes.Add(root);
            }
            listView1.AllowDrop = true;
            listView1.DragDrop += new DragEventHandler(listView1_DragDrop);
            listView1.DragEnter += new DragEventHandler(listView1_DragEnter);
            initPlayer();
        }


        void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in FileList)
            {
                if (Path.GetExtension(path) != "")
                {
                    File.Copy(path, current_path + @"\" + Path.GetFileName(path));
                }
                else
                {
                    string dirPath = current_path + @"\" + Path.GetFileName(path);
                    Directory.CreateDirectory(dirPath);

                    foreach (var file in Directory.GetFiles(path))
                        File.Copy(file, Path.Combine(dirPath, Path.GetFileName(file)));

                    foreach (var directory in Directory.GetDirectories(path))
                        Copy(directory, Path.Combine(dirPath, Path.GetFileName(directory)));
                }
            }
            refreshContent(current_path);

        }

        void Copy(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)));

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)));
        }
        public void initPlayer() {
            musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(musicPlayer)).BeginInit();
            musicPlayer.Name = "wmPlayer";
            musicPlayer.Enabled = true;
            musicPlayer.Dock = System.Windows.Forms.DockStyle.None;
            musicPlayer.Width = panel2.Width;
            musicPlayer.Height = panel2.Height;
            musicPlayer.Visible = false;
            musicPlayer.Dock = DockStyle.Bottom;
            panel2.Controls.Add(musicPlayer);
            ((System.ComponentModel.ISupportInitialize)(musicPlayer)).EndInit();
            musicPlayer.Ctlcontrols.play();
        }


        public void setPlayer(string path, AxWMPLib.AxWindowsMediaPlayer player) {
            player.URL = path;
            player.Visible = true;
        }


        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            if (e.Node.Tag != null) {
                current_path = (string)e.Node.Tag;
                AddDirectoriesAndMusicFiles(e.Node, (string)e.Node.Tag);
            }
        }

        private void AddDirectoriesAndMusicFiles(TreeNode node, string path) {
            if(node != null) node.Nodes.Clear(); // clear dummy node if exists

            try {
                listView1.Items.Clear();
                DirectoryInfo currentDir = new DirectoryInfo(path);
                DirectoryInfo[] subdirs = currentDir.GetDirectories();

                foreach (DirectoryInfo subdir in subdirs) {
                    if (node != null) {
                        TreeNode child = new TreeNode(subdir.Name);
                        child.Tag = subdir.FullName;
                        child.Nodes.Add(new TreeNode()); // add dummy node to allow expansion
                        node.Nodes.Add(child);
                    }
                    listView1.Items.Add(subdir.Name, 0);
                }

                foreach (FileInfo file in currentDir.GetFiles()) {
                    if (node != null) {
                        TreeNode child = new TreeNode(file.Name);
                        child.Tag = file; // save full path for later use
                        node.Nodes.Add(child);
                    }

                    if (isVideo(file.Extension) || isPicture(file.Extension))
                        listView1.Items.Add(file.Name, createThumbnail(file.FullName, 256));
                    else
                    {
                        ListViewItem item = new ListViewItem(file.Name, 1);
                        Icon iconForFile = Icon.ExtractAssociatedIcon(file.FullName);

                        // Check to see if the image collection contains an image
                        // for this extension, using the extension as a key.
                        if (!largeImageList.Images.ContainsKey(file.Extension))
                        {
                            // If not, add the image to the image list.
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);

                            largeImageList.Images.Add(file.Extension, iconForFile);
                        }
                        item.ImageKey = file.Extension;
                        listView1.Items.Add(item);
                    }
                }
            }
            catch {}
        }

        public int createThumbnail(string path, int size) {
            //System.Drawing.Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(path);
            //Bitmap thumbnail = icon.ToBitmap();
            int THUMB_SIZE = size;
            Bitmap thumbnail = WindowsThumbnailProvider.GetThumbnail(
               path, THUMB_SIZE, THUMB_SIZE, ThumbnailOptions.None);
            largeImageList.Images.Add(thumbnail);
            int index = largeImageList.Images.Count - 1;
            return index;
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) {
            current_path = e.Node.FullPath.ToString();

            if (e.Node.IsExpanded) e.Node.Collapse();
            else e.Node.Expand();

            string path = e.Node.FullPath.ToString();
            if (isVideo(Path.GetExtension(path))) {
                setPlayer(path, videoPlayer1);
            }
            else if (isMusic(Path.GetExtension(path))) {
                setPlayer(path, musicPlayer);
            }
            else if (isPicture(Path.GetExtension(path))) {
                MessageBox.Show("TreeView picture");
            }
            else if (path.EndsWith("txt") || path.EndsWith("php")) {
                this.richTextBox1.Clear();
                StreamReader reader = new StreamReader(path);
                this.richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e) {
            string path = current_path + @"\" + ((ListView)sender).SelectedItems[0].Text;
            //setPlayer(path);
            string extension = Path.GetExtension(path);
            if (isVideo(extension)) setPlayer(path, videoPlayer1);
            else if (isMusic(extension)) setPlayer(path, musicPlayer);
            else if (isPicture(extension)) {
                MessageBox.Show("Listview item picture click");
            }
            else {
                current_path = path;
                AddDirectoriesAndMusicFiles(null, path);    
            }
        }

        public bool isVideo(string extension) {
            string[] array = new string[9] {".avi", ".mkv", ".wav", ".ogg", ".mp4", ".flv", ".wmv", ".mpeg", ".m4v"};
            if (Array.IndexOf(array, extension) > -1) return true;
            else return false;
        }

        public bool isMusic(string extension) {
            string[] array = new string[3] { ".mp3", ".flac", ".wma"};
            if (Array.IndexOf(array, extension) > -1) return true;
            else return false;
        }

        public bool isPicture(string extension) {
            string[] array = new string[6] { ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff" };
            if (Array.IndexOf(array, extension) > -1) return true;
            else return false;
        }

        public void refreshContent(string path) {
            treeView1.Nodes.Clear();
            listView1.Items.Clear();
            DirectoryInfo currentDir = new DirectoryInfo(path);
            DirectoryInfo[] subdirs = currentDir.GetDirectories();

            TreeNode root = new TreeNode(currentDir.FullName);
            root.Tag = currentDir.FullName;
            current_path = currentDir.FullName;
            root.Nodes.Add(new TreeNode()); // add dummy node to allow expansion
            treeView1.Nodes.Add(root);
            root.Expand();
        }

        private void moviesButton_Click(object sender, EventArgs e) {
            listView1.View = View.LargeIcon;
            string root = @"E:\Torrenti\";
            refreshContent(root);
        }

        private void musicButton_Click(object sender, EventArgs e) {
            listView1.View = View.List;
            string root = @"C:\Users\domen_000\Music\";
            refreshContent(root);
        }

        private void picturesButton_Click(object sender, EventArgs e) {
            listView1.View = View.LargeIcon;
            string root = @"C:\Users\domen_000\Pictures\";
            refreshContent(root);
        }

        private void closeVideoButton_Click(object sender, EventArgs e)
        {
            videoPlayer1.Hide();
            videoPlayer1.Ctlcontrols.stop();
        }

        private void googleDriveButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] pname = System.Diagnostics.Process.GetProcessesByName("googledrivesync");
            if (pname.Length == 0)
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Drive\googledrivesync.exe");
            listView1.View = View.LargeIcon;
            string root = @"C:\Users\domen_000\Google Drive\";
            refreshContent(root);
        }

        private void dropBoxButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] pname = System.Diagnostics.Process.GetProcessesByName("Dropbox");
            if (pname.Length == 0)
                System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Dropbox\Client\Dropbox.exe");
            listView1.View = View.LargeIcon;
            string root = @"C:\Users\domen_000\Dropbox\";
            refreshContent(root);
        }

        private void oneDriveButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] pname = System.Diagnostics.Process.GetProcessesByName("OneDrive");
            if (pname.Length == 0)
                System.Diagnostics.Process.Start(@"C:\Users\domen_000\AppData\Local\Microsoft\OneDrive\OneDrive.exe");
            listView1.View = View.LargeIcon;
            string root = @"C:\Users\domen_000\OneDrive\";
            refreshContent(root);
        }

        private void parentDirectoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                refreshContent(Directory.GetParent(current_path).ToString());
            }
            catch { }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshContent(current_path);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                refreshContent(current_path);
                return true;    // indicate that you handled this keystroke
            }
            else if (keyData == Keys.Back)
            {
                parentDirectoryButton_Click(null, null);
                return true;
            }
            else if (keyData == Keys.Delete) {
                listViewDeleteContext_Click(null, null);
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
}

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    listViewContext.Show(Cursor.Position);
                }
            }
        }

        private void listViewDeleteContext_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (Path.GetExtension(item.Text) != "")
                {
                     File.Delete(current_path + @"\" + item.Text);
                }
                else
                {
                  Directory.Delete(current_path + @"\" + item.Text, true);
                }
            }

            refreshContent(current_path);
        }
    }
}