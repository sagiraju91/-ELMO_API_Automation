using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SFTP.Utility
{
    public class SFTPhelper
    {
        string host = "192.168.0.12";
        int port = 22;
        string username = "user";
        string password = "password";
        string tokenKey = "GA2TQrLU3rP42IK97/sqZ17YJzkbaqTV4Be71trp6xc";
        SshClient sshClnt = null;
        const string workingdirectory = "/public";


        public void UploadToSFTP(string uploadfile)
        {

            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();

            sftp.ChangeDirectory(workingdirectory);
            Console.WriteLine("Changed directory to {0}", workingdirectory);
            using (var fileStream = new FileStream(uploadfile, FileMode.Open))
            {
                sftp.UploadFile(fileStream, Path.GetFileName(uploadfile));
                sftp.Disconnect();
            }
        }



        // Delete File from SFTP Server
        public void DeleteSFTP(string DeleteFile)
        {

            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();
            try
            {
                sftp.DeleteFile(@"C:\Users\sowjy\Dropbox\PC\Desktop\LocalFiles\sjFile.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Delete file Error !" + e.Message);
            }

            //// Download File from SFTP Server
            //            try { 
            //                string serverFile = @"\public\Test.txt";
            //                string locaFile = @"C:\Users\E005457\Desktop\fileOperations\Downloads\Test.txt";
            //                using (Stream stream = File.OpenWrite(locaFile))
            //                {
            //                    client.DownloadFile(serverFile, stream, x => { Console.WriteLine(x); });
            //                }

            //                }catch (Exception e)
            //                {
            //                Console.WriteLine("File download Error !" + e.Message);
            //                }

            //Disconnect SFTP Server
             void DisconnectSFTP()
            {
                sshClnt.Disconnect();

            }
        }
    }
}