using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Mappers
{
    public static class StepMapper
    {
        public static StepDto MapToStepDto(this Step step)
        {
            return new StepDto(
                step.Id,
                step.OrderNumber,
                step.Description,
                step.RecipeId);
        }

        public static Step MapToStep(this StepDto step)
        {
            return new Step(
                step.OrderNumber,
                step.Description,
                step.RecipeId);
        }
    }
}
