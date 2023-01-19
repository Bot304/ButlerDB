using System;
using System.Collections.Generic;
using System.Text;

namespace ButlerDataBase.Models
{
	class Lighting
	{
		public int Id { get; set; }
		public string LightGroup { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string PhysicalAdr { get; set; }
		public string OutputGroup { get; set; }
		public string Device { get; set; }
		public int ExplicationId { get; set; }
		public Explication Explication { get; set; }
	}
}
