using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a subscription is about to expire.
/// Target: Tenant admin.
/// </summary>
public sealed record SubscriptionExpiringEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The name of the subscription plan.
    /// </summary>
    public required string PlanName { get; init; }

    /// <summary>
    /// When the subscription expires.
    /// </summary>
    public required DateTimeOffset ExpiresAt { get; init; }

    /// <summary>
    /// Number of days until the subscription expires.
    /// </summary>
    public required int DaysUntilExpiry { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.SubscriptionExpiring;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.High;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
