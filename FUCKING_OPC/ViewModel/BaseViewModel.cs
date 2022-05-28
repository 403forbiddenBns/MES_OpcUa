using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace MES_OpcUa.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public virtual bool Set<T>(ref T field, T value, [CallerMemberName] string PropertyName = "")
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }

        public static string GetPropertyName<T>(Expression<Func<T>> e)
        {
            var member = (MemberExpression)e.Body;
            return member.Member.Name;
        }

        /// <summary>
        /// Raise when property value propertychanged or override propertychage
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyExpression"></param>
        protected virtual void RaisePropertyChanged<T>
            (Expression<Func<T>> propertyExpression)
        {
            RaisePropertyChanged(GetPropertyName(propertyExpression));
        }
        /// <summary>
        /// Raise when property value propertychanged
        /// </summary>
        /// <param name="propertyName"></param>
        protected void RaisePropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler temp = PropertyChanged;
            if (temp != null)
            {
                temp(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}