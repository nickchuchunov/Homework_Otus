using Microsoft.Extensions.DependencyInjection;
using DigitalRiddles.RandomGenerator;
using DigitalRiddles.GameGuessNumber;


var services = new ServiceCollection();
services.AddSingleton<IGeneratorRndom, RandomNumbergenerator>( );
services.AddSingleton<IConsoleGameGuessNumber, ConsoleGameGuessNumber>();
services.AddSingleton<IGuessNumber, GameGuessNumber> ();

services.BuildServiceProvider();
var serviceProvider = services.BuildServiceProvider();

new GameGuessNumber(serviceProvider.GetService<IGeneratorRndom>(), serviceProvider.GetService<IConsoleGameGuessNumber>()).StartGamesNumber();






