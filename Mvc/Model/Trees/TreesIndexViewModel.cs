namespace Mvc.Model.Trees
{
    public class TreesIndexViewModel
    {
        public TreeListViewModel TreeList { get; set; }

        public TreesIndexViewModel()
        {
            
        }

        public TreesIndexViewModel(TreeListViewModel treeList)
        {
            TreeList = treeList;
        }
        
    }
}