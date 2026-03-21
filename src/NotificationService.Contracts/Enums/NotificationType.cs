namespace NotificationService.Contracts.Enums;

/// <summary>
/// Well-known notification types. Services should use these constants
/// to ensure consistent notification type identifiers.
/// </summary>
public static class NotificationTypes
{
    /// <summary>
    /// A questionnaire response has been submitted.
    /// </summary>
    public const string QuestionnaireSubmitted = "questionnaire.submitted";

    /// <summary>
    /// A template has been updated.
    /// </summary>
    public const string TemplateUpdated = "template.updated";

    /// <summary>
    /// A template has been deleted.
    /// </summary>
    public const string TemplateDeleted = "template.deleted";

    /// <summary>
    /// A user has been invited to a tenant.
    /// </summary>
    public const string UserInvited = "user.invited";

    /// <summary>
    /// A user has been removed from a tenant.
    /// </summary>
    public const string UserRemoved = "user.removed";

    /// <summary>
    /// A menu has been updated.
    /// </summary>
    public const string MenuUpdated = "menu.updated";

    /// <summary>
    /// A menu item has been added.
    /// </summary>
    public const string MenuItemAdded = "menu.item.added";

    /// <summary>
    /// A subscription is about to expire.
    /// </summary>
    public const string SubscriptionExpiring = "subscription.expiring";

    /// <summary>
    /// A payment is due.
    /// </summary>
    public const string PaymentDue = "payment.due";

    /// <summary>
    /// A payment has failed.
    /// </summary>
    public const string PaymentFailed = "payment.failed";

    /// <summary>
    /// A system-wide announcement.
    /// </summary>
    public const string SystemAnnouncement = "system.announcement";

    /// <summary>
    /// A team member has been invited.
    /// </summary>
    public const string TeamMemberInvited = "team.member.invited";

    /// <summary>
    /// A team member has accepted an invitation.
    /// </summary>
    public const string TeamMemberAccepted = "team.member.accepted";
}
