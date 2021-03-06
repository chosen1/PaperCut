﻿// Papercut
// 
// Copyright © 2008 - 2012 Ken Robertson
// Copyright © 2013 - 2014 Jaben Cargman
//  
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//  
// http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Papercut.Services
{
    using Papercut.Core.Events;
    using Papercut.Helpers;

    using Serilog;

    public class TempFileCleanupService : IHandleEvent<PapercutClientExitEvent>
    {
        readonly ILogger _logger;

        public TempFileCleanupService(ILogger logger)
        {
            _logger = logger;
        }

        public void Handle(PapercutClientExitEvent @event)
        {
            // time for temp file cleanup
            MailMessageHelper.TryCleanUpTempFiles(_logger);
        }
    }
}