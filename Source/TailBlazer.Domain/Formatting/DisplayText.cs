
namespace TailBlazer.Domain.Formatting
{


    public class DisplayText
    {
        public string Text { get; }
        public bool Highlight { get; }

        public DisplayText(MatchedString matchedString)
        {
            Text = matchedString.Part;
            Highlight = matchedString.IsMatch;
        }

    }
}
