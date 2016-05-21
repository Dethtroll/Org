using System;
using System.Collections.Generic;
using Org.Pes;

namespace Org.Common.Views
{
    public interface IDictionayView
    {
        Action Loaded { get; set; }
        Action AddItem { get; set; }
        Action<DicEditPe> AddRequested { get; set; }
        Action<DicEditPe> UpdateRequested { get; set; }
        Action<int> EditRequested { get; set; }
        Action<int> DeleteRequested { get; set; }
        Action CancelRequested { get; set; }

        void InitDic(IEnumerable<DicIndexPe> companies);
        void ShowItem(DicEditPe pe);
        void ShowEmptyItem();
    }
}