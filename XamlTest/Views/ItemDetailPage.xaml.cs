using System;

using Xamarin.Forms;

namespace XamlTest
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            //  <Label x:Name="myLabel" Text="{Binding Item.Description}" FontSize="Small" />
            BindingContext = this.viewModel = viewModel;
        }
    }
}
