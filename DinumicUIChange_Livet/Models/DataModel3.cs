using System;

namespace DynamicUIChange_Livet.Models
{


    public class DataModel3
    {
        public DataModel3()
        {

        }

        private string _uriPath = "";
        public string UriPath
        {
            get => _uriPath;
            set
            {
                _uriPath = value;
                if (!string.IsNullOrEmpty(value))
                    UriField = new Uri(value);
            }
        }

        public Uri UriField
        {
            get; set;
        } = null!;

    }
}
