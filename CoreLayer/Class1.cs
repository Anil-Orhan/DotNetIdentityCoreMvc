using System;

namespace CoreLayer
{
    public class MyExceptionHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            // hatayı loglama
            // kullanıcıya hata bilgisi gösterme
            // v.s...
        }
    }
}
