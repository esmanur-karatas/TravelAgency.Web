
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string WhatWeDo { get; set; }
        public string WhatWeDoTitle { get; set; }
        public string WhatWeDoDescription{ get; set; }
        public string OurMission{ get; set; }
        public string OurMissionTitle{ get; set; }
        public string OurMissionDescription{ get; set; }
        public string OurGoal{ get; set; }
        public string OurGoalTitle{ get; set; }
        public string OurGoalDescription{ get; set; }
        public string AboutImageUrl { get; set;}
        public bool AboutStatus {  get; set; }
    }
}
