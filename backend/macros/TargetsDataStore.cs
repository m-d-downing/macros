using macros.Models;

namespace macros
{
    public class TargetsDataStore
    {

        public List<TargetDto> Targets { get; set; }

        public static TargetsDataStore Current { get; } = new TargetsDataStore();



        public TargetsDataStore()
        {
            Targets =
            [
                new()
                {
                    Day = DayOfWeek.Monday,
                    Protein = 140,
                    Carbs = 119,
                    Fat = 44
                },
                new()
                {
                    Day = DayOfWeek.Tuesday,
                    Protein = 140,
                    Carbs = 89,
                    Fat = 54
                },
                new()
                {
                    Day = DayOfWeek.Wednesday,
                    Protein = 140,
                    Carbs = 179,
                    Fat = 50
                }
            ];

        }
    }
}