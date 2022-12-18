﻿using System.Collections.Specialized;

namespace PersianCalendar.WinUI3.Contracts.Services;

public interface IAppNotificationService
{
    void Initialize();

    bool Show(string payload);

    NameValueCollection ParseArguments(string arguments);

    void Unregister();
}
