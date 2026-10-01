namespace lab8_c_
{
    internal static class DbConfig
    {
        // По умолчанию используется SQL Server LocalDB — она устанавливается вместе
        // с Visual Studio и не требует отдельной настройки сервера.
        //
        // Чтобы работать с «боевым» SQL Server Express, как в методичке лабораторной
        // работы, замените строку ниже на:
        // Server=.\SQLEXPRESS;Integrated Security=True;TrustServerCertificate=True;
        public const string ServerConnectionString =
            @"Server=(localdb)\MSSQLLocalDB;Integrated Security=True;TrustServerCertificate=True;";

        public const string DatabaseName = "StudentDB";

        public static string ConnectionString => $"{ServerConnectionString}Database={DatabaseName};";
    }
}
