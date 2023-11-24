using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glow_for_employees.Database
{
    internal class FeedbackTable
    {
        public ulong FeedbackId { get; set; }
        public string FeedbackSender { get; set; }
        public string Theme { get; set; }
        public string FeedbackMessage { get; set; }
        public string FeedbackStatus { get; set; }
    }
}
