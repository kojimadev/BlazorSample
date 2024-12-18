namespace BlazorWebAssemblySample.Models
{
    /// <summary>
    /// はてなブックマークとしてのエントリを表すクラスです。便宜的に記事という意味で使います。
    /// </summary>
    public class Article
    {
        public string Key { get; set; } = string.Empty;
        public int Number { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int BookmarkCount { get; set; }

        /// <summary>
        /// はてなブックマークのコメントが見れるページのURL
        /// </summary>
        public string EntryUrl { get; set; } = string.Empty;
    }
}
