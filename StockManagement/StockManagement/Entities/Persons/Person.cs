using App.Gwin.Attributes;
using App.Gwin.Entities;
using App.Gwin.Entities.MultiLanguage;
using GenericWinForm.Demo.Entities.ContactInformations;
using StockManagement.Entities.ContactInformations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Entities.Persons
{
    
    public class Person : BaseEntity
    {

        public override string ToString() =>  this.LastName + " " + this.FirstName;

        public Person()
        {
            this.LastName = new LocalizedString();
            this.FirstName = new LocalizedString();
            this.DateOfBirth = DateTime.Now.AddYears(-23);
        }

        // 
        // Civil status
        //
        [EntryForm(Ordre = 1, GroupeBox = "Civil status", GroupeBoxOrder =1,isRequired = true)]
        [Filter()]
        [DataGrid(WidthColonne = 100)]
        public LocalizedString FirstName { set; get; }

        [EntryForm(Ordre = 2,GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        [Filter()]
        [DataGrid(WidthColonne = 100)]
        public LocalizedString LastName { set; get; }

        [DisplayProperty(Title = "CIN")]
        [EntryForm(Ordre = 3, GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        [Filter()]
        [DataGrid(WidthColonne = 50)]
        public String CIN { set; get; }

        [DisplayProperty(Title = "Date de naissance" )]
        [EntryForm(Ordre = 4, GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        public DateTime DateOfBirth { set; get; }

        [DisplayProperty(Title = "Sexe")]
        [EntryForm(Ordre = 5, GroupeBox = "Civil status", GroupeBoxOrder = 1, isRequired = true)]
        public bool Sex { set; get; }
       
        public String ProfilePhoto { set; get; }

 
        #region Contact Information

        [EntryForm(Ordre = 10,GroupeBox = "Contact Information", GroupeBoxOrder = 10)]
        public String Email { set; get; }


        [EntryForm(Ordre = 11,GroupeBox = "Contact Information", GroupeBoxOrder = 10)]
        public String PhoneNumber { set; get; }


        [EntryForm(Ordre = 12, MultiLine = true, GroupeBox = "Contact Information", GroupeBoxOrder = 101)]
        public String Address { set; get; }

        [EntryForm(Ordre = 13, GroupeBox = "Contact Information", GroupeBoxOrder = 10,isDefaultIsEmpty = true)]
        [Filter(isDefaultIsEmpty = true)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [SelectionCriteria(typeof(Country))]
        public City City { set; get; }

        [EntryForm(Ordre = 14, GroupeBox = "Contact Information", GroupeBoxOrder = 10)]
        public string Cellphone { set; get; }

        [EntryForm(Ordre = 15, GroupeBox = "Contact Information", GroupeBoxOrder = 10)]
        public string FaceBook { set; get; }

        [EntryForm(Ordre = 16, GroupeBox = "Contact Information", GroupeBoxOrder = 10)]
        public string WebSite { set; get; }
        #endregion



        
    }
}
