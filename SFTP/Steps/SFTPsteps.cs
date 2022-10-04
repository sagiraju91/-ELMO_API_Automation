using SFTP.Utility;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SFTP.Steps
{
    [Binding]
    public sealed class SFTPsteps
    {
        SFTPhelper sftp = new SFTPhelper();

        [Given(@"SFTP location")]
        public void GivenSFTPLocation()
        {
            Console.WriteLine("File Upload Testing >>");
        }

        [Given(@"SFTP locations")]
        public void GivenSFTPLocations()
        {
            Console.WriteLine("File Delete Testing >>");
        }

        [When(@"file copied from local to SFTP as")]
            public void WhenFileCopiedFromLocalToSFTPAs(Table table)
            {
            dynamic uploadFile = table.CreateDynamicInstance();
            Console.WriteLine(uploadFile.localfilename);
            sftp.UploadToSFTP(uploadFile.localfilename);

        }

        [When(@"file removed from SFTP location")]
        public void WhenFileRemovedFromSFTPLocation(Table table)
        {
            dynamic rmFile = table.CreateDynamicInstance();
            Console.WriteLine(rmFile.sftpfilename);
            sftp.DeleteFromSFTP(rmFile.sftpfilename);
        }

        [When(@"file downloaded from SFTP location")]
        public void WhenFileDownloadedFromSFTPLocation(Table table)
        {
            dynamic downloadFile = table.CreateDynamicInstance();
            Console.WriteLine(downloadFile.sftpfilename +" : "+ downloadFile.downloadpath);
            sftp.DownloadFromSFTP(downloadFile.sftpfilename, downloadFile.downloadpath);
        }

        [When(@"file moved between SFTP locations")]
        public void WhenFileMovedBetweenSFTPLocations(Table table)
        {
            dynamic fileMove = table.CreateDynamicInstance();
            Console.WriteLine(fileMove.sftpsrcfile + " : " + fileMove.sftpdestloc);
            sftp.FileMoveSFTP(fileMove.sftpsrcfile, fileMove.sftpdestloc);
        }

        [When(@"file copy between SFTP locations")]
        public void WhenFileCopyBetweenSFTPLocations(Table table)
        {
            dynamic fileCopy = table.CreateDynamicInstance();
            Console.WriteLine(fileCopy.sftpsrcfile + " : " + fileCopy.sftpdestloc);
            sftp.FileCopySFTP(fileCopy.sftpsrcfile, fileCopy.sftpdestloc);
        }


        [Then(@"File copy should be successful")]
        public void ThenFileCopyShouldBeSuccessful()
        {
            Console.WriteLine("File copy successful");
        }


        [Then(@"File move should be successful")]
        public void ThenFileMoveShouldBeSuccessful()
        {
            Console.WriteLine("File move successful");
        }


        [Then(@"File upload should be successful")]
        public void ThenFileUploadShouldBeSuccessful()
        {
            Console.WriteLine("File upload successful");
        }

        [Then(@"File remove should be successful")]
        public void ThenFileRemoveShouldBeSuccessful()
        {
            Console.WriteLine("File remove successful");
        }

        [Then(@"File download should be successful")]
        public void ThenFileDownloadShouldBeSuccessful()
        {
            Console.WriteLine("File download successful");
        }



    }
}
