﻿using JordnærCase2023.Models;

namespace JordnærCase2023.Interfaces
{
    public interface IItemService
    {
        /// <summary>
        /// henter alle items fra databasen
        /// </summary>
        /// <returns>Liste af items</returns>
        Task<List<Item>> GetAllItemsAsync();

        /// <summary>
        /// Henter et specifikt item fra database 
        /// </summary>
        /// <param name="itemId">Udpeger det item der ønskes fra databasen</param>
        /// <returns>Det fundne item eller null hvis item ikke findes</returns>
        Task<Item> GetItemFromIdAsync(int itemId);

        /// <summary>
        /// Indsætter et nyt item i databasen
        /// </summary>
        /// <param name="item">item der skal indsættes</param>
        /// <returns>Sand hvis der er gået godt ellers falsk</returns>
        Task<bool> CreateItemAsync(Item item);

        /// <summary>
        /// Opdaterer et item i databasen
        /// </summary>
        /// <param name="item">De nye værdier til item</param>
        /// <param name="itemId">Nummer på det item der skal opdateres</param>
        /// <returns>Sand hvis der er gået godt ellers falsk</returns>
        Task<bool> UpdateItemAsync(Item item, int itemId);

        /// <summary>
        /// Sletter et item fra databasen
        /// </summary>
        /// <param name="itemId">Nummer på det item der skal slettes</param>
        /// <returns>Det item der er slettet fra databasen, returnerer null hvis item ikke findes</returns>
        Task<Item> DeleteItemAsync(int itemId);

        /// <summary>
        /// Henter alle items fra databasen, der har det givne navn
        /// </summary>
        /// <param name="name">Angiver navn på item der hentes fra databasen</param>
        /// <returns>Liste af items med det givne navn</returns>
        Task<List<Item>> GetItemsByNameAsync(string name);
    }
}
