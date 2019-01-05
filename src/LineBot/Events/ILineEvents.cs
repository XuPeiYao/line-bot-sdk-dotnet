﻿// Copyright 2017-2019 Dirk Lemstra (https://github.com/dlemstra/line-bot-sdk-dotnet)
//
// Dirk Lemstra licenses this file to you under the Apache License,
// version 2.0 (the "License"); you may not use this file except in compliance
// with the License. You may obtain a copy of the License at:
//
//   https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
// WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
// License for the specific language governing permissions and limitations
// under the License.

using System.Collections.Generic;

namespace Line
{
    /// <summary>
    /// Encapsulates the interface for a list of line events.
    /// </summary>
    public interface ILineEvents : IEnumerable<ILineEvent>
    {
        /// <summary>
        /// Gets the user ID of a bot that should receive webhook events.
        /// </summary>
        string Destination { get; }

        /// <summary>
        /// Gets all the events.
        /// </summary>
        IEnumerable<ILineEvent> Events { get; }
    }
}