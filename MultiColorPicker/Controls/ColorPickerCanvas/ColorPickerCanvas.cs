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

namespace MultiColorPicker.Controls.ColorPickerCanvas
{

    /// <summary>
    /// 单色拾色器
    /// </summary>
    public class ColorPickerCanvas : Control
    {
        #region Properties & Fields

        private int m_Red;

        public int Red
        {
            get
            {
                return m_Red;
            }
            set
            {
                m_Red = value;
            }
        }

        private int m_Green;

        public int Green
        {
            get
            {
                return m_Green;
            }
            set
            {
                m_Green = value;
            }
        }

        private int m_Blue;

        public int Blue
        {
            get
            {
                return m_Blue;
            }
            set
            {
                m_Blue = value;
            }
        }

        #endregion

        static ColorPickerCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPickerCanvas), new FrameworkPropertyMetadata(typeof(ColorPickerCanvas)));
        }
    }
}
