using eva01_radar.ApiRequest;

// api test
IRequest request = new Request();
string response = request.Get();

// print response
Console.WriteLine(response);