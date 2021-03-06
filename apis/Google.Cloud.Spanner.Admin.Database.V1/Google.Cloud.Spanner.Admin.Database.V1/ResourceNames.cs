// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gcscv = Google.Cloud.Spanner.Common.V1;
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Spanner.Admin.Database.V1
{


    public partial class CreateDatabaseMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Database
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DropDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get { return string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateDatabaseDdlMetadata
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

}