using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Ui
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _inventoryItems;

        public List<GameObject> InventoryItems => _inventoryItems;
    }
}
