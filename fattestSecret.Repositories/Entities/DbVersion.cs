using Insight.Database;

namespace fattestSecret.Repositories.Entities
{
    [Sql(Schema = "dbo")]
    public class DbVersion
    {
        public string Version { get; set; }
    }
}
