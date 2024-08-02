using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KinhThanhCongGiao.Model.Entities;
using KinhThanhCongGiao.Model.Common;


namespace KinhThanhCongGiao.Infrastructure.Contexts
{
		public class ApplicationDbContext : DbContext
		{
				public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
				{
						ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
				}
				public DbSet<KinhThanh> KinhThanhs { get; set; }
				public DbSet<Author> Authors { get; set; }

				public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
				{
						foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
						{
								switch (entry.State)
								{
										case EntityState.Added:
												entry.Entity.CreatedAt = DateTime.UtcNow;
												entry.Entity.CreatedBy = "Admin" ;
												break;
										case EntityState.Modified:
												entry.Entity.LastModifiedAt = DateTime.UtcNow;
												entry.Entity.LastModifiedBy = "Admin";
												break;
								}
						}
						return base.SaveChangesAsync(cancellationToken);
				}

		}
}
