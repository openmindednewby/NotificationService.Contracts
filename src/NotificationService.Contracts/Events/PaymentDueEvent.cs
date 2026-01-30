using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a payment is due.
/// Target: Tenant admin/billing contact.
/// </summary>
public sealed record PaymentDueEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The amount due.
    /// </summary>
    public required decimal Amount { get; init; }

    /// <summary>
    /// The currency code (e.g., "USD", "EUR").
    /// </summary>
    public required string Currency { get; init; }

    /// <summary>
    /// When the payment is due.
    /// </summary>
    public required DateTimeOffset DueDate { get; init; }

    /// <summary>
    /// The invoice ID (optional).
    /// </summary>
    public string? InvoiceId { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.PaymentDue;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.Urgent;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
