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
    [TemplatePart(Name = "PART_SpectrumDisplay", Type = typeof(Rectangle))]
    public class ColorSpectrumSlider : Slider
    {

        #region Private Members

        private Rectangle m_SpectrumDisplay;

        private LinearGradientBrush m_PickerBrush;

        #endregion

        #region Dependency Properties

        /// <summary>
        /// 当前选中的颜色的依赖项属性
        /// </summary>
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Color), typeof(ColorSpectrumSlider), new PropertyMetadata(Colors.Transparent));

        /// <summary>
        /// 当前选中的颜色
        /// </summary>
        public Color SelectedColor
        {
            get { return (Color)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        #endregion
        #region Constructor

        static ColorSpectrumSlider()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorSpectrumSlider), new FrameworkPropertyMetadata(typeof(ColorSpectrumSlider)));
        }

        #endregion

        #region Methods

        private void CreateSpectrum()
        {
            m_PickerBrush = new LinearGradientBrush();

            m_PickerBrush.StartPoint = new Point(0.5, 0);
            m_PickerBrush.EndPoint = new Point(0.5, 1);
            m_PickerBrush.ColorInterpolationMode = ColorInterpolationMode.SRgbLinearInterpolation;

        }

        #endregion
    }
}
