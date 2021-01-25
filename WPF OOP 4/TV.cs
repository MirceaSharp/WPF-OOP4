using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP_4
{
    class TV
    {

        private string _image;
        private int _imageSize;
        private int _herz;
        private int _channel;
        private string _brand;
        private bool _power;
        private bool _teletext;
        private string _type;
        private int _volume;

        public string Image { get; set; }
        public int ImageSize { get; set; }
        public int Herz { get; set; }
        public int Channel { get; set; }
        public string Brand { get; set; }
        public bool Power { get; set; }
        public bool Teletext { get; set; }
        public string Type { get; set; }

        public int Volume { get; set; }


        public TV(string brand,string type,int herz,int imageSize,string image)
        {
            this.Brand = brand;
            this.Type = type;
            this.Herz = herz;
            this.ImageSize = imageSize;
            this.Image = image;
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
