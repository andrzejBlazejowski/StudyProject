using System.Windows;
using System.Windows.Controls;

namespace StudyProject.View
{
    public class AllViewBase : UserControl
    {
        static AllViewBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AllViewBase), new FrameworkPropertyMetadata(typeof(AllViewBase)));
        }
    }
}
