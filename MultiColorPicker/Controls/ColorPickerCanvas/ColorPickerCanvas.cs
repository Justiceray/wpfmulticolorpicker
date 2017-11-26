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
    [TemplatePart(Name = "PART_ColorShadingCanvas", Type = typeof(Canvas))]
    [TemplatePart(Name = "PART_ColorShadeSelector", Type = typeof(Canvas))]
    public class ColorPickerCanvas : Control
    {
        #region Private Members

        private Canvas m_ColorShadingCanvas;

        private Canvas m_ColorShadeSelector;

        #endregion

        static ColorPickerCanvas()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ColorPickerCanvas), new FrameworkPropertyMetadata(typeof(ColorPickerCanvas)));
        }

        public ColorPickerCanvas()
        {
            base.OnApplyTemplate();

            if (this.m_ColorShadeSelector != null)
            {
                m_ColorShadeSelector.MouseLeftButtonDown += ColorShadeSelector_MouseLeftButtonDown;
                m_ColorShadeSelector.MouseLeftButtonUp += ColorShadeSelector_MouseLeftButtonUp;
                m_ColorShadeSelector.MouseMove += ColorShadeSelector_MouseMove;
                m_ColorShadeSelector.SizeChanged += ColorShadeSelector_SizeChanged;
            }

            if (this.m_ColorShadingCanvas != null)
            {
                m_ColorShadingCanvas.MouseLeftButtonDown += ColorShadingCanvas_MouseLeftButtonDown;
                m_ColorShadingCanvas.MouseLeftButtonUp += ColorShadingCanvas_MouseLeftButtonUp;
                m_ColorShadingCanvas.MouseMove += ColorShadingCanvas_MouseMove;
                m_ColorShadingCanvas.SizeChanged += ColorShadingCanvas_SizeChanged;
            }

        }

        private void ColorShadingCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadingCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadingCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadingCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadeSelector_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadeSelector_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadeSelector_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ColorShadeSelector_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
