namespace BSG.Library.FormsApp.Models
{
    public class ComboBoxItem
    {
        public int Key { get; set; }
        public object Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
