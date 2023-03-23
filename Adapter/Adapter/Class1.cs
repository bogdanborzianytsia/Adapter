using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace gonki
{
    interface IPhoto
    {
        void print();

    }

    class Photo : IPhoto
    {
        public string PhotoType { get; set; }
        public string prin, name;    
        public void print()
        {
            prin = name + " have type " + PhotoType;
        }
    }
    class BitmapAdapter : Photo
    {
        private Photo photo;

        public BitmapAdapter(Photo phot)
        {
            photo = phot;
            name = "BitmapPhoto";
            PhotoType = "Bitmap";

        }
        public void print()
        {

            photo.print();
            prin = name + " have type " + PhotoType;

        }

    }
    class JPEGAdapter : Photo
    {
        private Photo photo;

        public JPEGAdapter(Photo phot)
        {
            photo = phot;
            name = "JPEGphoto";
            PhotoType = "JPEG";
        }

        public void print()
        {
            photo.print();
            prin = name + " have type " + PhotoType;
        }
    }

    class PNGAdapter : Photo
    {
        private Photo photo;

        public PNGAdapter(Photo phot)
        {
            photo = phot;
            name = "PNGphoto";
            prin = name + " have type " + PhotoType;

        }
        public void print()
        {
            photo.print();
            prin = name + " have type " + PhotoType;
        }
    }
    class VectorAdapter : Photo
    {
        private Photo photo;
        public VectorAdapter(Photo phot)
        {
            photo = phot;
            name = "VectorPhoto";
            PhotoType = "Vector";
        }

        public void print()
        {
            photo.print();
            prin = name + " have type " + PhotoType;
        }
    }
}