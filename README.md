# NotificationService.Contracts

Event contracts for NotificationService integration. All services reference this package to publish notification events.

## Installation

```bash
dotnet add package NotificationService.Contracts
```

## Usage

Reference this package in any service that needs to publish notification events:

```csharp
using NotificationService.Contracts.Events;
using NotificationService.Contracts.Enums;

// Create a notification event
var evt = new QuestionnaireSubmittedEvent
{
    TenantId = tenantId,
    UserId = templateOwnerId,
    QuestionnaireId = questionnaireId,
    TemplateId = templateId,
    TemplateName = "Customer Feedback",
    RespondentName = "John Doe"
};
```

## Events

| Event | Description | Priority |
|-------|-------------|----------|
| `QuestionnaireSubmittedEvent` | Published when a questionnaire response is submitted | Normal |
| `TemplateUpdatedEvent` | Published when a template is updated | Low |
| `UserInvitedEvent` | Published when a user is invited to a tenant | High |
| `MenuUpdatedEvent` | Published when a menu is updated | Low |
| `SubscriptionExpiringEvent` | Published when a subscription is about to expire | High |
| `PaymentDueEvent` | Published when a payment is due | Urgent |

## Notification Types

Use the `NotificationTypes` class for well-known notification type identifiers:

```csharp
// Available notification types
NotificationTypes.QuestionnaireSubmitted  // "questionnaire.submitted"
NotificationTypes.TemplateUpdated         // "template.updated"
NotificationTypes.TemplateDeleted         // "template.deleted"
NotificationTypes.UserInvited             // "user.invited"
NotificationTypes.UserRemoved             // "user.removed"
NotificationTypes.MenuUpdated             // "menu.updated"
NotificationTypes.MenuItemAdded           // "menu.item.added"
NotificationTypes.SubscriptionExpiring    // "subscription.expiring"
NotificationTypes.PaymentDue              // "payment.due"
NotificationTypes.PaymentFailed           // "payment.failed"
NotificationTypes.SystemAnnouncement      // "system.announcement"
```

## License

MIT
