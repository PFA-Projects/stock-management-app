// Mariam Ait Al
// 2017
using App.Gwin.Attributes;
using App.Gwin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Mail_Management
{
    [GwinEntity(Localizable = true, DisplayMember = "Reference")]
    [Menu(Group = "Operations")]
    [ManagementForm(TitrePageGridView = "Departure_Files_DGV", TitreButtonAjouter = "btn_add_DepartureFile", Height = 580, Width = 1050)]
    public class DepartureFile:BaseEntity
    {

        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [DataGrid(Ordre = 1)]
        [EntryForm(isDefaultIsEmpty = true)]
        public Departure Departure { get; set; }

        public Byte[] File { get; set; }
    }
}
