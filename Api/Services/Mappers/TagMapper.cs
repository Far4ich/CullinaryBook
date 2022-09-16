using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Mappers
{
    public static class TagMapper
    {
        public static TagDto MapToTagDto(this Tag tag)
        {
            return new TagDto(tag.Title);
        }

        public static Tag MapToTag(this TagDto tag)
        {
            return new Tag(tag.Title);
        }
    }
}
