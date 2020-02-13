using System;
using System.Collections.Generic;
using System.Text;

namespace Exa.DataProcess.Domain.ProjectData.ProjectResearchGroups
{
    public abstract class QuestionBasedProjectResearchGroup : ProjectResearchGroup
    {
        public List<ProjectResearchGroupQuestion> Questions { get; set; }

        public QuestionBasedProjectResearchGroup()
        {
            this.Questions = new List<ProjectResearchGroupQuestion>();
        }
    }
}