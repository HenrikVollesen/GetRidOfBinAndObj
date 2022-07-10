namespace getRidOfBinAndObj
{
    public static class Info
    {
        public static Label theInfoLabel = new();
    }

    public partial class Form1 : Form
    {
        public string TheFileName { get; set; }

        public System.IO.DirectoryInfo theRootDir;

        public Form1()
        {
            InitializeComponent();

            openFileDialog1 = new OpenFileDialog();

        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            labelProcessing.Visible = false;

            folderBrowserDialog1.ShowDialog();
            textBoxFolder.Text = folderBrowserDialog1.SelectedPath;

        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {
            buttonClean.Enabled = false;
            TheFileName = textBoxFolder.Text;
            if (!TheFileName.Equals("") )
            {
                theRootDir = new DirectoryInfo(TheFileName);
                buttonClean.Enabled = theRootDir.Exists;
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            //theRootDir = new DirectoryInfo(TheFileName);
            Info.theInfoLabel = labelProcessing;

            labelProcessing.Text = "Processing...";
            labelProcessing.Visible = true;
            textBoxFolder.Text = "";
            DirectoryTraverser directoryTraverser = new DirectoryTraverser();
            directoryTraverser.TraverseAndClean(theRootDir);
            //WalkDirectoryTree(theRootDir);
            labelProcessing.Text = "Done";
        }

        //void WalkDirectoryTree(System.IO.DirectoryInfo root)
        //{
        //    System.IO.FileInfo[] files = null;
        //    System.IO.DirectoryInfo[] subDirs = null;

        //    // First, process all the files directly under this folder
        //    try
        //    {
        //        files = root.GetFiles("*.*");
        //    }
        //    // This is thrown if even one of the files requires permissions greater
        //    // than the application provides.
        //    catch (UnauthorizedAccessException e)
        //    {
        //        // This code just writes out the message and continues to recurse.
        //        // You may decide to do something different here. For example, you
        //        // can try to elevate your privileges and access the file again.
        //        //log.Add(e.Message);
        //    }

        //    catch (System.IO.DirectoryNotFoundException e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    if (files != null)
        //    {

        //        // Now find all the subdirectories under this directory.
        //        subDirs = root.GetDirectories();

        //        foreach (System.IO.DirectoryInfo dirInfo in subDirs)
        //        {
        //            if ((dirInfo.Name.Equals("bin")) || (dirInfo.Name.Equals("obj")))
        //            {
        //                dirInfo.Delete(true);
        //            }
        //            else
        //            {
        //                // Resursive call for each subdirectory.
        //                WalkDirectoryTree(dirInfo);
        //            }
        //        }
        //    }
        //}
    }
}