using System.ComponentModel.DataAnnotations;

namespace BlazorServerSide.Models
{
    public class WSK
    {
        [Key]
        public int Id { get; set; }
        public int ProductionYearDate { get; set; }
        public int? FrameNumberFrom { get; set; }
        public int? FrameNumberTo { get; set; }
        public int? EngineNumberFrom { get; set; }
        public int? EngineNumberTo { get; set; }
        public string Localization { get; set; }

        public WSK(int productionYearDate, int? frameNumberFrom, int? frameNumberTo, int? engineNumberFrom, int? engineNumberTo)
        {
            ProductionYearDate = productionYearDate;
            FrameNumberFrom = frameNumberFrom;
            FrameNumberTo = frameNumberTo;
            EngineNumberFrom = engineNumberFrom;
            EngineNumberTo = engineNumberTo;
        }
    }
}
