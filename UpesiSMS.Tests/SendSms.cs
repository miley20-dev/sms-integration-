using System;
using System.Threading.Tasks;
using UpesiSMS.Helper;
using Xunit;

namespace UpesiSMS.Tests
{
    public class SendSms
    {
        [Theory]
        [InlineData("071691166","testing","Upesi_MTL")]
        public async Task SendBongaTechSms( string to,string message,string username)
        {
             Bongatechsms.SendSMSBongaTech(to,message,username);


        }
    }
}
