using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TailBlazer.Domain.Infrastructure;
using TailBlazer.Infrastucture;

namespace TailBlazer.Views.Tail
{
    public interface ILinesVisualisation : IScrollReceiver, IDisposable
    {
        ReadOnlyObservableCollection<LineProxy> Lines { get; }
        IProperty<int> Count { get; }
        ICommand CopyToClipboardCommand { get; }
        ISelectionMonitor SelectionMonitor { get; }

        int PageSize { get; set; }
        int FirstIndex { get; set; }
    }
}