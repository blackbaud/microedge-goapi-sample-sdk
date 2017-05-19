using System;
using System.Threading.Tasks;
using MicroEdge.GoApi.SDK.Organizations;
using MicroEdge.GoApi.SDK.Organizations.Models;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var key = "INSERT KEY HERE";
            var secret = "INSERT SECRET HERE";
            var client = new OrganizationClient(key, secret);

            var getOrganizationRequest = new GetOrganizationRequest()
            {
                Id = "ID OF ORGANIZATION"
            };

            var organization = Task.Run(async () => await client.GetOrganization(getOrganizationRequest)).GetAwaiter().GetResult();
            Console.WriteLine(organization.Organization.Name);
        }
    }
}
