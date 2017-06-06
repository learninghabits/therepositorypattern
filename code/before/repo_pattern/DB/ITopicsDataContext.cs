using System.Data.Entity;

namespace repo_pattern.DB
{
    public interface ITopicsDataContext
    {
        IDbSet<Topic> Topics { get; set; }
        IDbSet<Tutorial> Tutorials { get; set; }
    }
}
