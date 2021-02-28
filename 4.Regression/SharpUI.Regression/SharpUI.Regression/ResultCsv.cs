namespace SharpUI.Regression
{
    [Ezfx.Csv.CsvObject(HasHeader =true, MappingType= Ezfx.Csv.CsvMappingType.Title)]
    public class ResultCsv
    {
        public string Package { get; set; }
        public string Category { get; set; }
        public string Algorithm { get; set; }
        public string Dataset { get; set; }
        public string Metrics { get; set; }
        public float Score { get; set; }
    }
}
