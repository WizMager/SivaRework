using System.Collections.Generic;
using Controllers.Interfaces;

namespace Controllers.MainController.Impl
{
    public class MainController : IMainController
    {
        private readonly List<IAwake> _awakes = new ();
        private readonly List<IStart> _starts = new ();
        private readonly List<IUpdate> _updates = new ();
        private readonly List<IFixedUpdate> _fixedUpdates = new ();
        private readonly List<ILateUpdate> _lateUpdates = new ();
        private readonly List<IDestroy> _destroys = new ();

        public void AddController(IController controller)
        {
            if (controller is IAwake awake)
            {
               _awakes.Add(awake); 
            }

            if (controller is IStart start)
            {
                _starts.Add(start);
            }

            if (controller is IUpdate update)
            {
                _updates.Add(update);
            }

            if (controller is IFixedUpdate fixedUpdate)
            {
                _fixedUpdates.Add(fixedUpdate);
            }

            if (controller is ILateUpdate lateUpdate)
            {
                _lateUpdates.Add(lateUpdate);
            }

            if (controller is IDestroy destroy)
            {
                _destroys.Add(destroy);
            }
        }
        
        public void RemoveController(IController controller)
        {
            if (controller is IAwake awake)
            {
                _awakes.Remove(awake); 
            }

            if (controller is IStart start)
            {
                _starts.Remove(start);
            }

            if (controller is IUpdate update)
            {
                _updates.Remove(update);
            }

            if (controller is IFixedUpdate fixedUpdate)
            {
                _fixedUpdates.Remove(fixedUpdate);
            }

            if (controller is ILateUpdate lateUpdate)
            {
                _lateUpdates.Remove(lateUpdate);
            }

            if (controller is IDestroy destroy)
            {
                _destroys.Remove(destroy);
            }
        }

        public void Awake()
        {
            foreach (var awake in _awakes)
            {
                awake.OnAwake();
            }
        }

        public void Start()
        {
            foreach (var start in _starts)
            {
                start.OnStart();
            }
        }

        public void Update()
        {
            foreach (var update in _updates)
            {
                update.OnUpdate();
            }
        }

        public void FixedUpdate()
        {
            foreach (var fixedUpdate in _fixedUpdates)
            {
                fixedUpdate.OnFixedUpdate();
            }
        }

        public void LateUpdate()
        {
            foreach (var lateUpdate in _lateUpdates)
            {
                lateUpdate.OnLateUpdate();
            }
        }

        public void Destroy()
        {
            foreach (var destroy in _destroys)
            {
                destroy.OnDestroy();
            }
        }
    }
}