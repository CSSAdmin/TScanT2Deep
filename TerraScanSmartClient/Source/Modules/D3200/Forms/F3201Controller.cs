﻿namespace D3200
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.Practices.CompositeUI;

    public class F3201Controller : Controller 
    {
        /// <summary>
        /// Gets the work item.
        /// </summary>
        /// <value>The work item.</value>
        public new F3201WorkItem WorkItem
        {
            get { return base.WorkItem as F3201WorkItem; }
        }
    }
}