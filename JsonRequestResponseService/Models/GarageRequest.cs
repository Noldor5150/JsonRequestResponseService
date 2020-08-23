using System.Collections.Generic;

namespace JsonRequestResponseService.Models
{
    public class GarageRequest
    {
        public string Name { get; set; }
        public string SortType { get; set; }
        public List<string> Cars { get; set; }
    }
}
