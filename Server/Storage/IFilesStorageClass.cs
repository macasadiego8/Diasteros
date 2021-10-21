using System.Threading.Tasks;
namespace ProjectMoviesDiasteros.Server.Storage
{
    public interface IFilesStorageClass
    {
         Task<string> SaveFile(byte[] contenido, string extension, string nameFold);
         Task DeleteFile(string route, string FilesStorage);
         Task<string> EditFile(byte[] contenido, string extension, string nameFold, string route);
    }
}