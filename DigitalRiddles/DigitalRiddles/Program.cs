using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DigitalRiddles.RandomGenerator;
using DigitalRiddles.GameGuessNumber;









HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);


builder.Services.AddSingleton<IGeneratorRndom, RandomNumbergenerator>( );
builder.Services.AddSingleton<IUserInterfaceGameGuessNumber, UserInterfaceGameGuessNumber>();
builder.Services.AddSingleton<IGuessNumber, GuessNumber > ();

IHost app = builder.Build();

GuessNumber guessNumber = new GuessNumber(app.Services);

app.Run();

app.Start();




