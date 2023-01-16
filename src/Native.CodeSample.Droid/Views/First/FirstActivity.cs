using System;
using Android.OS;
using Android.App;
using Android.Widget;

using MvvmCross.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Binding;
using MvvmCross.Platforms.Android.Presenters.Attributes;

using Native.CodeSample.Droid.Views.Base;
using Native.CodeSample.Core.ViewModels.First;

using Xamarin.Essentials;

namespace Native.CodeSample.Droid.Views.First
{
    [MvxActivityPresentation]
    [Activity(
        NoHistory = true,
        MainLauncher = true,
        Theme = "@style/AppTheme.Splash",
        Label = "@string/app_name",
        Icon = "@mipmap/ic_launcher")]
    public sealed class FirstActivity : BaseActivity<FirstViewModel>
    {
        private EditText _firstEditText;
        private EditText _secondEditText;
        private Button _button;

        private MvxInteraction _invalidInputInteraction;
        public MvxInteraction InvalidInputInteraction
        {
            get => _invalidInputInteraction;
            set
            {
                if (_invalidInputInteraction != null)
                    _invalidInputInteraction.Requested -= OnInvalidInput;

                _invalidInputInteraction = value;
                _invalidInputInteraction.Requested += OnInvalidInput;
            }
        }

        protected override int LayoutId => Resource.Layout.first;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Platform.Init(this, savedInstanceState);
            base.OnCreate(savedInstanceState);
            AndroidX.Core.SplashScreen.SplashScreen.InstallSplashScreen(this);
            InitializeView();
        }

        protected override void CreateBindings(
            MvxFluentBindingDescriptionSet<IMvxAndroidView<FirstViewModel>, FirstViewModel> set)
        {
            set.Bind(_firstEditText)
                .For(v => v.BindText())
                .To(vm => vm.FirstText);

            set.Bind(_secondEditText)
                .For(v => v.BindText())
                .To(vm => vm.SecondText);

            set.Bind(_button)
                .For(v => v.BindClick())
                .To(vm => vm.GoCommand);

            set.Bind(_button)
                .For(v => v.BindText())
                .ToLocalizationId("ButtonTitle");

            set.Bind(this)
                .For(v => v.InvalidInputInteraction)
                .To(vm => vm.InvalidInputInteraction)
                .OneWay();

            set.Apply();
        }

        protected override void FindViews()
        {
            _firstEditText = FindViewById<EditText>(Resource.Id.first_edit_text);
            _secondEditText = FindViewById<EditText>(Resource.Id.second_edit_text);
            _button = FindViewById<Button>(Resource.Id.button);
        }

        private void OnInvalidInput(object sender, EventArgs e)
        {
            // TODO: trigger input shake animation
        }
    }
}
