﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.  Code forked from Betsegaw Tadele's https://github.com/betsegaw/windowwalker/

namespace WindowWalker.Components
{
    /// <summary>
    /// A class to represent a search string
    /// </summary>
    /// <remarks>Class was added inorder to be able to attach various context data to
    /// a search string</remarks>
    internal class SearchString
    {
        /// <summary>
        /// Gets where is the search string coming from (is it a shortcut
        /// or direct string, etc...)
        /// </summary>
        public SearchResult.SearchType SearchType
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the actual text we are searching for
        /// </summary>
        public string SearchText
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchString"/> class.
        /// Constructor
        /// </summary>
        /// <param name="searchText"></param>
        /// <param name="searchType"></param>
        public SearchString(string searchText, SearchResult.SearchType searchType)
        {
            SearchText = searchText;
            SearchType = searchType;
        }
    }
}
