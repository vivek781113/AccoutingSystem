using AccountingSystem.Models;

namespace AccountingSystem.utils.EmailHelper
{
    public interface IEmailHelper
    {
        bool SendEmail(MailContent content);
    }
}
