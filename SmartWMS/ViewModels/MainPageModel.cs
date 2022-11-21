using SmartWMS.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using SmartWMS.DTO.VirtualModels;
using System.Net;
using SmartWMS.DTO.Models;
using System.ComponentModel;
using Microsoft.Extensions.Logging;

namespace SmartWMS.ViewModels
{
    public class MainPageModel : BaseViewModel
    {
        private IRestClientService RestService => DependencyService.Get<IRestClientService>();
        private IUserService UserService => DependencyService.Get<IUserService>();

        public MainPageModel()
        {
            Title = "Menu principal";
        }
        private string strCode;
        public string Code { get => strCode; set => SetProperty(ref strCode, value); }

        private string strCookies;
        public string Cookies { get => strCookies; set => SetProperty(ref strCookies, value); }

        private string strCookieName;
        public string CookieName { get => strCookieName; set => SetProperty(ref strCookieName, value); }

        private string strResult;
        public string Result { get => strResult; set => SetProperty(ref strResult, value); }

        private string strCookiesList;
        public string CookiesList { get => strCookiesList; set => SetProperty(ref strCookiesList, value); }

        private Command _LoginCommand;
        public ICommand LoginCommand => _LoginCommand ??= new Command(GetLogin);
        private async void GetLogin()
        {
            try
            {               
                Code = string.Empty;

                Login login = new()
                {
                    UserName = "admin",
                    Password = "admin"
                };
                var rslt = await RestService.LoginAsync(login);

                if (rslt)
                {
                    Constants.ConnectedUser = await UserService.GetUserAsync(login.UserName);


                    Result = $"{Constants.ConnectedUser.Name} {Constants.ConnectedUser.Email}";

                    Code = "Connected";
                    CookiesList = "";

                    foreach (Cookie cookie in Constants.Cookies)
                    {
                        CookiesList += $"{cookie.Name}: {cookie.Value}{Environment.NewLine}";
                    }

                    Log.Info("Connected");
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur", ex.Message, "OK");
            }
        }

        private Command _GetPartnersCommand;
        public ICommand GetPartnersCommand => _GetPartnersCommand ??= new Command(GetPartners);
        private async void GetPartners()
        {
            try
            {
                IsRefreshing = true;
                Result = "";
                var rslt = await RestService.RestServiceGetAsync<Partner>(Constants.Models.Base.Partner);

                PartnersList = rslt.Data;
                Log.Info("Data Loaded");
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erreur", ex.Message, "OK");
            }
            finally
            {
                IsRefreshing = false;
            }
        }

        private List<Partner> _items;
        private Partner _selectedItem;
        private bool _isRefreshing;

        public List<Partner> PartnersList
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged(nameof(PartnersList));
            }
        }

        public Partner SelectedPartner
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedPartner));
            }
        }

        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        #region INotifyPropertyChanged implementation

        #endregion
    }

}