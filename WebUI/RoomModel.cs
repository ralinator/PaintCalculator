namespace WebUI
{
    public class RoomModel
    {
        [DimensionValidator(nameof(Length))]
        public decimal Length { get; set; } = 1;
        [DimensionValidator(nameof(Width))]
        public decimal Width { get; set; } = 1;
        [DimensionValidator(nameof(Height))]
        public decimal Height { get; set; } = 1;
    }
}
