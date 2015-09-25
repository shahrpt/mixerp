/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/
// ReSharper disable All
using PetaPoco;
using System;

namespace MixERP.Net.Entities.Core
{
    [PrimaryKey("", autoIncrement = false)]
    [TableName("core.filter_name_view")]
    [ExplicitColumns]
    public sealed class FilterNameView : PetaPocoDB.Record<FilterNameView>, IPoco
    {
        [Column("object_name")]
        [ColumnDbType("text", 0, true, "")]
        public string ObjectName { get; set; }

        [Column("filter_name")]
        [ColumnDbType("text", 0, true, "")]
        public string FilterName { get; set; }

        [Column("is_default")]
        [ColumnDbType("bool", 0, true, "")]
        public bool? IsDefault { get; set; }
    }
}