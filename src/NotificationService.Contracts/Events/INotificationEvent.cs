using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Base interface for all notification events.
/// All events published to RabbitMQ for the Notification Service must implement this interface.
/// </summary>
public interface INotificationEvent
{
    /// <summary>
    /// The tenant ID that owns this notification.
    /// </summary>
    Guid TenantId { get; }

    /// <summary>
    /// The target user ID (sub from JWT) who will receive the notification.
    /// </summary>
    Guid UserId { get; }

    /// <summary>
    /// The notification type identifier (e.g., "questionnaire.submitted", "menu.updated").
    /// Used to determine display preferences and categorization.
    /// </summary>
    string NotificationType { get; }

    /// <summary>
    /// Priority level of the notification.
    /// </summary>
    NotificationPriority Priority { get; }

    /// <summary>
    /// When the event occurred.
    /// </summary>
    DateTimeOffset OccurredAt { get; }
}
