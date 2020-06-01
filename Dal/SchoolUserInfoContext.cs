using Microsoft.EntityFrameworkCore;
using Model;

namespace Dal
{
    public class SchoolUserInfoContext : DbContext
    {
        public SchoolUserInfoContext(DbContextOptions<SchoolUserInfoContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// DbSet实体集属性对应数据库中的表(注意实体集名必须与表明一致)
        /// </summary>
        public DbSet<UserInfo> UserInfos { get; set; }

        /// <summary>
        /// TODO:当数据库创建完成后， EF 创建一系列数据表，表名默认和 DbSet 属性名相同。 集合属性的名称一般使用复数形式，但不同的开发人员的命名习惯可能不一样，开发人员根据自己的情况确定是否使用复数形式。 在定义 DbSet 属性的代码之后，添加下面代码，对DbContext指定单数的表名来覆盖默认的表名。
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
        }
    }
}
