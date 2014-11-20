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


//#define SynchronizedLfdll


#if SynchronizedLfdll
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LockFreeDoublyLinkedList
{
    /// <summary>
    /// A threadsafe Counter.
    /// </summary>
    public class Counter
    {
        /// <summary>
        /// The current counter value.
        /// </summary>
        public long Current
        {
            get { return Interlocked.Read(ref value); }
        }

        /// <summary>
        /// Inkrement the counter value.
        /// </summary>
        /// <returns>The new counter value.</returns>
        public long Count()
        {
            return Interlocked.Increment(ref value);
        }

        private long value = 0;
    }
}
#endif