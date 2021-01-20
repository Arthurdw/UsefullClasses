﻿using System.Drawing;
using System.IO;

namespace UsefullClassesDevelopment
{
    /// <summary>
    /// A collection of methods that simplify the conversion of Images to bytes and vise versa.
    /// </summary>
    internal class ImageHandler
    {
        /// <summary>
        /// Convert a collection of bytes to an <c>Image</c> object.
        /// </summary>
        /// <param name="bytes">The data that will be used to form the image object.</param>
        /// <returns>An <c>Image</c> object that can be used in windows forms applications.</returns>
        /// <see cref="Image"/>
        public Image BytesToImage(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
                return Image.FromStream(ms);
        }

        /// <summary>
        /// Convert an <c>Image</c> object to a collection of bytes.
        /// </summary>
        /// <param name="image">The image object that will be used as source of the bytes collection.</param>
        /// <returns>The image as a bytes collection.</returns>
        /// <see cref="Image"/>
        public byte[] ImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image in the current MemoryStream.
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}