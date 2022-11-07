using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Devpack.Notifications.Notifier
{
    public interface INotifier
    {
        bool HasNotifications { get; }
        IReadOnlyCollection<Notification> GetNotifications();
        Task Notify(string message, HttpStatusCode notificationType = HttpStatusCode.UnprocessableEntity);
        Task Notify(string errorCode, string message, HttpStatusCode notificationType = HttpStatusCode.UnprocessableEntity);
        Task Notify(string errorCode, string field, string message, HttpStatusCode notificationType = HttpStatusCode.UnprocessableEntity);
        Task Notify(ValidationResult validationResult, HttpStatusCode notificationType = HttpStatusCode.UnprocessableEntity);
        JsonResult GetAsJsonResult();
    }
}