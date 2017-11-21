using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MultiColorPicker.Common
{
    /// <summary>
    /// ViewModelBase
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Private Methods

        /// <summary>
        /// 获取属性名
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        private static string GetPropertyName<T>(Expression<Func<T>> action)
        {
            var expression = (MemberExpression)action.Body;
            var propertyName = expression.Member.Name;
            return propertyName;
        }

        /// <summary>
        /// 触发属性更改
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion


        #region Public Methods

        /// <summary>
        /// 属性更改事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression"></param>
        public void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var propertyName = GetPropertyName(expression);
            OnPropertyChanged(propertyName);
        }

        #endregion

        #region Implemention of INotifyPropertyChanged

        /// <summary>
        /// 通知更改事件
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }

}
