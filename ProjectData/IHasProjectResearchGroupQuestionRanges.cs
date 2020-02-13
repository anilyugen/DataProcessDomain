using System;
using System.Collections.Generic;
using System.Text;

namespace Exa.DataProcess.Domain.ProjectData
{
    public interface IHasProjectResearchGroupQuestionRanges<T>
    { 
        List<ProjectResearchGroupQuestionRange<T>> QuestionRanges { get; set; }
    }
}