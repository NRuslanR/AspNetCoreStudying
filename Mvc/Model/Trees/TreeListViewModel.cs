using System.Collections.Generic;

namespace Mvc.Model.Trees
{
    public class TreeListViewModel : List<TreeViewModel>
    {
        public TreeListViewModel()
        {
            
        }

        public TreeListViewModel(IEnumerable<TreeViewModel> treeViewModels) : base(treeViewModels)
        {
            
        }
    }
}