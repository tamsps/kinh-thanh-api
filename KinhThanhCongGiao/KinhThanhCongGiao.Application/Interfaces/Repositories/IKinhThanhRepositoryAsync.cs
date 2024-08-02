using KinhThanhCongGiao.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinhThanhCongGiao.Application.Interfaces.Repositories
{
		public interface IKinhThanhRepositoryAsync : IGenericRepositoryAsync<KinhThanh>
		{
				Task<bool> IsExistKTAsync(string content);
		}
}
