namespace NotificationService.Contracts.Enums;

/// <summary>
/// Priority level of a notification.
/// Higher priority notifications may be delivered more urgently or displayed more prominently.
/// </summary>
public enum NotificationPriority
{
    /// <summary>
    /// Low priority - informational notifications that can be batched or delayed.
    /// </summary>
    Low = 0,

    /// <summary>
    /// Normal priority - standard notifications delivered in normal timeframes.
    /// </summary>
    Normal = 1,

    /// <summary>
    /// High priority - important notifications that should be delivered promptly.
    /// </summary>
    High = 2,

    /// <summary>
    /// Urgent priority - critical notifications requiring immediate attention.
    /// </summary>
    Urgent = 3
}
