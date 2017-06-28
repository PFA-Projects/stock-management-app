using StockManagement.DAL;
using StockManagement.Entities.Mail_Management;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.BAL
{
    public class DepartureFileBLO : BaseBLO<DepartureFile>
    {
        ModelContext db = new ModelContext();

        public DepartureFileBLO(DbContext context) : base(context)
        {
        }

        public DepartureFileBLO() : base()
        {
        }



        private byte[] GetFichier(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] fichier = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            return fichier;
        }
    }
}
