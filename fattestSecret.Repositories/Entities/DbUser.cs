using Insight.Database;
using System;
using System.Threading.Tasks;

namespace fattestSecret.Repositories.Entities
{
    [Sql(Schema = "dbo")]
    public class DbUser
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string UserLogin { get; set; }
        public string Password { get; set; }
        public bool ConfirmPassword { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}