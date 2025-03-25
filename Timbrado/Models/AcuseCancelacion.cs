using Newtonsoft.Json;

namespace Timbrado.Models
{
	public class AcuseCancelacion
	{
		[JsonProperty("acuse")]
		public string Acuse { get; set; }

		[JsonProperty("uuid")]
		public Object Uuid { get; set; }
	}
}
