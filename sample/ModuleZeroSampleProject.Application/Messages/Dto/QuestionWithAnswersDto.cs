using System.Collections.Generic;

namespace ModuleZeroSampleProject.Messages.Dto
{
    public class QuestionWithAnswersDto : QuestionDto
    {
        public List<AnswerDto> Answers { get; set; }
    }
}