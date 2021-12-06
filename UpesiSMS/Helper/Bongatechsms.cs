using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using UpesiSMS.ViewModels;

namespace UpesiSMS.Helper
{
  public  class Bongatechsms
    {
        public async static void  SendSMSBongaTech(string to,string message,string username)
        {
            var Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiZWRjMmM0MmIyNjA2ZTJjNGIxMTU3ZjE5NGU3ZjkxMjJlNjU0YmIyM2FjZTVjZjk5NjY4NDZkNTY0YzM1YTc4ODBlMWRlMGMwZjgzNmIzNDgiLCJpYXQiOjE2MDc1MDQ0MjgsIm5iZiI6MTYwNzUwNDQyOCwiZXhwIjoxNjM5MDQwNDI4LCJzdWIiOiIyNTMiLCJzY29wZXMiOltdfQ.A9nQBX9BMSQAM2FbMFMEfAgTQ87jfA97OonuLnYUJtCdmv4aoaf7mH8FaMBytJnrxy44Ex-bDYEcNmw_jSLCmsdMP2OVgfzq27ExhERfBFKC0mlyHsEdHgQbxMREkO5ZM9DXMFUhCxICCVvYPLB0lkdYLZD17H8dFDK48tSNr_xAiorOMAcPoQWE-zQVQQqRQIJhlCVUhel0czKR837Lrkezm4-UtH5PMkanDRYYqyrep1BGiTd3nEIavU4zYvAeVV89ijxX0lc9YXjAInQ5aRZorxiHmjiKGNwTT0MyghaPaWT-U5SC5wNyUFHMKxx1xTvycOFA0djkZ65UpnRigHdWYH3nbpHYGc1o_GLDp12_3jhEkb73L1hN1uINI5_97qPWcjWE6TcEYJlLR_dDmy_fSt88uAMuh6DhEBUuxEkS_OXf9VUTG-rnh8fvXUpCujMVfpAWUH23DMvUmV5um8XnkF7k7Epp2wuRXZrx6Y7KUktRdgMdLbvA9ZI1QGGv1GEwsZU-qcCrY0mQZLGK0MgfCrhzlk3KyPD_qpxRzjou4P9X2rm9lv8NupgHL9BBAUJlUwHwfWOx7liBmaavJclV6wpLSLtEA0OSWOX19Au8A4XDLWxSfpTR_x8g0D6bAiXPol4puyvDekL2S-6Kr0OVz-U2tcBHo0Th3pZdFVs";
            var baseUrl = "https://bulk.bongatech.co.ke/api/v1/send-sms";
            var newMessage = new SendSms();
            newMessage.Message = message;
            newMessage.Phone = to;
            newMessage.Sender = (username!=null?username: "Upesi_MTL");

            var SendThisMessage = JsonConvert.SerializeObject(newMessage);
            Console.WriteLine(SendThisMessage);

            var SendThisMessageendoded = new StringContent(SendThisMessage, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);

            var response = await client.PostAsync(baseUrl, SendThisMessageendoded);
        }
    }
}
