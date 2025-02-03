

namespace Core.CrossCuttingConcerns.Exceptions
{
	public class NotFoundException:Exception
	{
        public NotFoundException(string message):base(message) { }
        public NotFoundException() : base() { }
        
         public NotFoundException(string msg, Exception? innerException):base(msg,innerException) { }        
        

    }
}
