
using System.Text.RegularExpressions;

namespace RichTextEditorUsingjQuery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var data = await webView.EvaluateJavaScriptAsync($"document.getElementById('content').value;");
            string html = Regex.Unescape(data);

            await Shell.Current.DisplayAlert("RichTextBoxContent", html, "OK");
        }
    }

}
