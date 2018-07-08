﻿// Copyright 2006 Herre Kuijpers - <herre@xs4all.nl>
//
// This source file(s) may be redistributed, altered and customized
// by any means PROVIDING the authors name and all copyright
// notices remain intact.
// THIS SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED. USE IT AT YOUR OWN RISK. THE AUTHOR ACCEPTS NO
// LIABILITY FOR ANY DATA DAMAGE/LOSS THAT THIS PRODUCT MAY CAUSE.
//-----------------------------------------------------------------------

//--------------------------------------------------------------------------------
// Copyright (C) 2013-2015 JDH Software - <support@jdhsoftware.com>
//
// This program is provided to you under the terms of the Microsoft Public
// License (Ms-PL) as published at https://kryptonoutlookgrid.codeplex.com/license
//
// Visit http://www.jdhsoftware.com and follow @jdhsoftware on Twitter
//
//--------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

using KryptonOutlookGrid.Classes;

namespace KryptonOutlookGrid.Interfaces
{
    /// <summary>
    /// IOutlookGridGroup specifies the interface of any implementation of a OutlookGridGroup class
    /// Each implementation of the IOutlookGridGroup can override the behaviour of the grouping mechanism
    /// Notice also that ICloneable must be implemented. The OutlookGrid makes use of the Clone method of the Group
    /// to create new Group clones. Related to this is the OutlookGrid.GroupTemplate property, which determines what
    /// type of Group must be cloned.
    /// </summary>
    public interface IOutlookGridGroup : IComparable, ICloneable
    {
        /// <summary>
        /// the text to be displayed in the group row
        /// </summary>
        string Text { get; } //set; }

        /// <summary>
        /// determines the value of the current group. this is used to compare the group value
        /// against each item's value.
        /// </summary>
        object Value { get; set; }

        /// <summary>
        /// indicates whether the group is collapsed. If it is collapsed, it group items (rows) will
        /// not be displayed.
        /// </summary>
        bool Collapsed { get; set; }

        /// <summary>
        /// specifies the number of items that are part of the current group
        /// this value is automatically filled each time the grid is re-drawn
        /// e.g. after sorting the grid.
        /// </summary>
        int ItemCount { get; set; }

        /// <summary>
        /// specifies the default height of the group
        /// each group is cloned from the GroupStyle object. Setting the height of this object
        /// will also set the default height of each group.
        /// </summary>
        int Height { get; set; }

        //New additions

        /// <summary>
        /// specifies which column is associated with this group
        /// </summary>
        OutlookGridColumn Column { get; set; }

        /// <summary>
        /// The list of the rows contained in a group
        /// </summary>
        List<OutlookGridRow> Rows { get; set; }

        /// <summary>
        /// The parent group if any
        /// </summary>
        IOutlookGridGroup ParentGroup { get; set; }

        /// <summary>
        /// The level in the depth of groups 
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// The children groups
        /// </summary>
        OutlookGridGroupCollection Children { get; set; }

        /// <summary>
        /// Format style of the cell
        /// </summary>
        string FormatStyle { get; set; }

        /// <summary>
        /// Image associated to the group if any
        /// </summary>
        Image GroupImage { get; set; }

        /// <summary>
        /// The text associated for the group text (1 item)
        /// </summary>
        string OneItemText { get; set; }

        /// <summary>
        /// The text associated for the group text (XXX items)
        /// </summary>
        string XXXItemsText { get; set; }

        /// <summary>
        /// Allows the column to be hidden when it is grouped by
        /// </summary>
        bool AllowHiddenWhenGrouped { get; set; }

        /// <summary>
        /// Sort groups using count items value
        /// </summary>
        bool SortBySummaryCount { get; set; }

        /// <summary>
        /// Gets or sets the items comparer.
        /// </summary>
        /// <value>
        /// The items comparer.
        /// </value>
        IComparer ItemsComparer { get; set; }
    }
}