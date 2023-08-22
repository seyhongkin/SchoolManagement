using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.WebServices
{
    internal class ImageService
    {
        private static readonly string credentialsPath = "credential_2.json";

        private DriveService GetDriveService(bool upload)
        {
            using (var stream = new FileStream(credentialsPath, FileMode.Open, FileAccess.Read))
            {
                var credentials = upload ? GoogleCredential.FromStream(stream)
                                                  .CreateScoped(DriveService.ScopeConstants.DriveFile) :
                                                  GoogleCredential.FromStream(stream)
                                                  .CreateScoped(DriveService.ScopeConstants.DriveReadonly);

                return new DriveService(new BaseClientService.Initializer
                {
                    HttpClientInitializer = credentials,
                    ApplicationName = "JorgRean Google Image App"
                });
            }
        }

        public String UploadImage(string imgPath)
        {
            string folderID = "1ndgIaEVO53GV0w1Ym81EQrQVGR1KCU6P";
            var driveService = GetDriveService(true);
            var fileMetaData = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(imgPath),
                Parents = new List<String> { folderID }
            };

            FilesResource.CreateMediaUpload request;
            using (var stream = new FileStream(imgPath, FileMode.Open))
            {
                request = driveService.Files.Create(fileMetaData, stream, "");
                request.Fields = "id";
                request.Upload();
            }

            var uploadedFile = request.ResponseBody;
            Console.WriteLine($"File '{fileMetaData.Name}' uploaded with ID: {uploadedFile.Id}");

            return uploadedFile.Id;
        }

        public Image LoadImageDrive(string imgUID)
        {
            Image image = null;
            try
            {
                var driveService = GetDriveService(false);
                var request = driveService.Files.Get(imgUID);
                var imageStream = new MemoryStream();

                request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
                {
                    switch (progress.Status)
                    {
                        case DownloadStatus.Downloading:
                            break;
                        case DownloadStatus.Completed:
                            using (var fileStream = new FileStream("temp.jpg", FileMode.Create, FileAccess.Write))
                            {
                                imageStream.Seek(0, SeekOrigin.Begin);
                                imageStream.CopyTo(fileStream);
                            }

                            image = Image.FromFile("temp.jpg");
                            break;
                        case DownloadStatus.Failed:
                            break;
                    }
                };

                request.Download(imageStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Console.WriteLine("Drive: connected");
            return image;
        }
        public Image LoadImage(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        return Bitmap.FromStream(str);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("credentials: " + credentialsPath);
                Console.WriteLine("Failed to load image: " + ex.Message);
            }

            return null;
        }
    }
}
