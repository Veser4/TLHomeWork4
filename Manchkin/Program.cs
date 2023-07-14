
using DataBaseProvider.Repositories;
using DataBaseProvider.Repositories.Abstractions;
using DataBaseProvider.Repositories.Implementations;
using DataBaseProvider;
using DataBaseProvider.Configurations;

public class Program
{
    private const string connectionString =
            "Data Source=MILKYWAY\\SQLEXPRESS;Initial Catalog=HospitalDb;Pooling=true;Integrated Security=SSPI";
    private static ApplicationContext _applicationContext;
    private static IClassRepository _classRepository;
    private static IRaceRepository _raceRepository;
    private static IFeatureRepository _featureRepository;
    private static IHeroRepository _heroRepository;
    private static IThingRepository _thingRepository;
    public static void Main(string[] args)
    {
        _applicationContext = new ApplicationContext(connectionString);
        _classRepository = new ClassRepository(_applicationContext);
        _raceRepository = new RaceRepository(_applicationContext);
        _featureRepository = new FeatureRepository(_applicationContext);
        _heroRepository = new HeroRepository(_applicationContext);
        _thingRepository = new ThingRepository(_applicationContext);
    }
    
}


