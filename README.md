# HorizontalListView
Simple Cross-Platform Horizontal Listview using Xamarin.Forms


Sample usage:(XAML) 

```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms" xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
x:Class="test.ListPage" xmlns:Controls="clr-namespace:test;assembly=test"> 

<Controls:HorizontalListView ItemsSource="{Binding Categories}" ListOrientation="Horizontal"> 
  <Controls:HorizontalListView.ItemTemplate> 
    <DataTemplate> 
    <Label Text="{Binding Name}" Grid.Row="0" YAlign="Center" /> 
    </DataTemplate> 
  </Controls:HorizontalListView.ItemTemplate> 
  </Controls:myControl>
</ContentPage>
