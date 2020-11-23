using Mvc.Areas.Trees.Model.Common;

namespace Mvc.Areas.Trees.Model.Home
{
    public class HomeIndexViewModel
    {
        public TreeListViewModel TreeList { get; set; }

        public HomeIndexViewModel()
        {
            
        }

        public HomeIndexViewModel(TreeListViewModel treeList)
        {
            TreeList = treeList;
        }
        
    }
}