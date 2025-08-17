using System.ComponentModel.DataAnnotations;
using System.Windows.Media;

namespace DynamicUIChange_Livet.Models
{


    public class DataModel1
    {


        public ImageSource ModelBackImage { get; set; }

        public ImageSource ModelBackImage2 { get; set; }


        [Required]
        public double Width { get; set; }
        [Required]
        public double Height { get; set; }

        public DataModel1()
        {
            Width = 300;
            Height = 200;

        }

    }
}
