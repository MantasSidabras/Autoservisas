using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDatabase.Utilities
{
    class ImageSerialization
    {
      /*  public static byte[] ImageToBytes(String path, ImageFormat imageFormat)
        {
            Image img = Image.FromFile(path);
            MemoryStream tmpStream = new MemoryStream();
            img.Save(tmpStream, imageFormat); // change to other format
            tmpStream.Seek(0, SeekOrigin.Begin);
            byte[] imgBytes = new byte[MAX_IMG_SIZE];
            tmpStream.Read(imgBytes, 0, MAX_IMG_SIZE);

            command.CommandText = "INSERT INTO images(payload) VALUES (:payload)";
            IDataParameter par = command.CreateParameter();
            par.ParameterName = "payload";
            par.DbType = DbType.Binary;
            par.Value = imgBytes;
            command.Parameters.Add(par);
            command.ExecuteNonQuery();
        }*/
    }
}
