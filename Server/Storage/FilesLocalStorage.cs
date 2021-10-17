using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMoviesDiasteros.Server.Storage
{
    public class FilesLocalStorage : IFilesStorageClass
    {
        private readonly IWebHostEnviroment enviroment;
        private readonly IHttpContextAccessor httpContextAccessor;

        public FilesLocalStorage(IWebHostEnviroment enviroment, IHttpContextAccessor httpContextAccessor)
        {
            this.enviroment = enviroment;
            this.httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SaveFile(byte[] content, string extension, string nameFold)
        {
            var fileName =$"{Guid.NewGuid()}.{extension}";
            string folder = Path.Combine(environment.WebRootPath, nameFold);
            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            string routePhoto = Path.Combine(folder, fileName);
            await File.WriteAllBytesAsync(routePhoto, content);
            var uriAzure =$"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}";
            var uriLocal = Path.Combine(uriAzure, nameFold, fileName);
            return uriLocal;
        }

        public Task DeleteFile(string route, string nameFold)
        {
            var fileName = Path.GetFileName(route);
            string currentPath = Path.Combine(environment.WebRootPath, nameFold, fileName);
            if(File.Exists(currentPath))
            {
                File.Delete(currentPath);
            }
            return Task.FromResult(0);
        }

        public async Task<string> EditFile(byte[] content, string extension, string nameFold, string route)
        {
            if(!string.IsNullOrEmpty(route))
            {
                await DeleteFile(route,nameFold);
            }
            return await SaveFile(content,extension,nameFold);
        }
    }
}