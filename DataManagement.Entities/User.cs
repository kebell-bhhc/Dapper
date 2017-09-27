using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataManagement.Entities
{
    [Dapper.Contrib.Extensions.Table("User")]           // This doesn't appear to work Dapper is changing table name to Users pluralizing it
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]     // This works using the EF data annotations for Dommel
        public int UserId
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string UserMobile
        {
            get;
            set;
        }
        public string UserEmail
        {
            get;
            set;
        }
        public string FaceBookUrl
        {
            get;
            set;
        }
        public string LinkedInUrl
        {
            get;
            set;
        }
        public string TwitterUrl
        {
            get;
            set;
        }
        public string PersonalWebUrl
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
    }
}
