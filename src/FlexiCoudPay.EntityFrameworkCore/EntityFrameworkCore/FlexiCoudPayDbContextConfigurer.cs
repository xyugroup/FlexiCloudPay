using System.Data.Common;
using Microsoft.EntityFrameworkCore;


namespace FlexiCoudPay.EntityFrameworkCore
{
    public static class FlexiCoudPayDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FlexiCoudPayDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
            //var serverVersion = ServerVersion.AutoDetect(connectionString);
            //builder.UseMySql(connectionString,serverVersion);
        }

        public static void Configure(DbContextOptionsBuilder<FlexiCoudPayDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
            //builder.UseMySQL(connection);
            //var serverVersion = ServerVersion.AutoDetect(connection.ConnectionString);
            //builder.UseMySql(connection, serverVersion);
        }
    }
}
