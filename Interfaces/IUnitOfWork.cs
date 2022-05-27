namespace DatingApp.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IMessageRepository MessageRepository { get; }
        ILikesRepository LikesRepository { get; }

        Task<bool> Complete();

        bool HasChanges(); // Tracking if EF has made any changes
    }
}