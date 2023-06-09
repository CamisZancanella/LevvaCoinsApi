﻿using LevvaCoins.Logic.Dtos;

namespace LevvaCoins.Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual List<Transacao>? Transactions { get; set; }
    }
}
