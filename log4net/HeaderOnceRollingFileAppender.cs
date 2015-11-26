using log4net.Appender;
...

namespace MyCustomClassNamespace
{
    public class HeaderOnceRollingFileAppender : RollingFileAppender
    {
        protected override void WriteHeader()
        {
            if (LockingModel.AcquireLock().Length == 0)
            {
                base.WriteHeader();
            }
        }
    }
}
