using GridShared;

namespace GridBlazor.Pagination
{
    public interface IGridPager
    {
        /// <summary>
        ///     Pager's Grid
        /// </summary>
        IGrid Grid { get; }

        /// <summary>
        ///     Max grid items, displaying on the page
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        ///     Enable changing page size on view
        /// </summary>
        bool ChangePageSize { get; set; }

        /// <summary>
        ///     Max grid items, displaying on the page configured on the view
        /// </summary>
        int QueryPageSize { get; set; }

        /// <summary>
        ///     Current page index
        /// </summary>
        int CurrentPage { get; }

        int ItemsCount { get; set; }

        ///// <summary>
        /////     Total pages count
        ///// </summary>
        int PageCount { get; }

        /// <summary>
        ///     Start index
        /// </summary>
        int StartIndex { get; }

        /// <summary>
        ///     Virtualized items count
        /// </summary>
        int VirtualizedCount { get; }

        
        ///// <summary>
        /////     Show the Prev and Next buttons even if they are disabled.
        ///// </summary>
        public bool PrevNextAlwaysVisible  { get; set; }
    }
}