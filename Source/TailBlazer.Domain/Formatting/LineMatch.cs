using TailBlazer.Domain.FileHandling.Search;

namespace TailBlazer.Domain.Formatting
{
    public class LineMatch
    {
        private readonly SearchMetadata _searchMetadata;

        public LineMatch(SearchMetadata searchMetadata)
        {
            _searchMetadata = searchMetadata;
        }

        public string Text => _searchMetadata.SearchText;

        public bool UseRegex => _searchMetadata.UseRegex;
    }
}