﻿//Copyright 2014 Christoph Müller

//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at

//   http://www.apache.org/licenses/LICENSE-2.0

//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Tests.Test001_
{
    class LinkedListItem
    {
        public bool Deleted { get; private set; }
        public ListItemData Data { get; private set; }

        public void Delete()
        {
            Deleted = true;
        }

        public LinkedListItem NewWithData(ListItemData data)
        {
            return new LinkedListItem(data)
            {
                Deleted = Deleted,
            };
        }

        public override string ToString()
        {
            return "<" + Data + ">" + (Deleted ? "D" : "");
        }

        public LinkedListItem(ListItemData data)
        {
            Data = data;
        }
    }
}