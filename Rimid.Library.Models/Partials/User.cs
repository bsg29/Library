using Rimid.Library.Models.Enums;

namespace Rimid.Library.Models
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
