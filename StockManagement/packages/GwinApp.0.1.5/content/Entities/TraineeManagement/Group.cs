using App.Gwin.Attributes;
using App.Gwin.Entities;
namespace SamplesGwin.Entities.TraineeManagement
{

    [GwinEntity(Localizable =true,isMaleName =true,DisplayMember = "Name")]
    [Menu(Group= "Trainee")]
    [ManagementForm(TitrePageGridView ="grid_title",Width =740)]
    public class Group : BaseEntity
    {
        
        [EntryForm(Ordre = 1,WidthControl =250,isRequired =true)]
        [Filter(WidthControl =150,Ordre =1)]
        [DataGrid(WidthColonne = 150,Ordre =1)]
        public string Name { set; get; }

        [EntryForm(Ordre = 2, WidthControl = 300,MultiLine = true)]
        [Filter(WidthControl = 150, Ordre = 2)]
        [DataGrid(WidthColonne = 150, Ordre = 2)]
        public string Description { set; get; }


    }
}
