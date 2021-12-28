using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gramboo.Database;
using RestSharp;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Vonage;
using Vonage.Request;
using Vonage.Voice;
using Vonage.Voice.Nccos;
using Vonage.Voice.Nccos.Endpoints;

namespace project.Forms.ADD
{
    public partial class PaymentandMessage : Gramboo.Controls.GrbForm
    {
        private const string V = "https://api.razorpay.com/v1/payment_links";
        private const string X = "https://messages-sandbox.nexmo.com/v0.1/messages";
        private static PaymentandMessage instance;


        public static PaymentandMessage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentandMessage();
                }
                else if (instance.IsDisposed)
                {
                    instance = new PaymentandMessage();
                }
                return instance;
            }
        }
        public PaymentandMessage()
        {
            InitializeComponent();
        }

        private void grbButton1_Click(object sender, EventArgs e)
        {
            /*
                        var accountSid = "AC8645774dfff78c11b29946889a2f493f";
                        var authToken = "6cce9a3fd22d269905853e43c74bbdac";
                        TwilioClient.Init(accountSid, authToken);

                        //   var messageOptions = new CreateMessageOptions(
                        //   new Twilio.Types.PhoneNumber("+918921318769"));
                        //messageOptions.MessagingServiceSid = "MG42c7947b37ebd4bc0efb7f3a35bc9a03";
                        //messageOptions.Body = "this is from library software thanku for joining our group";

                        //var message = MessageResource.Create(messageOptions);
                        //Console.WriteLine(message.Body);
                        var to = new Twilio.Types.PhoneNumber(""+grbTextPhone.Text +"");
                        var from = new Twilio.Types.PhoneNumber("+12095536026");
                        var call = CallResource.Create(to, from,
                            url: new Uri("http://demo.twilio.com/docs/voice.xml"));


                        Console.WriteLine(call.Sid);*/
            //other API

            var creds = Credentials.FromAppIdAndPrivateKeyPath("2ff6e764-74f2-40ab-af8d-2c2a369cef50", "E:\\myworkshop\\lib\\k\\volga\\private.key");
            var client = new VonageClient(creds);

            var toEndpoint = new PhoneEndpoint() { Number = ""+grbTextPhone.Text+"" };
            var fromEndpoint = new PhoneEndpoint() { Number = ""+grbTextPhone.Text+"" };
            var extraText = "";   
            for (var i = 0; i < 2; i++)
                extraText += $"{i} ";
            var talkAction = new TalkAction() { Text = "" + richTextMessbody.Text + "" + extraText };
            var ncco = new Ncco(talkAction);

            string[] EVENT_URL = null;
            var command = new CallCommand() { To = new Endpoint[] { toEndpoint }, From = fromEndpoint, Ncco = ncco, EventUrl = EVENT_URL };
            var response = client.VoiceClient.CreateCall(command);
        }

        private void grbButton2_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(V)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic cnpwX3Rlc3RfWjFVRlZWZDBPczlIUUQ6SHltazV2QUJDeDZPbG1YR3paNExma01Y");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\n  \"amount\":"+txt_amount.Text+"00," +
                "\n  \"currency\": \"INR\"," +
                "\n  \"accept_partial\": true," +
                "\n  \"first_min_partial_amount\": 100," +
                "\n  \"expire_by\": 1691097057," +
                "\n  \"reference_id\": \""+grbTextEmail.Text+"\"," +
                "\n  \"description\": \"Payment for policy no #23456\"," +
                "\n  \"customer\": {\n    \"name\": \""+grbTextName.Text+"\"," +
                "\n    \"contact\": \""+ grbTextPhone.Text+ "\",\n    " +
                "\"email\": \""+grbTextName.Text +"@example.com\"\n  }," +
                "\n  \"notify\": {\n    \"sms\": true,\n    \"email\": true\n  }," +
                "\n  \"reminder_enable\": true,\n  \"notes\": {\n    \"policy_name\": \"jerin joy\"\n  }," +
                "\n  \"callback_url\": \"https://example-callback-url.com/\"," +
                "\n  \"callback_method\": \"get\"\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void grbButton3_Click(object sender, EventArgs e)
        {
            //vonage
            /* var credentials = Credentials.FromApiKeyAndSecret(
                                                     "77d9be29",
                                             "NIGzSPOP2drc4iKg"
                                                             );

             var VonageClient = new VonageClient(credentials);
             var response = VonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest()
             {
                 To = ""+grbTextPhone.Text+"",
                 From = "Vonage APIs",
                 Text = "A text message sent using the library managment app"
             });*/
            var accountSid = "AC8645774dfff78c11b29946889a2f493f";
            var authToken = "6cce9a3fd22d269905853e43c74bbdac";
            TwilioClient.Init(accountSid, authToken);

             var messageOptions = new CreateMessageOptions(
            new Twilio.Types.PhoneNumber(""+grbTextPhone.Text+""));
            messageOptions.MessagingServiceSid = "MG42c7947b37ebd4bc0efb7f3a35bc9a03";
            messageOptions.Body = ""+richTextMessbody.Text+"";

            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }

        private void grbButton4_Click(object sender, EventArgs e)
        {
            var client = new RestSharp.RestClient(V)
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "77d9be29:NIGzSPOP2drc4iKg");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("text/plain", 
                " curl -X POST https://messages-sandbox.nexmo.com/v0.1/messages \\\r" +
                "\n-u '77d9be29:NIGzSPOP2drc4iKg' \\\r\n-H 'Content-Type: application/json' " +
                "\\\r\n-H 'Accept: application/json' \\\r\n-d '{\r\n    \"from\": { \"type\": \"whatsapp\", \"number\": \"14157386170\" }," +
                "\r\n    \"to\": { \"type\": \"whatsapp\", \"number\": \"+918921318769\" },\r\n  " +
                "  \"message\": {\r\n      \"content\": {\r\n    " +
                "    \"type\": \"text\",\r\n        \"text\": \"This is a WhatsApp Message sent from the Messages API\"\r\n    " +
                "  }\r\n    }\r\n  }'", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
