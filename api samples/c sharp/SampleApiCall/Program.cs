// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// fields[0] => alarm hour
// fields[1] => alarm minute
// fields[2] => start before
List<int> fields = await SampleApiCall.ApiRead.GetFields();
fields.ForEach(x => Console.WriteLine(x));

// update fields
await SampleApiCall.ApiWrite.SaveFields(10, 11, 12);