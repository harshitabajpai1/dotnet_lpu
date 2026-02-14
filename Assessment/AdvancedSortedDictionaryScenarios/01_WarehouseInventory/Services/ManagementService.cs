
using System.Collections.Generic;
using Domain;
using Exceptions;

namespace Services
{
    public class ManagementService
    {
        private SortedDictionary<int, List<PrimaryEntity>> _data 
            = new SortedDictionary<int, List<PrimaryEntity>>();

        public void AddEntity(PrimaryEntity entity)
        {
            // TODO: Add entity with validation
            if(entity == null)
            {
                throw new ArgumentException("entity cant be null");
            }
                entity.Validate();
            if (!_data.ContainsKey(entity.PriorityOrKey))
            {
                _data[entity.PriorityOrKey] = new List<PrimaryEntity>();
            }
            _data[entity.PriorityOrKey].Add(entity);
        }

        public void RemoveEntity(int key)
        {
            // TODO: Remove entity logic
            if (!_data.ContainsKey(key))
            {
                throw new CustomScenarioException("key not found");
            }
            _data.Remove(key);
        }

        public IEnumerable<PrimaryEntity> GetAll()
        {
            // TODO: Return sorted data
            List<PrimaryEntity> result = new List<PrimaryEntity>();
            foreach(var item in _data)
            {
                result.AddRange(item.Value);c
            }
            return result;
        }
    }
}
