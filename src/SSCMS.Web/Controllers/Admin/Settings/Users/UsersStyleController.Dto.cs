﻿using System.Collections.Generic;

namespace SSCMS.Web.Controllers.Admin.Settings.Users
{
    public partial class UsersStyleController
    {
        public class GetResult
        {
            public List<Style> Styles { get; set; }
            public string TableName { get; set; }
            public List<int> RelatedIdentities { get; set; }
        }

        public class Style
        {
            public int Id { get; set; }
            public string AttributeName { get; set; }
            public string DisplayName { get; set; }
            public string InputType { get; set; }
            public IEnumerable<TableStyleRule> Rules { get; set; }
            public int Taxis { get; set; }
            public bool IsSystem { get; set; }
        }

        public class DeleteRequest
        {
            public string AttributeName { get; set; }
        }

        public class DeleteResult
        {
            public List<Style> Styles { get; set; }
        }

        public class ResetResult
        {
            public List<Style> Styles { get; set; }
        }
    }
}
