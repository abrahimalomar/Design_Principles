using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Basic
{
    class Repository
    {
      public static  List<customer> list = new List<customer>
            {
               new customer
               {
                   Id=1,
                   Name="Ibrahim",
                   EmailAddress="Ibrahim@gmail.com",
                   MobileNo="+963 993 817 930",
                   Address="Azaz",
               },
               new customer
               {
                   Id=2,
                   Name="ali",
                   EmailAddress="Ali@gmail.com",
                   MobileNo="+963 999 888 777",
                   Address="Idlib",
               },
               new customer
               {
                   Id=3,
                   Name="Khled",
                   EmailAddress="Khled@gmail.com",
                   MobileNo="+963 444 555 666",
                   Address="Azaz",
               },
               new customer
               {
                   Id=3,
                   Name="Omar",
                   EmailAddress="Omar@gmail.com",
                   MobileNo="+963 777 666 555",
                   Address="Idlib",
               }

            };
    }
}
