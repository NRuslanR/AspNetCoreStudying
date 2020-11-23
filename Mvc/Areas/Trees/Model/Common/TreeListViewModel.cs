using System.Collections.Generic;

namespace Mvc.Areas.Trees.Model.Common
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