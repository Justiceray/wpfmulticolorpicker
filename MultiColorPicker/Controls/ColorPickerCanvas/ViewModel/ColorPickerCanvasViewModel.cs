using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiColorPicker.Common;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;
using Prism.Mvvm;

namespace MultiColorPicker.Controls.ColorPickerCanvas.ViewModel
{

    public class ColorPickerCanvasViewModel : BindableBase
    {


        #region Properties & Fields

        private byte m_Red;

        /// <summary>
        /// RGB中的R值
        /// </summary>
        public byte Red
        {
            get
            {
                return m_Red;
            }
            set
            {
                m_Red = value;
                SetProperty(ref m_Red, value);
            }
        }

        private byte m_Green;

        /// <summary>
        /// RGB中的G值
        /// </summary>
        public byte Green
        {
            get
            {
                return m_Green;
            }
            set
            {
                m_Green = value;
                SetProperty(ref m_Green, value);
            }
        }

        private byte m_Blue;

        /// <summary>
        /// RGB中的B值
        /// </summary>
        public byte Blue
        {
            get
            {
                return m_Blue;
            }
            set
            {
                m_Blue = value;
                SetProperty(ref m_Blue, value);
            }
        }

        public byte m_AlphaChannel;

        /// <summary>
        /// Alpha通道
        /// </summary>
        public byte AlphaChannel
        {
            get
            {
                return m_AlphaChannel;
            }
            set
            {
                m_AlphaChannel = value;
                SetProperty(ref m_AlphaChannel, value);
            }
        }

        private int m_Saturation;

        /// <summary>
        /// 饱和度
        /// </summary>
        public int Saturation
        {

            get
            {
                return m_Saturation;
            }
            set
            {
                m_Saturation = value;
                SetProperty(ref m_Saturation, value);
            }
        }


        private int m_Luminance;

        /// <summary>
        /// 亮度
        /// </summary>
        public int Luminance
        {
            get
            {
                return m_Luminance;
            }
            set
            {
                m_Luminance = value;
                SetProperty(ref m_Luminance, value);
            }
        }


        private int m_Hue;

        /// <summary>
        /// 色调
        /// </summary>
        public int Hue
        {
            get
            {
                return m_Hue;
            }
            set
            {
                m_Hue = value;
                SetProperty(ref m_Hue, value);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ColorPickerCanvasViewModel()
        {

        }

        #endregion
    }
}
