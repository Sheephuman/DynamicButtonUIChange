using System.ComponentModel.DataAnnotations;
using System.Windows.Controls;

namespace DynamicUIChange.Model
{


    public class DataModel1
    {


        public required Image BackImage { get; set; }

        public required Image BackImage2 { get; set; }
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
