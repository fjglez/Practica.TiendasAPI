﻿
using Practica.TiendasAPI.Entities;

namespace Practica.TiendasAPI.Services
{
    public interface ITiendaRepository
    {
        //IEnumerable<City> GetCities();// IQueryable otra opcion
        Task<(IEnumerable<Tienda>, PaginationMetadata)> GetTiendasAsync(string? filterBy, string? query, int pageSize, int pageNumber);
        Task<Tienda?> GetTiendaAsync(int id, bool includeProductos);
        Task<(IEnumerable<Producto>, PaginationMetadata)> GetProductosAsync(int shopId, int pageSize, int pageNumber);
        Task<Producto?> GetProductoAsync(int shopId, int productId);
        Task<bool> TiendaExistsAsync(int shopId);
        Task AddProductoAsync(int shopId, Producto product);
        void RemoveProducto(Producto product);

        Task<bool> SaveChangesAsync();
    }
}
