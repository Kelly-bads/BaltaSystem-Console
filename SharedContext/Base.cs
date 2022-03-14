using Kyba.NotificationContext;

namespace Kyba.ContentContext
{
    public class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        } 
        public Guid Id { get; set; }  
    }
}