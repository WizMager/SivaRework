using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Assets.Scripts.Ui
{
    [Serializable]
    public class Pool 
    {
        [SerializeField] private PoolObject _textPrefab;
        [SerializeField] private Transform _transform;
        [SerializeField] private List<PoolObject> _listElements;
        [SerializeField] private int _minValue;
        [SerializeField] private int _maxValue;
        [SerializeField] private bool _breakLimitPool;

        public void LimitCheck()
        {
            if (!_breakLimitPool)
                return;
            else _maxValue = int.MaxValue;
        }

        public void CreatePool()
        {
            _listElements = new List<PoolObject>(_minValue);

            for (int i = 0; i < _minValue; i++)
            {
                CreateElement();
            }
        }

        public PoolObject CreateElement(bool isActive = false)
        {
            var element = Object.Instantiate(_textPrefab, _transform);
            element.gameObject.SetActive(isActive);

            _listElements.Add(element);
            return element;
        }

        private bool TryGetElement(out PoolObject poolObject)
        {
            foreach (var item in _listElements)
            {
                if (!item.gameObject.activeInHierarchy)
                {
                    poolObject = item;
                    item.gameObject.SetActive(true);
                    return true;
                }
            }

            poolObject = null;
            return false;
        }

        public PoolObject GetFreeElement()
        {
            if (TryGetElement(out var elenemt))
            {
                return elenemt;
            }

            if (_listElements.Count < _maxValue)
            {
                return CreateElement(true);
            }

            if (_breakLimitPool)
            {
                LimitCheck();
                return CreateElement(true);                
            }

            throw new Exception("pool is over");
        }
    }
}
