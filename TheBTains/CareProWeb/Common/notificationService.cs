using System.Net;
using System.Text;
using System.Text.Json;

namespace CareProWeb.Common
{
    public class PushNotification
    {
        public PushNotification(string body, string title)
        {
            try
            {
                var applicationID = "AAAAWvucB5g:APA91bFbonytYjnqRs_BTULmAu54YOSvXdeY2K4QggCngAc4N34Sa_4_-ENuJfKnaiCD7K33iATfsVmGP6KyZW2Hm3YbsP6QHy8I9344pw75Wzgn6LHn_oCYhxPMmt-Q3zESlwOOMEgM";
                var senderId = "390768363416";
                WebRequest tRequest = WebRequest.Create("https://fcm.googleapis.com/fcm/send");
                tRequest.Method = "post";
                tRequest.ContentType = "application/json";
                var data = new
                {
                    //to = "cihgunR-rEVWKoLiicGk7a:APA91bGyiPOFzu1I0_X_p5CzWefThccMbr7-v1XnY3rCmo-8wnhKlg_puV2oXcx8WHvwvn8yh9_ZrD8quoOugd1gVZ6BMuNX5UlKEavfrmj5ukdNFI3HP-6vTgCTFdA7ElJGfTKtyQcz",
                    to = "cV3-IBcMQyQdf--7xs2EpK:APA91bFwabmDHoYMiS0-0hNzhqhMoayOFyNDFew-XENKIDprA3dV-iDR-ulTihgYM1EjYGywyoqurF0F2AIhHN0CjUzq80SOh3z3ofG_EFH6MV6EjixHVRA_pybHH3pKGq_ZrZPIgewj",
                    notification = new
                    {
                        body = body,
                        title = title,
                        subtitle = "mar ja"
                    }
                };
                var json = JsonSerializer.Serialize(data);
                Byte[] byteArray = Encoding.UTF8.GetBytes(json);
                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));
                tRequest.Headers.Add(string.Format("Sender: id={0}", senderId));
                tRequest.ContentLength = byteArray.Length;
                using (Stream dataStream = tRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    using (WebResponse tResponse = tRequest.GetResponse())
                    {
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            using (StreamReader tReader = new StreamReader(dataStreamResponse))
                            {
                                String sResponseFromServer = tReader.ReadToEnd();
                                string str = sResponseFromServer;
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                //string str = ex.Message;
                Console.WriteLine(ex.Message);
            }
        }
    }
}
