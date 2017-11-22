using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultiColorPicker.Controls.MultiColorPickerControl
{
    /// <summary>
    /// 允许多重拾取颜色的自定义控件。
    /// </summary>
    public class MultiColorPickerControl : Control
    {

        #region Fields & Properties
        

        #endregion
        static MultiColorPickerControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MultiColorPickerControl), new FrameworkPropertyMetadata(typeof(MultiColorPickerControl)));
        }
    }
}
