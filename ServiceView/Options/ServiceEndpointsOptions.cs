namespace ServiceView.Options;

public sealed class ServiceEndpointsOptions
{
    public string FitnessService { get; set; } = "http://127.0.0.1:7000";
    public string EventService { get; set; } = "http://127.0.0.1:7010";
    public string CarSharingService { get; set; } = "http://127.0.0.1:7020";
}

