namespace Controllers.Interfaces
{
    public interface ILateUpdate : IController
    {
        void OnLateUpdate();
    }
}