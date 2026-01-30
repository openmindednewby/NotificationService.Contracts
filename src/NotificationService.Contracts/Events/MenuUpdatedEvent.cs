using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a menu is updated.
/// Target: Menu owner/editors.
/// </summary>
public sealed record MenuUpdatedEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The ID of the updated menu.
    /// </summary>
    public required Guid MenuId { get; init; }

    /// <summary>
    /// The name of the updated menu.
    /// </summary>
    public required string MenuName { get; init; }

    /// <summary>
    /// The name of the user who made the update.
    /// </summary>
    public required string UpdatedByUserName { get; init; }

    /// <summary>
    /// The type of change (e.g., "item_added", "item_removed", "price_changed").
    /// </summary>
    public string? ChangeType { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.MenuUpdated;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.Low;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
