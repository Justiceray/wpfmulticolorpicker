using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiColorPicker.Common;

namespace MultiColorPicker.Controls.ColorPickerCanvas.ViewModel
{
    public class ColorPickerCanvasViewModel : ViewModelBase
    {
        #region Properties & Fields

        private int m_Red;

        /// <summary>
        /// RGB中的R值
        /// </summary>
        public int Red
        {
            get
            {
                return m_Red;
            }
            set
            {
                m_Red = value;
                OnPropertyChanged(() => Red);
            }
        }

        private int m_Green;

        /// <summary>
        /// RGB中的G值
        /// </summary>
        public int Green
        {
            get
            {
                return m_Green;
            }
            set
            {
                m_Green = value;
                OnPropertyChanged(() => Green);
            }
        }

        private int m_Blue;

        /// <summary>
        /// RGB中的B值
        /// </summary>
        public int Blue
        {
            get
            {
                return m_Blue;
            }
            set
            {
                m_Blue = value;
                OnPropertyChanged(() => Blue);
            }
        }

        public int m_AlphaChannel;

        /// <summary>
        /// Alpha通道
        /// </summary>
        public int AlphaChannel
        {
            get
            {
                return m_AlphaChannel;
            }
            set
            {
                m_AlphaChannel = value;
                OnPropertyChanged(() => AlphaChannel);
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
                OnPropertyChanged(() => Saturation);
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
                OnPropertyChanged(() => Luminance);
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
                OnPropertyChanged(() => Hue);
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
