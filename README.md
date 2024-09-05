# DevPortal-AI-Kit

Build apps with QED APIs using AI.

DevPortal AI Kit combines

- Microsoft Semantic Kernel for parsing and managing your LLM queries
- DevPortal Semantic Kernel Plugin for accessing QED API metadata
- Ollama for managing a locally running LLM model
- llama3.1 model

To get started:

First clone this repo with

```console
git clone https://github.com/qed-developerportal/devportal-ai-kit.git
cd devportal-ai-kit
```

Open this repo in VS Code with

```console
code .
```

Install Ollama (see <https://github.com/ollama/ollama?tab=readme-ov-file> for different ways to do this).

Open a new terminal window.

Type the following to download and run the llama3.1:latest model

```console
ollama run llama3.1
```

Go back to the VS Code window, open a terminal and type

```console
dotnet run
```

A "User:" prompt will show.

Type a query such as "What API Groups are supported?" and press enter.

If everything is configured correctly a response will be generated.

# Example Questions

Here are a sample set of questions you can now ask the Semantic Kernel to process along with example answers it has previously provided.

```console
What API Categories are supported?
```

The API Categories supported are:

1. Consent Management
2. Attendance/Roll Marking
3. Booking Systems
4. DoE Test Clients
5. Library Management Systems (online)
6. SMS/Text Messaging Providers
7. Student Management
8. Student Management Publisher

```console
List the HTTP GET Methods for Booking Systems
```

The HTTP GET Methods for Booking Systems are:

1. `/schools/{zoneId}/parentpersonals` (Parents)
2. `/schools/{zoneId}/staffpersonals` (Staff)
3. `/schools/{zoneId}/studentpersonals` (Students)
4. `/schools/{zoneId}/teachinggroups` (Classes)

```console
What is returned by a call to the parentpersonals GET method of Booking Systems
```

The response from the `parentpersonals` GET method of Booking Systems is:

```
{
  "Id": "string",
  "ParentName": "string",
  "ParentEmail": "string",
  "ParentPhone": "string",
  "ParentAddress": {
    "Street": "string",
    "City": "string",
    "State": "string",
    "Postcode": "string"
  },
  "ParentContactPreferences": [
    {
      "PreferenceType": "string",
      "PreferenceValue": "string"
    }
  ]
}
```

This response contains information about a parent, including their name, email address, phone number, and contact preferences. The `ParentAddress` field is an object containing the parent's street address, city, state, and postcode. The `ParentContactPreferences` field is an array of objects, each representing a preference type (e.g., "email", "phone") and its corresponding value.

```console
Provide an example response for the same call
```

Here is an example response for the `parentpersonals` GET method of Booking Systems:

```
{
  "Id": "PARENT-1234",
  "ParentName": "John Doe",
  "ParentEmail": "john.doe@example.com",
  "ParentPhone": "+6123456789",
  "ParentAddress": {
    "Street": "123 Main St",
    "City": "Sydney",
    "State": "NSW",
    "Postcode": "2000"
  },
  "ParentContactPreferences": [
    {
      "PreferenceType": "email",
      "PreferenceValue": "john.doe@example.com"
    },
    {
      "PreferenceType": "phone",
      "PreferenceValue": "+6123456789"
    }
  ]
}
```

This response contains information about a parent, including their name, email address, phone number, and contact preferences. The `ParentAddress` field is an object containing the parent's street address, city, state, and postcode. The `ParentContactPreferences` field is an array of objects, each representing a preference type (e.g., "email", "phone") and its corresponding value.

```console
Provide a C# example of calling the same method
```

```csharp
using System;
using System.Net.Http;
using System.Text.Json;

public class ParentPersonal
{
    public string Id { get; set; }
    public string ParentName { get; set; }
    public string ParentEmail { get; set; }
    public string ParentPhone { get; set; }
    public Address ParentAddress { get; set; }
    public Preference[] ParentContactPreferences { get; set; }
}

public class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Postcode { get; set; }
}

public class Preference
{
    public string PreferenceType { get; set; }
    public string PreferenceValue { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://example.com/parent-api/schools/{zoneId}/parentpersonals");

        if (response.IsSuccessStatusCode)
        {
            var parentPersonalResponse = await JsonSerializer.DeserializeAsync<ParentPersonal>(await response.Content.ReadAsStreamAsync());
            Console.WriteLine($"Id: {parentPersonalResponse.Id}");
            Console.WriteLine($"Name: {parentPersonalResponse.ParentName}");
            Console.WriteLine($"Email: {parentPersonalResponse.ParentEmail}");
            Console.WriteLine($"Phone: {parentPersonalResponse.ParentPhone}");
            Console.WriteLine($"Address:");
            Console.WriteLine($"  Street: {parentPersonalResponse.ParentAddress.Street}");
            Console.WriteLine($"  City: {parentPersonalResponse.ParentAddress.City}");
            Console.WriteLine($"  State: {parentPersonalResponse.ParentAddress.State}");
            Console.WriteLine($"  Postcode: {parentPersonalResponse.ParentAddress.Postcode}");

            foreach (var preference in parentPersonalResponse.ParentContactPreferences)
            {
                Console.WriteLine($"Preference Type: {preference.PreferenceType}, Preference Value: {preference.PreferenceValue}");
            }
        }
    }
}
```

This C# example uses the `System.Net.Http` namespace to make a GET request to the specified URL, and then deserializes the response into a `ParentPersonal` object. It then prints out the values of each property in the object.

Note: You will need to replace `"https://example.com/parent-api/schools/{zoneId}/parentpersonals"` with the actual URL for your API endpoint.