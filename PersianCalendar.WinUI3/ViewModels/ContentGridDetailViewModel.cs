﻿using CommunityToolkit.Mvvm.ComponentModel;

using PersianCalendar.WinUI3.Contracts.ViewModels;
using PersianCalendar.Core.Contracts.Services;
using PersianCalendar.Core.Models;

namespace PersianCalendar.WinUI3.ViewModels;

public class ContentGridDetailViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;
    private SampleOrder? _item;

    public SampleOrder? Item
    {
        get => _item;
        set => SetProperty(ref _item, value);
    }

    public ContentGridDetailViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        if (parameter is long orderID)
        {
            var data = await _sampleDataService.GetContentGridDataAsync();
            Item = data.First(i => i.OrderID == orderID);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
