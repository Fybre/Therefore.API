// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Therefore.API.Constants;
using Therefore.API.Http.Requests;
using Therefore.API.Services;

Console.WriteLine("Starting");

using (HttpClient client = new HttpClient())
{
    ThereforeService service = new ThereforeService(client, "https://craigdemo.thereforeonline.com", "craigdemo", AuthType.Basic, "The#1234", "craig.mewett");

    GetWorkflowProcessRequest req = new GetWorkflowProcessRequest() { ProcessNo = 43 };
    var r = await service.GetWorkflowProcess(req);
    Console.WriteLine(r.ErrorMessage);

    //var wfInstance = await service.GetWorkflowInstance(new Therefore.API.Http.Requests.GetWorkflowInstanceRequest() { InstanceNo = 2501, TokenNo=0 });
    //Console.WriteLine(wfInstance.ErrorMessage);
}