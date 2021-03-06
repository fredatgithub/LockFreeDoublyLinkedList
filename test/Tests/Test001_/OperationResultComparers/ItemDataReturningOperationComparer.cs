﻿#region license
// Copyright 2016 Christoph Müller
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//    http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Tests.Test001_.Operations;

namespace Test.Tests.Test001_.OperationResultComparers
{
    internal class ItemDataReturningOperationComparer
        : OperationResultComparer<ItemDataReturningOperation, ListItemData, ListItemData>
    {
	    public override bool LastResultsEqual
        {
            get { return Equals(LfdllResult, LlResult); }
        }

	    public ItemDataReturningOperationComparer(
            ItemDataReturningOperation operation) : base(operation)
        {
        }
    }
}
