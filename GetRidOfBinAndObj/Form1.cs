namespace getRidOfBinAndObj
{
    public partial class Form1 : Form
    {
        public string TheFileName { get; set; }

        public System.IO.DirectoryInfo theRootDir;

        public Form1()
        {
            InitializeComponent();

            TheFileName = "";
            theRootDir = new DirectoryInfo("C:");
            Info.SetLabel(labelProcessing);

            openFileDialog1 = new OpenFileDialog();

        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBoxFolder.Text = folderBrowserDialog1.SelectedPath;
            Info.SetInfo("Ready...");
        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {
            buttonClean.Enabled = false;
            TheFileName = textBoxFolder.Text;
            if (!TheFileName.Equals(""))
            {
                theRootDir = new DirectoryInfo(TheFileName);
                buttonClean.Enabled = theRootDir.Exists;
                Info.SetInfo(theRootDir.Exists ? "Ready..." : "Folder does not exist!");
            }
            else
            {
                Info.SetInfo("Folder does not exist!");
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            Info.SetInfo("Processing...");
            textBoxFolder.Text = "";
            DirectoryTraverser directoryTraverser = new DirectoryTraverser();
            directoryTraverser.TraverseAndClean(theRootDir);
            Info.SetInfo("Idle...");
        }

    }

    public static class Info
    {
        public static Label theInfoLabel = new();

        public static void SetLabel(Label source)
        {
            theInfoLabel = source;
        }
        public static void SetInfo(string info)
        {
            theInfoLabel.Text = "Status: " + info;
            theInfoLabel.Refresh();
        }
    }


}