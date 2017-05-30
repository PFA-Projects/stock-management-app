// Mariam Ait Al

using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using StockManagement.Presentations.Print_Materials_List.By_Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities
{
    /// <summary>
    /// fr : Emplacement
    /// </summary>
    /// 
    [GwinEntity(Localizable = true, DisplayMember = "Name")]
    [Menu(Group = "Societe")]
    [ManagementForm(TitrePageGridView = "GridViewTitle",TitreButtonAjouter ="btn_Add_Location")]
    [DataGridSelectedAction(Title = "MaterialsList", Description = "Print_Material_List", TypeOfForm = typeof(FormPrintByLocation))]
    public class Location:BaseEntity
    {
        [EntryForm(Ordre =2,WidthControl =350,MultiLine = true)]
        [DataGrid(WidthColonne =300,Ordre =2)]
       // [Filter]
        public LocalizedString Description { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 350)]
        [DataGrid(WidthColonne =100,Ordre =1)]
        //[Filter]
        public LocalizedString Name { get; set; }


        // Relations
        [EntryForm(Ordre = 3, WidthControl = 350)]
        [DataGrid(WidthColonne = 100, Ordre = 3)]
        [Filter(isDefaultIsEmpty =true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Service Service { get; set; }
    }
}
