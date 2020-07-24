using Microsoft.Extensions.DependencyInjection;
using DecimalToRomanConverter.Application.Services;

namespace DecimalToRomanConverter.ConsoleUI
{
    public class DependencyInjection
    {
        public static ServiceProvider Setup() => 
                new ServiceCollection()
                .AddTransient<IDecimalConverterService, DecimalConverterService>()
                .BuildServiceProvider();
    }
}
