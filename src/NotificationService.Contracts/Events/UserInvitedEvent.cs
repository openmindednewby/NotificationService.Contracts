using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a user is invited to a tenant.
/// Target: The invited user (after they accept/register).
/// </summary>
public sealed record UserInvitedEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The name of the tenant the user was invited to.
    /// </summary>
    public required string TenantName { get; init; }

    /// <summary>
    /// The name of the user who sent the invitation.
    /// </summary>
    public required string InvitedByUserName { get; init; }

    /// <summary>
    /// The role assigned to the invited user.
    /// </summary>
    public required string Role { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.UserInvited;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.High;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
