namespace xLMAOxSTARTER.Views;

public partial class DefaultPage : ContentPage
{
    int count = 0;

    public DefaultPage()
    {
        InitializeComponent();

        Usages.ItemsSource = AppInfo.SampleUsages;
    }

    private void Usages_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        Usages.SelectedItem = null;
    }

    private async void Usages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (Usages.SelectedItem is null)
        {
            await DisplayAlert("Lorem", "ching chong", "gay");
            return;
        }
    }
}