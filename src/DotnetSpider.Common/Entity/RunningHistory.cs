using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DotnetSpider.Common.Entity
{
	/// <summary>
	/// 运行记录
	/// </summary>
	public class RunningHistory
	{
		[Key]
		/// <summary>
		/// 任务实例标识
		/// </summary>
		[StringLength(32)]
		public string Identity { get; set; }

		/// <summary>
		/// 任务的优先级
		/// </summary>
		[Required]
		[StringLength(32)]
		public string JobId { get; set; }

		/// <summary>
		/// 任务状态
		/// </summary>
		public Status Status { get; set; }

		/// <summary>
		/// 实例创建时间
		/// </summary>
		public DateTime CreationTime { get; set; }

		/// <summary>
		/// 修改时间
		/// </summary>
		public DateTime? LastModificationTime { get; set; }
	}
}
