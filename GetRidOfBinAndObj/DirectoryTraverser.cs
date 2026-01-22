using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                    Info.SetInfo("Processing " + dirInfo.Name);
                    string lc = dirInfo.Name.ToLower();
                    if (lc.Equals("bin") || lc.Equals("obj") || lc.Equals("x64"))
                    {
                        try
                        {
                            dirInfo.Delete(true);
                        }
                        catch (System.IO.IOException e)
                        {
                            Info.SetInfo("Problem with " + dirInfo.Name);
                            Thread.Sleep(2000);
                        }
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
