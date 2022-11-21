//using Android.Content;
//using Android.Views.InputMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SmartWMS.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation;
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }

        // Shows the soft keyboard
        //public void showSoftKeyboard(Android.App.Activity activity, Xamarin.Forms.View view)
        //{
        //    InputMethodManager inputMethodManager = (InputMethodManager)activity.GetSystemService(Context.InputMethodService);
        //    view.RequestFocus();
        //    inputMethodManager.ShowSoftInput(view, 0);
        //    inputMethodManager.ToggleSoftInput(ShowFlags.Forced, HideSoftInputFlags.ImplicitOnly);//personal line added
        //}

        // Hides the soft keyboard
        //public void HideSoftKeyboard(Android.App.Activity activity)
        //{
        //    var currentFocus = activity.CurrentFocus;
        //    if (currentFocus != null)
        //    {
        //        InputMethodManager inputMethodManager = (InputMethodManager)activity.GetSystemService(Context.InputMethodService);
        //        inputMethodManager.HideSoftInputFromWindow(currentFocus.WindowToken, HideSoftInputFlags.None);
        //    }
        //}
    }
}

