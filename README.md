# a-fortnox-client
This is a client library for the Fortnox Api (<a href="https://developer.fortnox.se/">developer.fortnox.se</a>). This library can be used to connect to the Fortnox Api and to call api methods in the Fortnox Api. 

If you want to test the client with the test program, create a folder on your computer to store appsettings and log files. Add a copy of the appsettings.template.json file to 
the folder and rename it to appsettings.json. Set values for ClientId, ClientSecret and AuthorizationCode in the appsettings.json file, do not set a value for AccessToken if you don´t have 
an AccessToken already. Set the path to the directory/folder in the Config class.

This library is available as a NuGet package: <a href="https://www.nuget.org/packages/Annytab.Fortnox.Client/">a-fortnox-client (NuGet Gallery)</a>

You can add the FortnoxAuthorizationClient and the FortnoxClient to IHttpClientFactory in ASP.NET Core 2.1 or later version. See the TestProgram for examples on how to use the client.

```
// Create api options
services.Configure<FortnoxOptions>(this.settings.GetSection("FortnoxOptions"));

// Add repositories
services.AddHttpClient<IFortnoxAuthorizationClient, FortnoxAuthorizationClient>().ConfigurePrimaryHttpMessageHandler(() =>
                new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
services.AddHttpClient<IFortnoxClient, FortnoxClient>().ConfigurePrimaryHttpMessageHandler(() =>
                new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
```

You can also create a client with the constructor by adding a HttpClient and FortnoxOptions.

```
// Create api options
IOptions<FortnoxOptions> options = Options.Create<FortnoxOptions>(new FortnoxOptions
{
	ClientSecret = "1fBN6P7jRA",
	AccessToken = "asdfasdfasdfasdfasdf"
});

// Create a fortnox client
IFortnoxClient fortnox_client = new FortnoxClient(this.client_factory.CreateClient(), options);
```

Documentation (English): <a href="https://developer.fortnox.se/documentation/">Fortnox documentation</a>

[![paypal](buy-me-a-coffe.png)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GMEFTXSE77FWE)