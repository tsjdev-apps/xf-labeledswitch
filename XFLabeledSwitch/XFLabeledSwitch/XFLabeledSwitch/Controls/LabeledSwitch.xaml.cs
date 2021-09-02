using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFLabeledSwitch.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabeledSwitch : ContentView
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(LabeledSwitch));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        public static readonly BindableProperty DetailProperty =
            BindableProperty.Create(nameof(Detail), typeof(string), typeof(LabeledSwitch));

        public string Detail
        {
            get => (string)GetValue(DetailProperty);
            set => SetValue(DetailProperty, value);
        }


        public static readonly BindableProperty IsCheckedProperty =
            BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(LabeledSwitch));

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }

        public LabeledSwitch()
        {
            InitializeComponent();
        }

        private void OnTapped(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
        }
    }
}