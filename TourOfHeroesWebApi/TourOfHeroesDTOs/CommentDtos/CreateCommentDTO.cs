﻿namespace TourOfHeroesDTOs.CommentDtos
{
    public class CreateCommentDTO
    {
        public string Comment { get; set; }

        public string UserId { get; set; }

        public int HeroId { get; set; }

        public string Action { get; set; }
    }
}