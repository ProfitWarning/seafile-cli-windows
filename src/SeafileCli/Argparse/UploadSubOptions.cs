﻿using CommandLine;

namespace SeafileCli.Argparse
{
    public class UploadSubOptions : AuthorizationOptions
    {
        [Option('l', "library",
            HelpText = "The name of the remote library, where the files should be uploaded to.",
            Required = true)]
        public string Library { get; set; }

        [Option('d', "directory",
            HelpText = "The remote directory, where the files should be uploaded to. Path seperator is the forward slash (/).",
            DefaultValue = "/")]
        public string Directory { get; set; }

        [OptionArray('f', "files",
            HelpText = "The files to upload. Allows usage of the wildcards '**', '*' and '?'.",
            Required = true)]
        public string[] Files { get; set; }

        [Option('k', "keep-folders",
            HelpText = "Preserves the folder structure defined by the specified files. If this option is not used, all files will be collapsed and uploaded into the specified folder.")]
        public bool PreserveFolders { get; set; }
    }
}