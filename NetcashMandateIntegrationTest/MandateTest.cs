using NiwsMandateTest;
using System;
using System.Threading.Tasks;
using Xunit;

namespace NetcashMandateIntegrationTest
{
    public class MandateTest
    {
        [Fact]
        public async Task MandateShouldReturnMandateUrl()
        {
            // Arrange
            NIWS_NIFClient _client = new NIWS_NIFClient();
            var mobileNumber = "0792175449";
            var emailAddress = "ianj@agilebridge.co.za";

            // Act
            var actual = await _client.AddMandateAsync("6f4c7076-0bf5-4024-a322-4beb78f7c11f",
                        Guid.NewGuid().ToString(),
                        "Olga Parnell",
                        10000,
                        false,
                        "Franklin",
                        "Johnston",
                        "Smith Pty Ltd",
                        "nyamls85pq",
                        "Albertyn, Thompson and Oliphant",
                        mobileNumber,
                        MandateOptionsMandateDebitFrequency.Monthly,
                        8,
                        "30",
                        "20210830",
                        Guid.NewGuid().ToString(),
                        1,
                        MandateOptionsMandatePublicHolidayOption.VeryNextOrdinaryBusinessDay,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        true,
                        1,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        emailAddress,
                        mobileNumber,
                        null,
                        "15",
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        true,
                        null);

            // Assert
            actual.MandateUrl.StartsWith("https://short.surf/");
        }
    }
}
