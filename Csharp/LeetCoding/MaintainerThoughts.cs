using System;
using System.Collections.Generic;
using System.Text;

namespace Maintainer
{
    
    public class MaintenanceItem
    {
        #region Skeleton
        //name 
        public string Name { get; set; }
        //description
        public string Description { get; set; }
        //interval
        public int MyProperty { get; set; }
        //subsystem
        public string Subsystem { get; set; }
        //subdescription
        public string Subdescription { get; set; } //maybe remove
        //type of maintenance

        //tag
        public List<string> Tags { get; set; }
        //references
        private List<string> _References;

        public List<string> References
        {
            get { return _References; }
            set { _References = value; }
        }

        //scheduledate
        public DateTime ScheduledDate { get; set; }
        //maintenance history
        public List<DateTime> MaintenanceHistory { get; set; }
        //notes
        public string Notes { get; set; }
        //blob for holding files?
        private List<Dictionary<string, string>> _Resources;

        public List<Dictionary<string, string>> Resources
        {
            get { return _Resources; }
            set { _Resources = value; }
        }
        public List<string> RequiredTools { get; set; }

    }
    #endregion
    public class MaintenanceInterval
    {
        public int Time { get; set; }
        
        public MaintenanceInterval()
        {

        }
    }

    //database holding maintenance items

}
