using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a template is updated.
/// Target: Users who have access to the template.
/// </summary>
public sealed record TemplateUpdatedEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The ID of the updated template.
    /// </summary>
    public required Guid TemplateId { get; init; }

    /// <summary>
    /// The name of the updated template.
    /// </summary>
    public required string TemplateName { get; init; }

    /// <summary>
    /// The name of the user who made the update.
    /// </summary>
    public required string UpdatedByUserName { get; init; }

    /// <summary>
    /// A description of what changed (optional).
    /// </summary>
    public string? ChangeDescription { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.TemplateUpdated;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.Low;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
