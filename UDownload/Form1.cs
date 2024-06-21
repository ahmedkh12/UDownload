using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Playlists;
using YoutubeExplode.Videos.Streams;

namespace UDownload
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private async void viewbtn_Click(object sender, EventArgs e)
        {
            try 
            
            {

                await playlistview.EnsureCoreWebView2Async(null);
                var Url = "https://www.youtube.com/playlist?list=" + playid.Text;
                playlistview.CoreWebView2.Navigate(Url);



            }

            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Select Your Path" };


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                viewfile.Url = new Uri(dialog.SelectedPath);
                targetpath.Text = dialog.SelectedPath;
            }
        }

        private async void downloadbtn_Click(object sender, EventArgs e)
        {
            try {


               
               
                progressBar1.Value = 0;
                string playlistId = playid.Text;

                // Replace with the download path
                string downloadPath = targetpath.Text;

                progressBar1.Visible = true;
               
                var youtubeService = new YouTubeService(new BaseClientService.Initializer
                {
                    ApiKey = "AIzaSyDGSGz4rv4C255j5kDH0pKMwnDRvoL1Vus"
                });

                var playlistItems = new List<PlaylistItem>();
                string pageToken = null;

                do
                {
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.PlaylistId = playlistId;
                    playlistItemsListRequest.MaxResults = 150;
                    playlistItemsListRequest.PageToken = pageToken;

                    var playlistItemsListResponse = await playlistItemsListRequest.ExecuteAsync();

                    playlistItems.AddRange(playlistItemsListResponse.Items);
                    pageToken = playlistItemsListResponse.NextPageToken;
                } while (!string.IsNullOrEmpty(pageToken));


                Directory.CreateDirectory(downloadPath);


                foreach (var playlistItem in playlistItems)
                {

                    var videoId = playlistItem.Snippet.ResourceId.VideoId;
                    var videoFileName = $"{playlistItem.Snippet.Title}.mp4";
                    var videoFilePath = Path.Combine(downloadPath, videoFileName);
                    var youtube = new YoutubeClient();
                    var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoId);
                    var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, videoFilePath);
                    
                    progressBar1.Value += 1;

                }

            }
            catch (Exception ex) {
            MessageBox.Show(ex.Message);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            progressBar1.Visible= false;
        }
    }
}
