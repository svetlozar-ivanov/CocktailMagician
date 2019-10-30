﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CocktailMagician.Data.Models
{
    public class CocktailEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Recipe { get; set; }
        public double? Rating { get; set; }
        public bool IsHidden { get; set; }
        public string ImagePath { get; set; }
        public IEnumerable<BarCocktailEntity> BarCocktails { get; set; }
        public IEnumerable<CocktailIngredientEntity> CocktailIngredients { get; set; }
        public IEnumerable<CocktailReviewEntity> CocktailReviews { get; set; }
    }
}