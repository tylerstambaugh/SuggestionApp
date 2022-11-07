namespace SuggestionAppUI;

public static class RegisterServices
{
    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddMemoryCache();

        //One db connection for everyone to use:
        builder.Services.AddSingleton<IDbConnection, DbConnection>();
        //For signleton per user
        // builder.Services.AddScoped<IDbConnection, DbConnection>();

        // would allow for separate instances for each user
        //builder.Services.AddTransient<ICategoryData, MongoCategoryData>();
        builder.Services.AddSingleton<ICategoryData, MongoCategoryData>();
        builder.Services.AddSingleton<IStatusData, MongoStatusData>();
        builder.Services.AddSingleton<ISuggestionData, MongoSuggestionData>();
        builder.Services.AddSingleton<IUserData, MongoUserData>();


    }
}
