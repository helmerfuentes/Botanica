using System.Drawing;
using System.IO;

namespace Entidades.Helper
{
    public static class ImageHelper
    {
        public static bool AreEqual(Image image1, Image image2)
        {
            // Convertir las imágenes en matrices de bytes
            byte[] bytesImage1 = ImageToBytes(image1);
            byte[] bytesImage2 = ImageToBytes(image2);

            // Comparar los bytes de las imágenes
            return CompareByteArrays(bytesImage1, bytesImage2);
        }

        private static byte[] ImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return ms.ToArray();
            }
        }

        private static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            // Verificar la longitud de los arrays
            if (array1.Length != array2.Length)
            {
                return false;
            }

            // Comparar cada byte de los arrays
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
