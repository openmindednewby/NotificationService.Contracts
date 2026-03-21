using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a team member accepts an invitation.
/// Target: The user who sent the invitation (notification that their invite was accepted).
/// </summary>
public sealed record TeamMemberAcceptedEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The user ID of the person who accepted the invitation.
    /// </summary>
    public required Guid AcceptedByUserId { get; init; }

    /// <summary>
    /// The email of the person who accepted the invitation.
    /// </summary>
    public required string AcceptedByEmail { get; init; }

    /// <summary>
    /// The role assigned to the accepted member.
    /// </summary>
    public required string Role { get; init; }

    /// <summary>
    /// The name of the tenant.
    /// </summary>
    public required string TenantName { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.TeamMemberAccepted;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.Medium;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
