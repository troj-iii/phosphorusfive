/*
 * phosphorus five, copyright 2014 - Mother Earth, Jannah, Gaia
 * phosphorus five is licensed as mit, see the enclosed LICENSE file for details
 */

using System.IO;
using phosphorus.core;
using phosphorus.expressions;

// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global

namespace phosphorus.file.folder
{
    /// <summary>
    ///     class to help figure out if folder exists on disc
    /// </summary>
    public static class Exists
    {
        /// <summary>
        ///     checks to see if one or more folders exists, from the path given as value of args, which might
        ///     be a constant, or an expression. all folders that exists, will be returned as children nodes,
        ///     having the path to the folder as name, and its value being true. if a folder does not exist,
        ///     the return value will be false for that folder
        /// </summary>
        /// <param name="context">Application context</param>
        /// <param name="e">Parameters passed into Active Event</param>
        [ActiveEvent (Name = "pf.folder.exists")]
        private static void pf_folder_exists (ApplicationContext context, ActiveEventArgs e)
        {
            // retrieving root folder first
            var rootFolder = Common.GetRootFolder (context);

            // iterating through each folder the caller requests knowledge about
            foreach (var idx in XUtil.Iterate<string> (e.Args, context)) {
                // appending whether or not the folder exists back to caller
                e.Args.Add (new Node (idx, Directory.Exists (rootFolder + idx)));
            }
        }
    }
}