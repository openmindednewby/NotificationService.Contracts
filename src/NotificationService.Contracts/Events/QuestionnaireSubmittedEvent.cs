using NotificationService.Contracts.Enums;

namespace NotificationService.Contracts.Events;

/// <summary>
/// Published when a questionnaire response is submitted.
/// Target: Template owner.
/// </summary>
public sealed record QuestionnaireSubmittedEvent : INotificationEvent
{
    /// <inheritdoc />
    public required Guid TenantId { get; init; }

    /// <inheritdoc />
    public required Guid UserId { get; init; }

    /// <summary>
    /// The ID of the submitted questionnaire response.
    /// </summary>
    public required Guid QuestionnaireId { get; init; }

    /// <summary>
    /// The ID of the template that was filled out.
    /// </summary>
    public required Guid TemplateId { get; init; }

    /// <summary>
    /// The name of the template that was filled out.
    /// </summary>
    public required string TemplateName { get; init; }

    /// <summary>
    /// The name of the person who submitted the response.
    /// </summary>
    public required string RespondentName { get; init; }

    /// <summary>
    /// The email of the person who submitted the response (optional).
    /// </summary>
    public string? RespondentEmail { get; init; }

    /// <inheritdoc />
    public string NotificationType => NotificationTypes.QuestionnaireSubmitted;

    /// <inheritdoc />
    public NotificationPriority Priority => NotificationPriority.Normal;

    /// <inheritdoc />
    public DateTimeOffset OccurredAt { get; init; } = DateTimeOffset.UtcNow;
}
