using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class School : ISchool
    {
        private ILogger _logger;
        public School(ILogger logger)
        {
            _logger = logger;
        }

        public void StartSchool()
        {
            _logger.ShareMessage("Started new school");
        }
    }
}
