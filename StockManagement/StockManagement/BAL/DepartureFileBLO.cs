// Mariam Ait Al
// 2017

using StockManagement.BAL;
using StockManagement.DAL;
using StockManagement.Entities;
using StockManagement.Entities.Mail_Management;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement.BAL
{
   public class DepartureFileBLO:BaseBLO<DepartureFile>
    {
        ModelContext db = new ModelContext();

        public DepartureFileBLO(DbContext context) : base(context)
        {
        }

        public DepartureFileBLO() : base()
        {
        }
        /// <summary>
        /// Convert Image to byte[]
        /// </summary>
        /// <param name="picturebox1"></param>
        /// <returns></returns>
        public byte[] Convert(PictureBox picturebox1)
        {
            Image img = picturebox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            return arr;
        }

        /// <summary>
        /// Get Image and set it into the pictureBox
        /// </summary>
        /// <param name="imageArray"></param>
        /// <param name="pictureButton"></param>
        public void FromByteToImage(byte[] imageArray,PictureBox pictureButton)
        {
            ImageConverter converter = new ImageConverter();
            pictureButton.Image = (Image)converter.ConvertFrom(imageArray);
        }


        /// <summary>
        /// Select Departure Files by Departure
        /// </summary>
        /// <param name="Departure"></param>
        /// <returns></returns>
        public List<DepartureFile> GetDepFilesByDeparture(Departure Departure)
        {
            var query = from d in db.DepartureFiles
                        where d.Departure.Id == Departure.Id
                        select d;
            return query.ToList<DepartureFile>();
        }
    }
}
