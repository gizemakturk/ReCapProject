using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
   public class Result : IResult
    {//Getter reaad only constructurda set edilebilir
        //this classın kendini kast edeer result yani
        

       public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
