using Controllers.Interfaces;

namespace Controllers.MainController
{
    public interface IMainController
    {
        void AddController(IController controller);

        void RemoveController(IController controller);
    }
}