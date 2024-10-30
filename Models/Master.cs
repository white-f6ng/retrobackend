using System.ComponentModel.DataAnnotations.Schema;

namespace retroBackend.Class
{
    //[Table("mock_data")]
    public class Master
    {
        #region Private Fields
        private int id;
        private string title;
        private string subtitle;
        private string text;
        private string src;
        private string videoSrc;
        private bool? showVideo;
        private int? progress;
        #endregion

        #region Public Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public string Src
        {
            get { return src; }
            set { src = value; }
        }

        public string VideoSrc
        {
            get { return videoSrc; }
            set { videoSrc = value; }
        }

        public bool? ShowVideo
        {
            get { return showVideo; }
            set { showVideo = value; }
        }

        public int? Progress
        {
            get { return progress; }
            set { progress = value; }
        }

        #endregion

        public Master()
        {
            title = string.Empty; // Initialize to a default value
            subtitle = string.Empty;
            text = string.Empty;
            src = string.Empty;
            videoSrc = string.Empty;
        }
    }

    }