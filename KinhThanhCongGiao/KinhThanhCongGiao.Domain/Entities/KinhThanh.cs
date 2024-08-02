using KinhThanhCongGiao.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinhThanhCongGiao.Domain.Entities
{
		internal class KinhThanh : AuditableBaseEntity
		{
				public KinhThanh() { }
				public int Id {  get; set; }
				public int KinhThanhType {  get; set; }
				public string Author { get; set; }
				public string Title { get; set; }
				public string Content { get; set; }
				public string Section { get; set; }
				public int From { get; set; }	
				public int To { get; set; }

		}
}
