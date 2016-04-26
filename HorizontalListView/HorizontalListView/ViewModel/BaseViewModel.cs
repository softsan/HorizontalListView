using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace HorizontalListView
{
	public abstract class BaseViewModel : INotifyPropertyChanged
	{
		private bool isBusy;

		public bool IsBusy {
			get { return isBusy; }
			set {
				this.isBusy = value;
				NotifyPropertyChanged ("IsBusy");
			}
		}

		/// <summary>
		/// Responsible to change value and notify respective page for property changed
		/// </summary>
		/// <typeparam name="T"> type of T</typeparam>
		/// <param name="property">Property type </param>
		/// <param name="value">value </param>
		/// <param name="propertyName">name of property </param>
		/// <returns>True if property changed and notified, false other wise</returns>
		protected bool ChangeAndNotify<T> (ref T property, T value, [CallerMemberName] string propertyName = "")
		{
			if (!EqualityComparer<T>.Default.Equals (property, value)) {
				property = value;
				NotifyPropertyChanged (propertyName);
				return true;
			}

			return false;
		}

		/// <summary>
		/// Invoke when a property value is changed
		/// </summary>
		/// <param name="propertyName">property name</param>
		protected void NotifyPropertyChanged ([CallerMemberName] string propertyName = "")
		{
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}

		protected virtual void OnPropertyChanged (string propertyName)
		{
			//this.VerifyPropertyName(propertyName);
			try {
				PropertyChangedEventHandler handler = this.PropertyChanged;
				if (handler != null) {
					var e = new PropertyChangedEventArgs (propertyName);
					handler (this, e);
				}
			} catch (Exception ex) {
				ex.Message.ToString ();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}

