using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using System;

namespace SamplesGwin.Entities.TraineeManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "Trainee")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =1120)]
    public class Trainee : BaseEntity
    {
        public Trainee()
        {
            this.DateOfBirth = DateTime.Now;
        }


        //
        // Civil status
        //
        [DataGrid(WidthColonne = 100)]
        [EntryForm(Ordre = 1, GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        [Filter("FirstName")]
        public LocalizedString FirstName { get; set; }

        [DataGrid(WidthColonne = 100)]
        [EntryForm(Ordre = 2, GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        [Filter("LastName")]
        public LocalizedString LastName { get; set; }

        [DisplayProperty(Title = "Date de naissance")]
        [EntryForm(Ordre = 4, GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        public DateTime DateOfBirth { get; set; }

        // 
        // Affectation
        //
        [DisplayProperty(DisplayMember = "Nom")]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [EntryForm(Ordre = 3,GroupeBox = "Assignments",WidthControl =200,GroupeBoxOrder =101)]
        [Filter(isDefaultIsEmpty  =true,Ordre =5,WidthControl =150)]
        [DataGrid(WidthColonne = 200,Ordre =20)]
        public  Group Group { set; get; }
        
        


      

    }
}

