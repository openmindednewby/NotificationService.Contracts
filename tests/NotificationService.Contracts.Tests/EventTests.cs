using NotificationService.Contracts.Enums;
using NotificationService.Contracts.Events;

namespace NotificationService.Contracts.Tests;

/// <summary>
/// Unit tests for notification event contracts.
/// </summary>
public class EventTests
{
    [Fact]
    public void QuestionnaireSubmittedEvent_ShouldHaveCorrectNotificationType()
    {
        // Arrange & Act
        var evt = new QuestionnaireSubmittedEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            QuestionnaireId = Guid.NewGuid(),
            TemplateId = Guid.NewGuid(),
            TemplateName = "Test Template",
            RespondentName = "John Doe"
        };

        // Assert
        evt.NotificationType.Should().Be(NotificationTypes.QuestionnaireSubmitted);
        evt.Priority.Should().Be(NotificationPriority.Normal);
    }

    [Fact]
    public void QuestionnaireSubmittedEvent_ShouldSetOccurredAtToUtcNow()
    {
        // Arrange
        var before = DateTimeOffset.UtcNow;

        // Act
        var evt = new QuestionnaireSubmittedEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            QuestionnaireId = Guid.NewGuid(),
            TemplateId = Guid.NewGuid(),
            TemplateName = "Test Template",
            RespondentName = "John Doe"
        };

        var after = DateTimeOffset.UtcNow;

        // Assert
        evt.OccurredAt.Should().BeOnOrAfter(before);
        evt.OccurredAt.Should().BeOnOrBefore(after);
    }

    [Fact]
    public void TemplateUpdatedEvent_ShouldHaveCorrectNotificationType()
    {
        // Arrange & Act
        var evt = new TemplateUpdatedEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            TemplateId = Guid.NewGuid(),
            TemplateName = "Updated Template",
            UpdatedByUserName = "Jane Smith"
        };

        // Assert
        evt.NotificationType.Should().Be(NotificationTypes.TemplateUpdated);
        evt.Priority.Should().Be(NotificationPriority.Low);
    }

    [Fact]
    public void UserInvitedEvent_ShouldHaveCorrectNotificationTypeAndPriority()
    {
        // Arrange & Act
        var evt = new UserInvitedEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            TenantName = "Acme Corp",
            InvitedByUserName = "Admin User",
            Role = "Editor"
        };

        // Assert
        evt.NotificationType.Should().Be(NotificationTypes.UserInvited);
        evt.Priority.Should().Be(NotificationPriority.High);
    }

    [Fact]
    public void MenuUpdatedEvent_ShouldHaveCorrectNotificationType()
    {
        // Arrange & Act
        var evt = new MenuUpdatedEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            MenuId = Guid.NewGuid(),
            MenuName = "Lunch Menu",
            UpdatedByUserName = "Chef"
        };

        // Assert
        evt.NotificationType.Should().Be(NotificationTypes.MenuUpdated);
        evt.Priority.Should().Be(NotificationPriority.Low);
    }

    [Fact]
    public void SubscriptionExpiringEvent_ShouldHaveCorrectNotificationTypeAndPriority()
    {
        // Arrange & Act
        var evt = new SubscriptionExpiringEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            PlanName = "Professional",
            ExpiresAt = DateTimeOffset.UtcNow.AddDays(7),
            DaysUntilExpiry = 7
        };

        // Assert
        evt.NotificationType.Should().Be(NotificationTypes.SubscriptionExpiring);
        evt.Priority.Should().Be(NotificationPriority.High);
    }

    [Fact]
    public void PaymentDueEvent_ShouldHaveCorrectNotificationTypeAndUrgentPriority()
    {
        // Arrange & Act
        var evt = new PaymentDueEvent
        {
            TenantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            Amount = 99.99m,
            Currency = "USD",
            DueDate = DateTimeOffset.UtcNow.AddDays(3)
        };

        // Assert
        evt.NotificationType.Should().Be(NotificationTypes.PaymentDue);
        evt.Priority.Should().Be(NotificationPriority.Urgent);
    }

    [Fact]
    public void AllEvents_ShouldImplementINotificationEvent()
    {
        // Arrange
        var tenantId = Guid.NewGuid();
        var userId = Guid.NewGuid();

        // Act
        INotificationEvent[] events =
        [
            new QuestionnaireSubmittedEvent
            {
                TenantId = tenantId,
                UserId = userId,
                QuestionnaireId = Guid.NewGuid(),
                TemplateId = Guid.NewGuid(),
                TemplateName = "Test",
                RespondentName = "Test"
            },
            new TemplateUpdatedEvent
            {
                TenantId = tenantId,
                UserId = userId,
                TemplateId = Guid.NewGuid(),
                TemplateName = "Test",
                UpdatedByUserName = "Test"
            },
            new UserInvitedEvent
            {
                TenantId = tenantId,
                UserId = userId,
                TenantName = "Test",
                InvitedByUserName = "Test",
                Role = "User"
            },
            new MenuUpdatedEvent
            {
                TenantId = tenantId,
                UserId = userId,
                MenuId = Guid.NewGuid(),
                MenuName = "Test",
                UpdatedByUserName = "Test"
            },
            new SubscriptionExpiringEvent
            {
                TenantId = tenantId,
                UserId = userId,
                PlanName = "Test",
                ExpiresAt = DateTimeOffset.UtcNow.AddDays(7),
                DaysUntilExpiry = 7
            },
            new PaymentDueEvent
            {
                TenantId = tenantId,
                UserId = userId,
                Amount = 100m,
                Currency = "USD",
                DueDate = DateTimeOffset.UtcNow.AddDays(3)
            }
        ];

        // Assert
        foreach (var evt in events)
        {
            evt.TenantId.Should().Be(tenantId);
            evt.UserId.Should().Be(userId);
            evt.NotificationType.Should().NotBeNullOrEmpty();
            evt.OccurredAt.Should().BeCloseTo(DateTimeOffset.UtcNow, TimeSpan.FromSeconds(1));
        }
    }
}
