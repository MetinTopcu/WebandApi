

namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        // Unit Of Work Design pattern; database işlemlerini tek tek değil interfacede toplayıp toplu savechange yapar.
        // hiçbir yere tanımlamadık bir şey yapmadık nasıl kullanıyoruz bilmiyorum

        Task CommitAsync();
        void Commit();
    }
}
