**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13203/how-to-add-or-remove-an-item-from-net-maui-listview-sflistview)**

## Sample

```xaml
<StackLayout>
    <Grid HeightRequest="50" ColumnSpacing="5" Padding="5"> 
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="*"/>
        </Grid.ColumnDefinitions>
        <Button Text="Add item" Grid.Column="0" Command="{Binding AddCommand}"/>
        <Button Text="Delete last item" Grid.Column="1" Command="{Binding DeleteCommand}"/>
    </Grid>
    <listView:SfListView x:Name="listView" ItemSize="70" ItemsSource="{Binding ContactsInfo}" VerticalOptions="FillAndExpand">
        <listView:SfListView.ItemTemplate>
            <DataTemplate>
                <code>
                . . .
                . . .
                <code>
            </DataTemplate>
        </listView:SfListView.ItemTemplate>
    </listView:SfListView>
</StackLayout>

ViewModel.cs:
public Command AddCommand { get; set; }
public Command DeleteCommand { get; set; }

AddCommand = new Command(OnAddTapped);
DeleteCommand = new Command(OnDeleteTapped);

private void OnDeleteTapped(object obj)
{
    if (ContactsInfo.Count > 0)
        ContactsInfo.Remove(ContactsInfo[ContactsInfo.Count - 1]);
    else
        App.Current.MainPage.DisplayAlert("Alert", "There is no item in the list", "OK");
}

private void OnAddTapped(object obj)
{
    var details = new Contacts()
    {
        ContactName = CustomerNames[r.Next(1, 50)],
        ContactNumber = r.Next(100, 400).ToString() + "-" + r.Next(500, 800).ToString() + "-" + r.Next(1000, 2000).ToString(),
        ContactImage = "people_circle" + r.Next(0, 19) + ".png"
    };

    ContactsInfo.Add(details);
}
```
