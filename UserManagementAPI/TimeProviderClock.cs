using Microsoft.AspNetCore.Authentication;
using System;

public class TimeProviderClock : ISystemClock
{
    private readonly TimeProvider _timeProvider;

    public TimeProviderClock(TimeProvider timeProvider)
    {
        _timeProvider = timeProvider;
    }

    public DateTimeOffset UtcNow => _timeProvider.GetUtcNow();
}
