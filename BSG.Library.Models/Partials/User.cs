using BSG.Library.Models.Enums;

namespace BSG.Library.Models
{
    public partial class User
    {
        public PositionEnum PositionWrapper
        {
            get => (PositionEnum) PositionId;
            set => PositionId = (int) value;
        }
    }
}
