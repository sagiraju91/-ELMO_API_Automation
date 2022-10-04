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
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine(data.filename);
            sftp.UploadToSFTP(data.filename);

        }

        [When(@"file removed from SFTP location")]
        public void WhenFileRemovedFromSFTPLocation(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine(data.filename);
            sftp.DeleteSFTP(data.filename);
        }


        [Then(@"File upload should be successful")]
        public void ThenFileUploadShouldBeSuccessful()
        {
            
        }

        [Then(@"File remove should be successful")]
        public void ThenFileRemoveShouldBeSuccessful()
        {
            
        }




    }
}
