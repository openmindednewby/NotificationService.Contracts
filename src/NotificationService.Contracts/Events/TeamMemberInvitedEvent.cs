using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a team member invitation is created.
/// Target: The inviting user (confirmation) and the notification system (to send invitation email).
/// </summary>
public sealed record TeamMemberInvitedEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The email address of the invited person.
    /// </summary>
    public required string InvitationEmail { get; init; }

    /// <summary>
    /// The role assigned to the invited person.
    /// </summary>
    public required string Role { get; init; }

    /// <summary>
    /// The name of the tenant the person is being invited to.
    /// </summary>
    public required string TenantName { get; init; }

    /// <summary>
    /// The secure token for accepting the invitation.
    /// </summary>
    public required string InvitationToken { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.TeamMemberInvited;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.High;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
