using Zenject;
using UnityEngine;
using Assets.Scripts.Ui;

namespace Assets.Scripts.Installers
{
    public class UIInstaller : MonoInstaller
    {
        [SerializeField] private PopUpView popUpView;
        [SerializeField] private InventoryView inventoryView;

        public override void InstallBindings()
        {
            Container.Bind<PopUpView>().FromInstance(popUpView).AsSingle();
            Container.Bind<InventoryView>().FromInstance(inventoryView).AsSingle();
        }
    }
}
