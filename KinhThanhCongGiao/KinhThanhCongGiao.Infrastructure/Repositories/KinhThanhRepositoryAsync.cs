using KinhThanhCongGiao.Application.Interfaces.Repositories;
using KinhThanhCongGiao.Infrastructure.Contexts;
using KinhThanhCongGiao.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinhThanhCongGiao.Infrastructure.Repositories
{
		public class KinhThanhRepositoryAsync : GenericRepositoryAsync<KinhThanh>, IKinhThanhRepositoryAsync
		{
				private readonly DbSet<KinhThanh> _kinhThanhs;

				public KinhThanhRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
				{
						_kinhThanhs = dbContext.Set<KinhThanh>();
				}

				public Task<bool> IsExistKTAsync(string content)
				{
						return _kinhThanhs
								.AllAsync(p => string.Equals(p.Content, content));
				}
		}
}
