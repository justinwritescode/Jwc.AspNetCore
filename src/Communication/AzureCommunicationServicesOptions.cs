namespace JustinWritesCode.AspNetCore.Communication;

[RegexDto("^endpoint=(?<Endpoint:uri>https://.*);accessKey=(?<AccessKey:string>.*)$")]
public partial record class AzureCommunicationServicesOptionsBase
{
    public AzureCommunicationServicesOptionsBase(uri endpoint, string accessKey)
    {
        Endpoint = endpoint;
        AccessKey = accessKey;
    }

    public virtual string ConnectionString
    {
        get => $"endpoint={Endpoint};accessKey={AccessKey}";
        set
        {
            var other = new AzureCommunicationServicesOptionsBase(value);
            Endpoint = other.Endpoint;
            AccessKey = other.AccessKey;
        }
    }
}


public abstract partial record class AzureCommunicationServicesOptions<TAddressType> : AzureCommunicationServicesOptionsBase
{
    public AzureCommunicationServicesOptions(string connectionString) : base(connectionString) { }

    public AzureCommunicationServicesOptions(uri endpoint, string accessKey) : base(endpoint, accessKey) { }

    public AzureCommunicationServicesOptions() : this(string.Empty) { }

    public abstract TAddressType DefaultFrom { get; set; }

    private TAddressType? _massDistributionFrom;
    public virtual TAddressType MassDistributionFrom { get => _massDistributionFrom ?? DefaultFrom; set => _massDistributionFrom ??= value; }
    private TAddressType? _adminFrom;
    public virtual TAddressType AdminFrom { get => _adminFrom ?? DefaultFrom; set => _adminFrom ??= value; }
    private TAddressType? _securityFrom;
    public virtual TAddressType SecurityFrom { get => _securityFrom ?? DefaultFrom; set => _securityFrom ??= value; }
}
