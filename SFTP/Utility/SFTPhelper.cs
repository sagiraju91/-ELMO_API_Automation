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

        //Upload File to SFTP Server
        public void UploadToSFTP(string uploadfile)
        {
            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();

            sftp.ChangeDirectory(workingdirectory);
            Console.WriteLine("Changed directory to {0}", workingdirectory);
            using (var fileStream = new FileStream(uploadfile, FileMode.Open))
            {
                sftp.UploadFile(fileStream, Path.GetFileName(uploadfile));
            }
            sftp.Disconnect();
        }

        // Delete File from SFTP Server
        public void DeleteFromSFTP(string sftpFile)
        {

            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();
            try
            {
                sftp.DeleteFile(sftpFile);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                sftp.Disconnect();
            }
           
        //Download File from SFTP Server
        public void DownloadFromSFTP(string sftpFileName, string localPath)
        {
            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();
            
            string pathSFTP = Path.Combine(workingdirectory, sftpFileName);
            string pathDownload = Path.Combine(localPath, sftpFileName);

            try
            {
                using (Stream fileStream = File.Create(pathDownload))
                {
                    sftp.DownloadFile(pathSFTP, fileStream);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sftp.Disconnect();
        }


        //Move File in SFTP Server Locations
        public void FileMoveSFTP(string sftpsrc, string sftpdest)
        {
            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();

            string pathSrc = Path.Combine(workingdirectory, sftpsrc);
            sftp.ChangeDirectory(sftpdest);
            string pathDest = sftp.WorkingDirectory;
            string finalDestFile = Path.Combine(pathDest, sftpsrc);

            try
            {
               var file= sftp.Get(pathSrc);
                file.MoveTo(finalDestFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sftp.Disconnect();
        }

        //Copy File in SFTP Server Locations
        public void FileCopySFTP(string sftpsrc, string sftpdest)
        {
            SftpClient sftp = new SftpClient(host, username, password);
            sftp.Connect();

            string pathSrc = Path.Combine(workingdirectory, sftpsrc);
            sftp.ChangeDirectory(sftpdest);
            string pathDest = sftp.WorkingDirectory;
            string finalDestFile = Path.Combine(pathDest, sftpsrc);

            try
            {
                var file1 = sftp.OpenRead(pathSrc);
                var file2 = sftp.OpenWrite(finalDestFile);
                int data;

                while((data= file1.ReadByte()) != -1)
                {
                    file2.WriteByte((byte) data);
                }
                file2.Flush();
                file1.Close();
                file2.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sftp.Disconnect();
        }
    }
    
}