using EmployeeCredentials.Data;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeCredentialsApp;

internal static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();

		var task = RunApplicationAsync();
		task.GetAwaiter().GetResult();
	}

	static async Task RunApplicationAsync()
	{
		using var app = CreateHostBuilder().Build();

		try
		{
			await app.Services.ApplyMigrationsAsync();
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при применении миграций: {ex.Message}",
							"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		using var scope = app.Services.CreateAsyncScope();

		try
		{
			await scope.ServiceProvider.SeedAsync();
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при заполнении данных: {ex.Message}",
							"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		var mainForm = scope.ServiceProvider.GetRequiredService<FormMain>();

		try
		{
			Application.Run(mainForm);
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Ошибка при работе приложения: {ex.Message}",
							"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private static IHostBuilder CreateHostBuilder()
	{
		var app = Host.CreateDefaultBuilder();

		app.ConfigureAppConfiguration((context, config) =>
			{
				config.SetBasePath(Directory.GetCurrentDirectory());
				config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
			});

		app.ConfigureServices((context, services) =>
			{
				services.AddServicesData(context.Configuration);

				services.AddTransient<FormMain>();
				services.AddTransient<FormView>();
				services.AddTransient<FormEdit>();
			});

		return app;
	}
}
