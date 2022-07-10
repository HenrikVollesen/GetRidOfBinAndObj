using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getRidOfBinAndObj
{
    internal class DirectoryTraverser
    {
        public void TraverseAndClean(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[]? files = null;
            System.IO.DirectoryInfo[]? subDirs = null;

            Info.theInfoLabel.Text = root.Name;

            //Thread.Sleep(3000);
            // First, process all the files directly under this folder
            try
            {
                files = root.GetFiles("*.*");
            }
            // This is thrown if even one of the files requires permissions greater
            // than the application provides.
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    if ((dirInfo.Name.Equals("bin")) || (dirInfo.Name.Equals("obj")))
                    {
                        dirInfo.Delete(true);
                    }
                    else
                    {
                        // Resursive call for each subdirectory.
                        TraverseAndClean(dirInfo);
                    }
                }
            }
        }
    }
}
